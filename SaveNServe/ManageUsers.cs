using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SaveNServe
{
    public partial class ManageUsers : UserControl
    {



        public ManageUsers()
        {
            InitializeComponent();



            LoadUsers();










            searchBox.Enter += SearchBox_Enter;
            searchBox.Leave += SearchBox_Leave;
            btnAddUser.Click += btnAddUser_Click;
            dgvUsers.CellPainting += dgvUsers_CellPainting;
            dgvUsers.CellFormatting += dgvUsers_CellFormatting;
            searchBox.KeyDown += SearchBox_KeyDown;


            dgvUsers.CellContentClick += dgvUsers_CellContentClick;







        }








        private void LoadUsers()
        {
            string query = @"
    SELECT 
        Username, 
        Password, 
        Role, 
        Status
    FROM Users
    ORDER BY Username ASC";

            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvUsers.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    string username = row["Username"].ToString();
                    string password = row["Password"].ToString();
                    string role = row["Role"].ToString();
                    string status = row["Status"].ToString();

                    // No colActions 
                    dgvUsers.Rows.Add(username, password, role, status);
                }

                
                dgvUsers.Columns["colStatus"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvUsers.Columns["colStatus"].Width = 120;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Searching Part

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


        //Searching Logic

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchText = searchBox.Text.Trim();


                if (string.IsNullOrEmpty(searchText) || searchText == "Search Users")
                {
                    LoadUsers();
                    return;
                }

                try
                {
                    string query = @"
                SELECT Username, Password, Role, Status
                FROM Users
                WHERE 
                    Username LIKE @Search OR 
                    Password LIKE @Search OR 
                    Role LIKE @Search OR 
                    Status LIKE @Search";

                    SqlParameter param = new SqlParameter("@Search", "%" + searchText + "%");
                    DataTable dt = DatabaseHelper.ExecuteQuery(query, param);


                    // Clear existing rows if you're using manual row population
                    if (dgvUsers.DataSource == null)
                        dgvUsers.Rows.Clear();

                    // 
                    if (dgvUsers.DataSource is DataTable usersTable)
                    {
                        usersTable.Clear(); // Clear current rows
                        foreach (DataRow row in dt.Rows)
                            usersTable.ImportRow(row);
                    }
                    // 
                    else
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            dgvUsers.Rows.Add(
                                row["Username"].ToString(),
                                row["Password"].ToString(),
                                row["Role"].ToString(),
                                row["Status"].ToString()
                            );
                        }
                    }

                    if (dt == null || dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No users found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching users: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Handled = true;
                e.SuppressKeyPress = true; // Prevents the ding sound
            }
        }








        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Hide all error labels initially
            lblUnError.Visible = false;
            lblPasswordError.Visible = false;
            lblRoleError.Visible = false;
            lblStatusError.Visible = false;

            // Get input values
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
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

            if (string.IsNullOrEmpty(password) || !IsValidPassword(password))
            {
                lblPasswordError.Text = "Enter a valid password";
                lblPasswordError.Visible = true;
                if (!hasError) txtPassword.Focus();
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





            string query = @"
        INSERT INTO Users
        (Username, Password, Role, Status) 
        VALUES (@Username, @Password, @Role, @Status)";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Username", username),
        new SqlParameter("@Password", password),
        new SqlParameter("@Role", role),
        new SqlParameter("@Status",status),

        };









            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                dgvUsers.Rows.Add(username, password, role, status);
                txtUsername.Clear();
                txtPassword.Clear();
                cmbRole.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;

                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add user to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private bool IsValidPassword(string password)
        {
            
            if (string.IsNullOrWhiteSpace(password)) return false;

            return password.Length >= 4;
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvUsers.Columns[e.ColumnIndex].Name == "colEdit")
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                string oldUsername = row.Cells["colUsername"].Value.ToString();

                EditUserForm editForm = new EditUserForm
                {
                    Username = oldUsername,
                    Password = row.Cells["colPassword"].Value.ToString(),
                    Role = row.Cells["colRole"].Value.ToString(),
                    Status = row.Cells["colStatus"].Value.ToString()
                };

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        SqlTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            string newUsername = editForm.Username.Trim();

                            // If username has changed and new one already exists, stop
                            if (!string.Equals(oldUsername, newUsername, StringComparison.OrdinalIgnoreCase))
                            {
                                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @NewUsername";
                                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn, transaction))
                                {
                                    checkCmd.Parameters.AddWithValue("@NewUsername", newUsername);
                                    int exists = (int)checkCmd.ExecuteScalar();
                                    if (exists > 0)
                                    {
                                        MessageBox.Show("Username already exists. Please choose another one.", "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        transaction.Rollback();
                                        return;
                                    }
                                }
                            }

                            

                            string updateUsersQuery = @"
                        UPDATE Users
                        SET Username = @NewUsername, Password = @Password, Role = @Role, Status = @Status
                        WHERE Username = @OldUsername";

                            using (SqlCommand cmdUsers = new SqlCommand(updateUsersQuery, conn, transaction))
                            {
                                cmdUsers.Parameters.AddWithValue("@NewUsername", newUsername);
                                cmdUsers.Parameters.AddWithValue("@OldUsername", oldUsername);
                                cmdUsers.Parameters.AddWithValue("@Password", editForm.Password.Trim());
                                cmdUsers.Parameters.AddWithValue("@Role", editForm.Role.Trim());
                                cmdUsers.Parameters.AddWithValue("@Status", editForm.Status.Trim());
                                cmdUsers.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error updating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                    LoadUsers();
                }
            }
        }





        private void Clearbtn_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }








    }
}
