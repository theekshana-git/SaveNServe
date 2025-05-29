using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveNServe
{
    public partial class EditIngredientForm: Form
    {
        public EditIngredientForm()
        {
            InitializeComponent();
        }

        public string Name { get; set; }

        

        public string Available { get; set; }


        private void EditIngredientForm_Load(object sender, EventArgs e)
        {
            Name_Textbox.Text = Name;
           
            
            if(Available == "Avaliable") 
            {
                Available_chk.Checked = true;
            } else if(Available == "Out of Stock")
            {
                OutOfStock_chk.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var lbl in new[] { lblNameError, lblAvailbilityError})
            {
                lbl.Visible = false;
            }

            string name = Name_Textbox.Text.Trim();
            
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

            bool ErrorCheck = false;

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

            if(ErrorCheck)
            {
                return;
            }

            this.Name = name;
            
            this.Available = Available;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Available_chk_CheckedChanged(object sender, EventArgs e)
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
    }
}
