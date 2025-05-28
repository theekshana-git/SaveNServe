using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveNServe
{
    public partial class ManageUsers: UserControl
    {
        public ManageUsers()
        {
          
            
            InitializeComponent();
            searchBox.Enter += SearchBox_Enter;
            searchBox.Leave += SearchBox_Leave;
            btnAddUser.Click += btnAddUser_Click;
            dgvUsers.CellPainting += dgvUsers_CellPainting;
            dgvUsers.CellFormatting += dgvUsers_CellFormatting;
            
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;

            
            dgvUsers.Columns["colEdit"].Width = 60;
            dgvUsers.Columns["colActions"].Width = 60;


        }



        
        

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search Users")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                searchBox.Text = "Search Users";
                searchBox.ForeColor = Color.DimGray;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Hide all error labels initially
            lblUnError.Visible = false;
            lblEmailError.Visible = false;
            lblRoleError.Visible = false;
            lblStatusError.Visible = false;

            // Get input values
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();
            string status = cmbStatus.SelectedItem?.ToString();

            bool hasError = false;

            // Validation checks
            if (string.IsNullOrEmpty(username))
            {
                lblUnError.Text = "Username is required";
                lblUnError.Visible = true;
                txtUsername.Focus();
                hasError = true;
            }

            if (string.IsNullOrEmpty(email) || !IsValidEmail(email))
            {
                lblEmailError.Text = "Enter a valid email address";
                lblEmailError.Visible = true;
                if (!hasError) txtEmail.Focus();
                hasError = true;
            }

            if (string.IsNullOrEmpty(role))
            {
                lblRoleError.Text = "Please select a role";
                lblRoleError.Visible = true;
                if (!hasError) cmbRole.Focus();
                hasError = true;
            }

            if (string.IsNullOrEmpty(status))
            {
                lblStatusError.Text = "Please select a status";
                lblStatusError.Visible = true;
                if (!hasError) cmbStatus.Focus();
                hasError = true;
            }

            if (hasError) return;

            // Add to DataGridView
            dgvUsers.Rows.Add(username, email, role, status);

            // Optional: clear input fields
            txtUsername.Clear();
            txtEmail.Clear();
            cmbRole.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            // If passed, proceed to add the user (to database or UI table)
            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvUsers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Status color formatting
            if (dgvUsers.Columns[e.ColumnIndex].Name == "colStatus")
            {
                string status = e.Value?.ToString();
                if (status == "Active")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    //e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
                else if (status == "Inactive")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    //e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
            }

            

        }


       

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Skip header row clicks
            if (e.RowIndex < 0)
                return;

            // Check if it's the "Delete" column
            if (dgvUsers.Columns[e.ColumnIndex].Name == "colActions") // use your actual column name
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
                    dgvUsers.Rows.RemoveAt(e.RowIndex); // Delete the row
                }
            }

            if (dgvUsers.Columns[e.ColumnIndex].Name == "colEdit")
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                EditUserForm editForm = new EditUserForm
                {
                    Username = row.Cells["colUsername"].Value.ToString(),
                    Email = row.Cells["colEmail"].Value.ToString(),
                    Role = row.Cells["colRole"].Value.ToString(),
                    Status = row.Cells["colStatus"].Value.ToString()
                };

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the DataGridView with new values
                    row.Cells["colUsername"].Value = editForm.Username;
                    row.Cells["colEmail"].Value = editForm.Email;
                    row.Cells["colRole"].Value = editForm.Role;
                    row.Cells["colStatus"].Value = editForm.Status;

                    // Optional: change cell colors based on status again
                }
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtEmail.Clear();
            cmbRole.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }
    }
}
