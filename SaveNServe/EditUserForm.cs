using System;
using System.Windows.Forms;

namespace SaveNServe
{
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Username;
            txtPassword.Text = Password;
            cmbRole.SelectedItem = Role;
            cmbStatus.SelectedItem = Status;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Username = txtUsername.Text.Trim();
            Password = txtPassword.Text.Trim();
            Role = cmbRole.SelectedItem?.ToString();
            Status = cmbStatus.SelectedItem?.ToString();

            // Optional: Add validation here
            // Hide all error labels initially
            lblUnError.Visible = false;
            lblPasswordError.Visible = false;
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

            if (string.IsNullOrEmpty(Password) || !IsValidPassword(Password))
            {
                lblPasswordError.Text = "Enter a valid password";
                lblPasswordError.Visible = true;
                if (!hasError) txtPassword.Focus();
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


        private bool IsValidPassword(string password)
        {
            // Example: At least 8 characters, one uppercase, one number
            if (string.IsNullOrWhiteSpace(password)) return false;

            return password.Length >= 4;

        }





    }

}
