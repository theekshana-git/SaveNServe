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

            if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                lblNameError.Text = "Please enter letters only (a-z , A-Z)";
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


            dgvInventory.Rows.Add(name, quantity, unit, expirydate.ToShortDateString());

            // If passed
            MessageBox.Show("Inventory added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            searchBox.TextChanged += searchbox_TextChanged;

            //To set date as today 
            ExpiryDatePicker.Value = DateTime.Today;
        }

        

        
        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            string filterText = searchBox.Text.ToLower();

            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                if (row.IsNewRow) continue;

                string ingredient = row.Cells["ColName"].Value?.ToString().ToLower() ?? "";

                row.Visible = ingredient.Contains(filterText);
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
                    "Are you sure you want to delete this user?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    dgvInventory.Rows.RemoveAt(e.RowIndex); // Delete the row
                }
            }

            if (dgvInventory.Columns[e.ColumnIndex].Name == "ColEdit")
            {
                DataGridViewRow row = dgvInventory.Rows[e.RowIndex];

                EditInventoryForm editForm = new EditInventoryForm
                {
                    Name = row.Cells["ColName"].Value.ToString(),
                    Quantity = row.Cells["ColQuantity"].Value.ToString(),
                    Unit = row.Cells["ColUnit"].Value.ToString(),
                    ExpiryDate = DateTime.TryParse(row.Cells["colExpireDate"].Value?.ToString(), out DateTime parsedDate)
                     ? parsedDate
                     : DateTime.Today,
                    Status = row.Cells["colStatus"].Value.ToString()
                };

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the DataGridView with new values
                    row.Cells["ColName"].Value = editForm.Name;
                    row.Cells["ColQuantity"].Value = editForm.Quantity;
                    row.Cells["ColUnit"].Value = editForm.Unit;
                    row.Cells["colExpireDate"].Value = editForm.ExpiryDate.ToShortDateString();
                    row.Cells["colStatus"].Value = editForm.Status;

                    // Optional: change cell colors based on status again
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
