using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SaveNServe
{
    public partial class EditIngredientForm : Form
    {
        public EditIngredientForm()
        {
            InitializeComponent();
        }

        public int IngredientID { get; set; }
        public string Name { get; set; }
        public string Available { get; set; }
        public string NutritionalInfo { get; set; }
        public string Taste { get; set; }
        public string Texture { get; set; }

        private void EditIngredientForm_Load(object sender, EventArgs e)
        {
            Name_Textbox.Text = Name;

            if (Available == "Available")
            {
                Available_chk.Checked = true;
            }
            else if (Available == "Out of Stock")
            {
                OutOfStock_chk.Checked = true;

            }

            cmbNutInfo.SelectedItem = NutritionalInfo;
            cmbTaste.SelectedItem = Taste;
            cmbTexture.SelectedItem = Texture;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Hide all error labels
            lblNameError.Visible = false;
            lblAvailbilityError.Visible = false;
            lbl_NIfnoError.Visible = false;
            lblTaste.Visible = false;
            lblTextureError.Visible = false;

            string inputName = Name_Textbox.Text.Trim();
            string selectedAvailability = "";

            if (Available_chk.Checked)
                selectedAvailability = "Available";
            else if (OutOfStock_chk.Checked)
                selectedAvailability = "Out of Stock";

            bool hasError = false;

          
            //validation Checks
            if (string.IsNullOrEmpty(inputName))
            {
                lblNameError.Text = "Name is required.";
                lblNameError.Visible = true;
                Name_Textbox.Focus();
                hasError = true;
            }
           
            if (string.IsNullOrEmpty(selectedAvailability))
            {
                lblAvailbilityError.Text = "Please select availability status.";
                lblAvailbilityError.Visible = true;
                hasError = true;
            }

            if (cmbNutInfo.SelectedItem == null)
            {
                lbl_NIfnoError.Text = "Please select nutritional info.";
                lbl_NIfnoError.Visible = true;
                hasError = true;
            }

            if (cmbTaste.SelectedItem == null)
            {
                lbl_TasteError.Text = "Please select taste.";
                lbl_TasteError.Visible = true;
                hasError = true;
            }

            if (cmbTexture.SelectedItem == null)
            {
                lblTextureError.Text = "Please select texture.";
                lblTextureError.Visible = true;
                hasError = true;
            }

            if (hasError)
                return;

            // Set properties to updated values
            Name = inputName;
            Available = selectedAvailability;
            NutritionalInfo = cmbNutInfo.SelectedItem.ToString();
            Taste = cmbTaste.SelectedItem.ToString();
            Texture = cmbTexture.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Available_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (Available_chk.Checked)
                OutOfStock_chk.Checked = false;
        }

        private void OutOfStock_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (OutOfStock_chk.Checked)
                Available_chk.Checked = false;
        }
    }
}
