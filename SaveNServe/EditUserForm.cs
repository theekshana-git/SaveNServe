using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaveNServe
{
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();
        }

        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Username;
            txtEmail.Text = Email;
            cmbRole.SelectedItem = Role;
            cmbStatus.SelectedItem = Status;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Username = txtUsername.Text.Trim();
            Email = txtEmail.Text.Trim();
            Role = cmbRole.SelectedItem?.ToString();
            Status = cmbStatus.SelectedItem?.ToString();

            // Optional: Add validation here
            // Hide all error labels initially
            lblUnError.Visible = false;
            lblEmailError.Visible = false;
            lblRoleError.Visible = false;
            lblStatusError.Visible = false;



            bool hasError = false;

            // Validation checks
            if (string.IsNullOrEmpty(Username))
            {
                lblUnError.Text = "Username is required";
                lblUnError.Visible = true;
                txtUsername.Focus();
                hasError = true;
            }

            if (string.IsNullOrEmpty(Email) || !IsValidEmail(Email))
            {
                lblEmailError.Text = "Enter a valid email address";
                lblEmailError.Visible = true;
                if (!hasError) txtEmail.Focus();
                hasError = true;
            }

            if (string.IsNullOrEmpty(Role))
            {
                lblRoleError.Text = "Please select a role";
                lblRoleError.Visible = true;
                if (!hasError) cmbRole.Focus();
                hasError = true;
            }

            if (string.IsNullOrEmpty(Status))
            {
                lblStatusError.Text = "Please select a status";
                lblStatusError.Visible = true;
                if (!hasError) cmbStatus.Focus();
                hasError = true;
            }

            if (hasError) return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }

}
