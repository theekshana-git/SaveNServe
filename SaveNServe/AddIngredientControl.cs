using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace SaveNServe
{
    public partial class AddIngredientControl : UserControl
    {

        public AddIngredientControl()
        {
            InitializeComponent();

            Clearbtn.Click += Clearbtn_Click;
            dgvIngredients.CellPainting += dgvIngredients_CellPainting;
            dgvIngredients.CellContentClick += dgvIngredients_CellContentClick;
            dgvIngredients.CellFormatting += dgvIngredients_CellFormatting;
            dgvIngredients.Columns["ColName"].Width = 250;        // Room for ingredient names
            dgvIngredients.Columns["ColAvailable"].Width = 170;   // To fit "Available"/"Out of Stock"
            dgvIngredients.Columns["ColEdit"].Width = 120;         // Compact for Edit link


            searchBox.Enter += SearchBox_Enter;
            searchBox.Leave += SearchBox_Leave;
            searchBox.KeyDown += SearchBox_KeyDown;
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            // Hides all error labels 
            foreach (var lbl in new[] { lblNameError, lblAvailbilityError, lblNinfoError, lblTasteError, lblTextureError })
            {
                lbl.Visible = false;
            }

            //Get user inputs
            string name = Name_Textbox.Text.Trim();


            // Checkbox
            string Available = "";

            if (Available_chk.Checked)
            {
                Available = "Available";
            }
            else if (OutOfStock_chk.Checked)
            {
                Available = "Out of Stock";
            }
            else
            {
                Available = "Not Specified";
            }

            string Ninfo = cmbNutInfo.SelectedItem?.ToString();
            string Taste = cmbTaste.SelectedItem?.ToString();
            string Texture = cmbTexture.SelectedItem?.ToString();

            bool ErrorCheck = false;

            // Validation checks
            if (string.IsNullOrEmpty(name))
            {
                lblNameError.Text = "Name is Required";
                lblNameError.Visible = true;
                Name_Textbox.Focus();
                ErrorCheck = true;
            }

            if (!Available_chk.Checked && !OutOfStock_chk.Checked)
            {
                lblAvailbilityError.Text = "Please select the availability status";
                lblAvailbilityError.Visible = true;
                lblAvailbilityError.Focus();
                ErrorCheck = true;
            }

            if (string.IsNullOrEmpty(Ninfo))
            {
                lblNinfoError.Text = "Please select a nutritional information category";
                lblNinfoError.Visible = true;
                cmbNutInfo.Focus();
                ErrorCheck = true;
            }

            if (string.IsNullOrEmpty(Taste))
            {
                lblTasteError.Text = "Please select a taste category";
                lblTasteError.Visible = true;
                cmbTaste.Focus();
                ErrorCheck = true;
            }

            if (string.IsNullOrEmpty(Texture))
            {
                lblTextureError.Text = "Please select a texture category";
                lblTextureError.Visible = true;
                cmbTexture.Focus();
                ErrorCheck = true;
            }

            if (ErrorCheck) return;

            // Check for duplicate ingredient name
            foreach (DataGridViewRow row in dgvIngredients.Rows)
            {
                if (row.Cells[0].Value?.ToString().Equals(name, StringComparison.OrdinalIgnoreCase) == true)
                {
                    MessageBox.Show("This ingredient already exists in the list.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }



            MessageBox.Show("Ingredient added successfully!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Calls the InsertIngredientData function
            InsertIngredientData(name, Available, Ninfo, Taste, Texture);

            // Clears the form
            Clearbtn_Click(sender, e);
        }

        private void AddIngredientControl_Load(object sender, EventArgs e)
        {
            ColName.DataPropertyName = "Name";
            ColAvailable.DataPropertyName = "Availability";




            LoadAddIngredientData();

        }

        private void LoadAddIngredientData()
        {
            string query = @"
                SELECT
                    i.IngredientID,
                    i.Name,
                    i.Availability
                FROM
                    Ingredients i
               ORDER BY
                    i.IngredientID DESC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvIngredients.DataSource = dt;

            // Hides the IngredientID column
            if (dgvIngredients.Columns.Contains("IngredientID"))
            {
                dgvIngredients.Columns["IngredientID"].Visible = false;

            }

        }

        private void InsertIngredientData(string name, string availability, string nutritionalInfo, string taste, string texture)
        {
            string Insertquery = @"
                INSERT INTO Ingredients (Name, Availability, NutritionalInfo, Taste, Texture)
                VALUES (@Name, @Availability, @NutritionalInfo, @Taste, @Texture)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", name),
                new SqlParameter("@Availability", availability),
                new SqlParameter("@NutritionalInfo", nutritionalInfo),
                new SqlParameter("@Taste", taste),
                new SqlParameter("@Texture", texture)
            };

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(Insertquery, parameters);

            if (rowsAffected > 0)
            {
                LoadAddIngredientData(); // Refresh table
            }
        }

        private void Available_CheckedChanged(object sender, EventArgs e)
        {
            if (Available_chk.Checked)
            {
                OutOfStock_chk.Checked = false;
            }
        }
        private void OutOfStock_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (OutOfStock_chk.Checked)
            {
                Available_chk.Checked = false;
            }

        }

        private void dgvIngredients_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvIngredients_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 1) Make sure we’re on the correct column
            if (dgvIngredients.Columns[e.ColumnIndex].Name != "ColAvailable") return;

            // 2) Protect against null values
            var text = e.Value?.ToString().Trim();
            if (string.IsNullOrEmpty(text)) return;

            // 3) Decide the colour
            if (text.Equals("Available", StringComparison.OrdinalIgnoreCase))
            {
                e.CellStyle.ForeColor = Color.Green;

            }
            else if (text.Equals("Out of Stock", StringComparison.OrdinalIgnoreCase))
            {
                e.CellStyle.ForeColor = Color.Red;

            }

            // 4) Tell the grid we handled it
            e.FormattingApplied = true;
            Console.WriteLine($"Formatting row {e.RowIndex} col {e.ColumnIndex}: {e.Value}");

        }


        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search Ingredient")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                searchBox.Text = "Search Ingredient";
                searchBox.ForeColor = Color.DimGray;
            }
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                string SearchText = searchBox.Text.Trim();

                if (string.IsNullOrEmpty(SearchText) || SearchText == "Search Ingredient")
                {
                    // Show all
                    return;
                }

                try
                {
                    string query = @"
                        SELECT
                            i.IngredientID,
                            i.Name,
                            i.Availability
                        FROM
                            Ingredients i
                        WHERE
                            i.Name Like @Searchtext
                        ORDER BY
                            i.IngredientID DESC";

                    SqlParameter param = new SqlParameter("@SearchText", "%" + SearchText + "%");
                    DataTable result = DatabaseHelper.ExecuteQuery(query, param);

                    dgvIngredients.DataSource = result;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search failed: " + ex.Message);
                }
            }
        }

        private void dgvIngredients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //skip header row  or out of range rows
            if (e.RowIndex < 0 || e.RowIndex >= dgvIngredients.Rows.Count)
            {
                return;
            }

            if (dgvIngredients.Columns[e.ColumnIndex].Name == "ColEdit")
            {
                DataGridViewRow row = dgvIngredients.Rows[e.RowIndex];

                EditIngredientForm editIngForm = new EditIngredientForm
                {
                    IngredientID = Convert.ToInt32(row.Cells["IngredientID"].Value),
                    Name = row.Cells["ColName"].Value.ToString(),
                    Available = row.Cells["ColAvailable"].Value.ToString()
                };

                if (editIngForm.ShowDialog() == DialogResult.OK)
                {
                    string query = @"
                        UPDATE Ingredients
                        SET Name = @Name , Availability  = @Availability , NutritionalInfo = @NutritionalInfo, Taste = @Taste, Texture = @Texture
                        Where IngredientID = @IngredientID";

                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Name",editIngForm.Name),
                        new SqlParameter("@Availability",editIngForm.Available),
                        new SqlParameter("@IngredientID",editIngForm.IngredientID),
                        new SqlParameter("@NutritionalInfo",editIngForm.NutritionalInfo),
                        new SqlParameter("@Taste", editIngForm.Taste),
                        new SqlParameter("@Texture", editIngForm.Texture)

                    };

                    DatabaseHelper.ExecuteNonQuery(query, parameters);

                    //Refresh grid
                    LoadAddIngredientData();
                }
            }
        }


        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Name_Textbox.Clear();


            Available_chk.Checked = false;
            OutOfStock_chk.Checked = false;

            cmbNutInfo.SelectedIndex = -1;
            cmbTaste.SelectedIndex = -1;
            cmbTexture.SelectedIndex = -1;
        }


    }
}
