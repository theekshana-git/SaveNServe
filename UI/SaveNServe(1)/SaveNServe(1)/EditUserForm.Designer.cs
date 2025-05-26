namespace SaveNServe_1_
{
    partial class EditUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblStatusError = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblRoleError = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panelUn = new System.Windows.Forms.Panel();
            this.lblUnError = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUn = new System.Windows.Forms.Label();
            this.lblEditUser = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelUn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(37, 483);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(243, 35);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblStatusError);
            this.panel5.Controls.Add(this.cmbStatus);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(20, 360);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(277, 86);
            this.panel5.TabIndex = 13;
            // 
            // lblStatusError
            // 
            this.lblStatusError.AutoSize = true;
            this.lblStatusError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblStatusError.ForeColor = System.Drawing.Color.Red;
            this.lblStatusError.Location = new System.Drawing.Point(13, 68);
            this.lblStatusError.Name = "lblStatusError";
            this.lblStatusError.Size = new System.Drawing.Size(164, 15);
            this.lblStatusError.TabIndex = 9;
            this.lblStatusError.Text = "Invalid username or password";
            this.lblStatusError.Visible = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Active",
            "Inactive"});
            this.cmbStatus.BackColor = System.Drawing.Color.White;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(16, 40);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(243, 28);
            this.cmbStatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblRoleError);
            this.panel4.Controls.Add(this.cmbRole);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(20, 268);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 86);
            this.panel4.TabIndex = 12;
            // 
            // lblRoleError
            // 
            this.lblRoleError.AutoSize = true;
            this.lblRoleError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblRoleError.ForeColor = System.Drawing.Color.Red;
            this.lblRoleError.Location = new System.Drawing.Point(13, 69);
            this.lblRoleError.Name = "lblRoleError";
            this.lblRoleError.Size = new System.Drawing.Size(164, 15);
            this.lblRoleError.TabIndex = 8;
            this.lblRoleError.Text = "Invalid username or password";
            this.lblRoleError.Visible = false;
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.White;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cmbRole.Location = new System.Drawing.Point(16, 41);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(243, 28);
            this.cmbRole.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Role";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblEmailError);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Location = new System.Drawing.Point(20, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 86);
            this.panel3.TabIndex = 11;
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(13, 69);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(164, 15);
            this.lblEmailError.TabIndex = 7;
            this.lblEmailError.Text = "Invalid username or password";
            this.lblEmailError.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(16, 41);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 13);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // panelUn
            // 
            this.panelUn.Controls.Add(this.lblUnError);
            this.panelUn.Controls.Add(this.txtUsername);
            this.panelUn.Controls.Add(this.lblUn);
            this.panelUn.Location = new System.Drawing.Point(20, 84);
            this.panelUn.Name = "panelUn";
            this.panelUn.Size = new System.Drawing.Size(277, 86);
            this.panelUn.TabIndex = 10;
            // 
            // lblUnError
            // 
            this.lblUnError.AutoSize = true;
            this.lblUnError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblUnError.ForeColor = System.Drawing.Color.Red;
            this.lblUnError.Location = new System.Drawing.Point(13, 68);
            this.lblUnError.Name = "lblUnError";
            this.lblUnError.Size = new System.Drawing.Size(164, 15);
            this.lblUnError.TabIndex = 6;
            this.lblUnError.Text = "Invalid username or password";
            this.lblUnError.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(16, 40);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(243, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUn
            // 
            this.lblUn.AutoSize = true;
            this.lblUn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUn.Location = new System.Drawing.Point(13, 11);
            this.lblUn.Name = "lblUn";
            this.lblUn.Size = new System.Drawing.Size(75, 20);
            this.lblUn.TabIndex = 0;
            this.lblUn.Text = "Username";
            // 
            // lblEditUser
            // 
            this.lblEditUser.AutoSize = true;
            this.lblEditUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditUser.Location = new System.Drawing.Point(15, 25);
            this.lblEditUser.Name = "lblEditUser";
            this.lblEditUser.Size = new System.Drawing.Size(100, 30);
            this.lblEditUser.TabIndex = 9;
            this.lblEditUser.Text = "Edit User";
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 562);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelUn);
            this.Controls.Add(this.lblEditUser);
            this.Name = "EditUserForm";
            this.Text = "EditUserForm";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelUn.ResumeLayout(false);
            this.panelUn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblStatusError;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblRoleError;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panelUn;
        private System.Windows.Forms.Label lblUnError;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUn;
        private System.Windows.Forms.Label lblEditUser;
    }
}