using System;
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
            dgvIngredients.Columns["ColName"].Width = 250;        // Roomy for ingredient names
            dgvIngredients.Columns["ColAvailable"].Width = 170;   // To fit "Available"/"Out of Stock"
            dgvIngredients.Columns["ColEdit"].Width = 60;         // Compact for Edit link
            dgvIngredients.Columns["ColActions"].Width = 70;      // Compact for Delete link

            searchBox.Enter += SearchBox_Enter;
            searchBox.Leave += SearchBox_Leave;
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

            if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                lblNameError.Text = "Please enter letters only (a-z , A-Z)";
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

            // Add to data grid view table
            dgvIngredients.Rows.Add(name, Available);

            MessageBox.Show("Ingredient added successfully!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clears the form
            Clearbtn_Click(sender, e);
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




        private void dgvIngredients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //skip header row
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvIngredients.Columns[e.ColumnIndex].Name == "ColActions")
            {
                DialogResult result = MessageBox.Show(
                   "Are you sure you want to delete this ingredient?",
                   "Confirm Deletion",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    dgvIngredients.Rows.RemoveAt(e.RowIndex);
                }
            }

            if (dgvIngredients.Columns[e.ColumnIndex].Name == "ColEdit")
            {
                DataGridViewRow row = dgvIngredients.Rows[e.RowIndex];

                EditIngredientForm editIngForm = new EditIngredientForm
                {
                    Name = row.Cells["ColName"].Value.ToString(),
                   
                    Available = row.Cells["ColAvailable"].Value.ToString()
                };

                if (editIngForm.ShowDialog() == DialogResult.OK)
                {
                    row.Cells["ColName"].Value = editIngForm.Name;
                    
                    row.Cells["ColAvailable"].Value = editIngForm.Available;
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
