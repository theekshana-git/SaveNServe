namespace SaveNServe
{
    partial class EditSubstitutionForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblError2 = new System.Windows.Forms.Label();
            this.txtSubstitute = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panelUn = new System.Windows.Forms.Panel();
            this.lblError1 = new System.Windows.Forms.Label();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.lblUn = new System.Windows.Forms.Label();
            this.lblEditUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panelUn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(34, 386);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(243, 35);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblError2);
            this.panel3.Controls.Add(this.txtSubstitute);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Location = new System.Drawing.Point(17, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 86);
            this.panel3.TabIndex = 17;
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblError2.ForeColor = System.Drawing.Color.Red;
            this.lblError2.Location = new System.Drawing.Point(13, 69);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(164, 15);
            this.lblError2.TabIndex = 7;
            this.lblError2.Text = "Invalid username or password";
            this.lblError2.Visible = false;
            // 
            // txtSubstitute
            // 
            this.txtSubstitute.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubstitute.Location = new System.Drawing.Point(16, 41);
            this.txtSubstitute.Name = "txtSubstitute";
            this.txtSubstitute.Size = new System.Drawing.Size(243, 27);
            this.txtSubstitute.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 13);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Substitute";
            // 
            // panelUn
            // 
            this.panelUn.Controls.Add(this.lblError1);
            this.panelUn.Controls.Add(this.txtIngredient);
            this.panelUn.Controls.Add(this.lblUn);
            this.panelUn.Location = new System.Drawing.Point(17, 82);
            this.panelUn.Name = "panelUn";
            this.panelUn.Size = new System.Drawing.Size(277, 86);
            this.panelUn.TabIndex = 16;
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblError1.ForeColor = System.Drawing.Color.Red;
            this.lblError1.Location = new System.Drawing.Point(13, 68);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(164, 15);
            this.lblError1.TabIndex = 6;
            this.lblError1.Text = "Invalid username or password";
            this.lblError1.Visible = false;
            // 
            // txtIngredient
            // 
            this.txtIngredient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredient.Location = new System.Drawing.Point(16, 40);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(243, 27);
            this.txtIngredient.TabIndex = 1;
            // 
            // lblUn
            // 
            this.lblUn.AutoSize = true;
            this.lblUn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUn.Location = new System.Drawing.Point(13, 11);
            this.lblUn.Name = "lblUn";
            this.lblUn.Size = new System.Drawing.Size(77, 20);
            this.lblUn.TabIndex = 0;
            this.lblUn.Text = "Ingredient";
            // 
            // lblEditUser
            // 
            this.lblEditUser.AutoSize = true;
            this.lblEditUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditUser.Location = new System.Drawing.Point(12, 23);
            this.lblEditUser.Name = "lblEditUser";
            this.lblEditUser.Size = new System.Drawing.Size(179, 30);
            this.lblEditUser.TabIndex = 15;
            this.lblEditUser.Text = "Edit Substitution";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtScore);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 86);
            this.panel1.TabIndex = 18;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(16, 41);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(243, 27);
            this.txtScore.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Similarity Score";
            // 
            // EditSubstitutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelUn);
            this.Controls.Add(this.lblEditUser);
            this.Name = "EditSubstitutionForm";
            this.Text = "EditSubstitutionForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelUn.ResumeLayout(false);
            this.panelUn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblError2;
        private System.Windows.Forms.TextBox txtSubstitute;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panelUn;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.Label lblUn;
        private System.Windows.Forms.Label lblEditUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label2;
    }
}