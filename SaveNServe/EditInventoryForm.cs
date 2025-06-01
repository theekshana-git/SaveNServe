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
using System.Data.SqlClient;

namespace SaveNServe
{
    public partial class EditInventoryForm: Form
    {
        public EditInventoryForm()
        {
            InitializeComponent();
        }

        public string Quantity { get; set; }

        public string Unit { get; set; }

        public DateTime ExpiryDate { get; set; }

        



        private void EditInventory_Load(object sender, EventArgs e)
        {
            Quantity_txtbox.Text = Quantity;
            cmbUnit.SelectedItem = Unit;
            ExpiryDatePicker.Value = Convert.ToDateTime(ExpiryDate);

        }

        private void btnEditInventory_Click(object sender, EventArgs e)
        {
            Quantity = Quantity_txtbox.Text.Trim();
            Unit = cmbUnit.SelectedItem?.ToString();
            ExpiryDate = ExpiryDatePicker.Value;

            //Hides all error lables
            foreach (var lbl in new[] {lblQuantityError, lblUnitError, lblDateError })
            {
                lbl.Visible = false;
            }

            bool ErrorCheck = false;

            //Validation Checks
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

            if (ErrorCheck)
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lblEditInventory_Click(object sender, EventArgs e)
        {

        }
    }
}
