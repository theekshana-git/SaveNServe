using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Permissions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing.Text;
using static System.Windows.Forms.AxHost;
using System.Net.NetworkInformation;

namespace SaveNServe
{
    public partial class InventoryControl : UserControl
    {
        public InventoryControl()
        {
            InitializeComponent();
            Clearbtn.Click += Clearbtn_Click;
            dgvInventory.CellFormatting += dgvInventory_CellFormatting;



        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            foreach (var lbl in new[] { lblNameError , lblQuantityError , lblUnitError , lblDateError })
            {
                lbl.Visible = false;
            }

            // Get user inputs
            string name = Name_txtbox.Text.Trim();
            string quantity = Quantity_txtbox.Text.Trim();
            string unit = cmbUnit.SelectedItem?.ToString();
            DateTime expirydate = ExpiryDatePicker.Value;
            

            bool ErrorCheck = false;

            //Validation Checks
            if (string.IsNullOrEmpty(name))
            {
                lblNameError.Text = "Name is required";
                lblNameError.Visible = true;
                Name_txtbox.Focus();
                ErrorCheck = true;
            }

            if ((string.IsNullOrEmpty(quantity) || !decimal.TryParse(quantity, out decimal costInput) || costInput < 0))
            {
                lblQuantityError.Text = "Enter a Valid Number";
                lblQuantityError.Visible = true;
                Quantity_txtbox.Focus();
                ErrorCheck = true;
            }

            if (string.IsNullOrEmpty(unit))
            {
                lblUnitError.Text = "Please select a unit";
                lblUnitError.Visible = true;
                cmbUnit.Focus();
                ErrorCheck = true;
            }

           //Date time validation
            if(ExpiryDatePicker.Value.Date == DateTime.Today)
            {
                lblDateError.Text = "Please select a date before continuing";
                lblDateError.Visible = true;
                ExpiryDatePicker.Focus();
                ErrorCheck = true;
            }


            

            if (ErrorCheck)
            {
                return;
            }

            

            InsertInventoryData(name, quantity, unit, expirydate);

            // Clears the Form
            Clearbtn_Click(sender, e);
        }
        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Name_txtbox.Clear();
            Quantity_txtbox.Clear();

            // Revert time to today
            ExpiryDatePicker.Value = DateTime.Today;

            cmbUnit.SelectedIndex = -1;
           

           
        }
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search Ingredient")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                searchBox.Text = "Search Ingredient";
                searchBox.ForeColor = Color.DimGray;
            }
        }

        
        private void InventoryControl_Load(object sender, EventArgs e)
        {
            searchBox.Text = "Search Ingredient";
            searchBox.ForeColor = Color.DimGray;

            searchBox.GotFocus += RemovePlaceholder;
            searchBox.LostFocus += SetPlaceholder;

            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBoxInventory_KeyDown);

            //To set date as today 
            ExpiryDatePicker.Value = DateTime.Today;

            ColName.DataPropertyName = "Name";
            ColQuantity.DataPropertyName = "Quantity";
            ColUnit.DataPropertyName = "Unit";
            colExpireDate.DataPropertyName = "ExpiryDate";
            colStatus.DataPropertyName = "Status";

           
            //Hides InventoryId Column
            DataGridViewTextBoxColumn colInventoryID = new DataGridViewTextBoxColumn();
            colInventoryID.Name = "InventoryID";
            colInventoryID.DataPropertyName = "InventoryID";
            colInventoryID.Visible = false;
            dgvInventory.Columns.Add(colInventoryID);

            dgvInventory.AutoGenerateColumns = false;


            LoadInventoryData();

        }

        private void LoadInventoryData()
        {
            string query = @"
            SELECT 
                ing.Name,
                i.Quantity, 
                i.Unit, 
                i.ExpiryDate,
                i.IngredientID, 
                i.InventoryID,
                 CASE
                    WHEN i.Quantity <= 0 THEN 'Out of Stock'
                    WHEN i.ExpiryDate < GETDATE() THEN 'Expired'
                    WHEN i.Quantity < 2 THEN 'Low'
                    ELSE 'OK'
                 END AS Status
            FROM 
                Inventory i
            INNER JOIN
                Ingredients ing on i.IngredientID = ing.IngredientID
            ORDER BY
                    i.InventoryID DESC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvInventory.DataSource = dt;

        }

        private void searchBoxInventory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                string searchText = searchBox.Text.Trim();

                if (string.IsNullOrEmpty(searchText) || searchText == "Search Ingredient")
                {
                    LoadInventoryData(); // Show all
                    return;
                }

                try
                {
                    string query = @"
                SELECT 
                    i.Name AS Name,
                    inv.Quantity AS Quantity,
                    inv.Unit AS Unit,
                    inv.ExpiryDate AS ExpiryDate,
                    inv.InventoryID AS InventoryID,
                    i.IngredientID AS IngredientID,
                    CASE
                        WHEN inv.Quantity <= 0 THEN 'Out of Stock'
                        WHEN inv.ExpiryDate < GETDATE() THEN 'Expired'
                        WHEN inv.Quantity < 2 THEN 'Low'
                        ELSE 'OK'
                    END AS Status
                FROM 
                    Inventory inv
                JOIN 
                    Ingredients i ON inv.IngredientID = i.IngredientID
                WHERE 
                    i.Name LIKE @SearchText";

                    SqlParameter param = new SqlParameter("@SearchText", "%" + searchText + "%");
                    DataTable result = DatabaseHelper.ExecuteQuery(query, param);

                    dgvInventory.DataSource = result;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search failed: " + ex.Message);
                }
            }
        }

        private void InsertInventoryData(string name, string quantity, string unit, DateTime expirydate)
        {
            string getIdQuery = "SELECT IngredientID FROM Ingredients WHERE Name = @Name";
            SqlParameter[] getIdParams = { new SqlParameter("@Name", name) };
            DataTable result = DatabaseHelper.ExecuteQuery(getIdQuery, getIdParams);

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("Ingredient not found in database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ingredientID = Convert.ToInt32(result.Rows[0]["IngredientID"]);

            // Insert into inventory
            string insertQuery = @"
                        INSERT INTO Inventory (IngredientID, Quantity, Unit, ExpiryDate)
                        VALUES (@IngredientID, @Quantity, @Unit, @ExpiryDate)";

            SqlParameter[] insertParams = new SqlParameter[]
            {
                new SqlParameter("@IngredientID", ingredientID),
                new SqlParameter("@Quantity", quantity),
                new SqlParameter("@Unit", unit),
                new SqlParameter("@ExpiryDate", expirydate),
            };

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Inventory added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInventoryData();
            }
        }


        private void DeleteInventoryBYIngredientID(int InventoryID)
        {
            try
            {
                string deleteQuery = "DElETE from Inventory WHERE InventoryID =  @InventoryID";

                SqlParameter[] parameters = {
                new SqlParameter("@InventoryID", InventoryID)
            };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(deleteQuery, parameters);

                if (rowsAffected > 0)
                {
                    LoadInventoryData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting inventory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Skip header row clicks or out of range rows
            if (e.RowIndex < 0 || e.RowIndex >= dgvInventory.Rows.Count)
                return;

            // Check if it's the "Delete" column
            if (dgvInventory.Columns[e.ColumnIndex].Name == "ColActions") // use your actual column name
            {
                // Show confirmation dialog
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this inventory item?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    // Get InventoryID from the selected row
                    int InventoryID = Convert.ToInt32(dgvInventory.Rows[e.RowIndex].Cells["InventoryID"].Value);

                    // Call the deletion method
                    DeleteInventoryBYIngredientID(InventoryID);
                }
            }

            if (dgvInventory.Columns[e.ColumnIndex].Name == "ColEdit")
            {
                DataGridViewRow row = dgvInventory.Rows[e.RowIndex];
                string quantity = row.Cells["ColQuantity"]?.Value?.ToString() ?? "";
                string unit = row.Cells["ColUnit"]?.Value?.ToString() ?? "";
                string expiryText = row.Cells["colExpireDate"]?.Value?.ToString();
                DateTime.TryParse(expiryText, out DateTime parsedDate);

                EditInventoryForm editInventoryForm = new EditInventoryForm
                {
                    Quantity = quantity,
                    Unit = unit,
                    ExpiryDate = parsedDate == default ? DateTime.Today : parsedDate
                };

                if (editInventoryForm.ShowDialog() == DialogResult.OK)
                {
                    string query = @"
                        UPDATE Inventory
                        SET Quantity = @Quantity , Unit = @Unit , ExpiryDate = @ExpiryDate 
                        Where InventoryID = @InventoryID";
                    
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Quantity",editInventoryForm.Quantity),
                        new SqlParameter("@Unit",editInventoryForm.Unit),
                        new SqlParameter("@ExpiryDate",editInventoryForm.ExpiryDate),
                        new SqlParameter("@InventoryID", Convert.ToInt32(dgvInventory.Rows[e.RowIndex].Cells["InventoryID"].Value))
                    };

                    DatabaseHelper.ExecuteNonQuery(query, parameters);

                    LoadInventoryData();
                }
            }
        }

          private void dgvInventory_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                using (Pen pen = new Pen(Color.LightGray, 1))
                {
                    int y = e.CellBounds.Bottom - 1;
                    e.Graphics.DrawLine(pen, e.CellBounds.Left, y, e.CellBounds.Right, y);
                }

                e.Handled = true;
            }
        }

        private void dgvInventory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Status color formatting
            if (dgvInventory.Columns[e.ColumnIndex].Name == "colStatus")
            {
                string status = e.Value?.ToString();
                if (status == "OK")
                {
                    e.CellStyle.ForeColor = Color.Green;
                   
                }
                else if (status == "Low")
                {
                    e.CellStyle.ForeColor = Color.Gold;
                   
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

    }

}
