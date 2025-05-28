using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace SaveNServe
{
    public partial class EditInventoryForm: Form
    {
        public EditInventoryForm()
        {
            InitializeComponent();
        }

        public string Name { get; set; }

        public string Quantity { get; set; }

        public string Unit { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string Status { get;  set; }

        private void EditInventory_Load(object sender, EventArgs e)
        {
            Name_txtbox.Text = Name;
            Quantity_txtbox.Text = Quantity;
            cmbUnit.SelectedItem = Unit;
            ExpiryDatePicker.Value = Convert.ToDateTime(ExpiryDate);
            cmbStatus.SelectedItem = Status;
        }

        private void btnEditInventory_Click(object sender, EventArgs e)
        {
            Name = Name_txtbox.Text.Trim();
            Quantity = Quantity_txtbox.Text.Trim();
            Unit = cmbUnit.SelectedItem?.ToString();
            ExpiryDate = ExpiryDatePicker.Value;
            Status = cmbStatus.SelectedItem?.ToString();

            //Hides all error lables
            foreach (var lbl in new[] { lblNameError, lblQuantityError, lblUnitError, lblDateError, lblStatusError })
            {
                lbl.Visible = false;
            }

            bool ErrorCheck = false;

            //Validation Checks
            if (string.IsNullOrEmpty(Name))
            {
                lblNameError.Text = "Name is required";
                lblNameError.Visible = true;
                Name_txtbox.Focus();
                ErrorCheck = true;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(Name, @"^[a-zA-Z]+$"))
            {
                lblNameError.Text = "Please enter letters only (a-z , A-Z)";
                lblNameError.Visible = true;
                Name_txtbox.Focus();
                ErrorCheck = true;
            }


            if ((string.IsNullOrEmpty(Quantity) || !decimal.TryParse(Quantity, out decimal costInput) || costInput < 0))
            {
                lblQuantityError.Text = "Enter a Valid Number";
                lblQuantityError.Visible = true;
                Quantity_txtbox.Focus();
                ErrorCheck = true;
            }

            if (string.IsNullOrEmpty(Unit))
            {
                lblUnitError.Text = "Please select a unit";
                lblUnitError.Visible = true;
                cmbUnit.Focus();
                ErrorCheck = true;
            }

            //Date time validation
            if (ExpiryDatePicker.Value.Date == DateTime.Today)
            {
                lblDateError.Text = "Please select a date before continuing";
                lblDateError.Visible = true;
                ExpiryDatePicker.Focus();
                ErrorCheck = true;
            }


            if (string.IsNullOrEmpty(Status))
            {
                lblStatusError.Text = "Please select a status";
                lblStatusError.Visible = true;
                cmbStatus.Focus();
                ErrorCheck = true;
            }

            if (ErrorCheck)
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
    }
}
