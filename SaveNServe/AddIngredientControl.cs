using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;


namespace SaveNServe
{
    public partial class AddIngredientControl: UserControl
    {
       
        public AddIngredientControl()
        {
            InitializeComponent();

            Clearbtn.Click += Clearbtn_Click;
            dgvIngredients.CellPainting += dgvIngredients_CellPainting;
            dgvIngredients.CellContentClick += dgvIngredients_CellContentClick;

        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            // Hides all error labels 
            foreach (var lbl in new[] { lblNameError, lblCostError, lblAvailbilityError, lblNinfoError, lblTasteError, lblTextureError })
            {
                lbl.Visible = false;
            }
              
            //Get user inputs
            string name = Name_Textbox.Text.Trim();
            string cost = Cost_Textbox.Text.Trim();

            // Checkbox
            string Available = "";

            if (Available_chk.Checked)
            {
                Available = "Avaliable";
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

            if(!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                lblNameError.Text = "Please enter letters only (a-z , A-Z)";
                lblNameError.Visible = true;
                Name_Textbox.Focus();
                ErrorCheck = true;
            }

            if((string.IsNullOrEmpty(cost) || !decimal.TryParse(cost, out decimal costInput) || costInput < 0))
            {
                lblCostError.Text = "Enter a Valid Number";
                lblCostError.Visible = true;
                Cost_Textbox.Focus();
                ErrorCheck = true;
            }

            if(!Available_chk.Checked && !OutOfStock_chk.Checked)
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
            dgvIngredients.Rows.Add(name, cost, Available);

            MessageBox.Show("Ingredient added successfully!", "Sucess" , MessageBoxButtons.OK , MessageBoxIcon.Information);

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
                        Cost = row.Cells["ColCost"].Value.ToString(),
                        Available = row.Cells["ColAvailable"].Value.ToString()
                    };
                    
                    if(editIngForm.ShowDialog() == DialogResult.OK)
                    {
                        row.Cells["ColName"].Value = editIngForm.Name;
                        row.Cells["ColCost"].Value = editIngForm.Cost;
                        row.Cells["ColAvailable"].Value = editIngForm.Available;
                    }
                }
            }
        

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Name_Textbox.Clear();
            Cost_Textbox.Clear();

            Available_chk.Checked = false;
            OutOfStock_chk.Checked = false;

            cmbNutInfo.SelectedIndex = -1;
            cmbTaste.SelectedIndex = -1;
            cmbTexture.SelectedIndex = -1;
        }
        private void Right_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

       

       

        private void cmbTaste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvIngredients_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
