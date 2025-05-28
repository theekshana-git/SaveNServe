namespace SaveNServe
{
    partial class EditInventoryForm
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
            this.lblEditInventory = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.ExpiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnEditInventory = new System.Windows.Forms.Button();
            this.lblStatusError = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDateError = new System.Windows.Forms.Label();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.lblUnitError = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblQuantityError = new System.Windows.Forms.Label();
            this.Quantity_txtbox = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.Name_txtbox = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEditInventory
            // 
            this.lblEditInventory.AutoSize = true;
            this.lblEditInventory.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditInventory.ForeColor = System.Drawing.Color.Black;
            this.lblEditInventory.Location = new System.Drawing.Point(12, 18);
            this.lblEditInventory.Name = "lblEditInventory";
            this.lblEditInventory.Size = new System.Drawing.Size(153, 30);
            this.lblEditInventory.TabIndex = 22;
            this.lblEditInventory.Text = "Edit Inventory";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.White;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Ok",
            "Low",
            "Expired"});
            this.cmbStatus.Location = new System.Drawing.Point(27, 466);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(237, 28);
            this.cmbStatus.TabIndex = 69;
            // 
            // cmbUnit
            // 
            this.cmbUnit.BackColor = System.Drawing.Color.White;
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "L",
            "Kg",
            "Pcs"});
            this.cmbUnit.Location = new System.Drawing.Point(27, 282);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(237, 28);
            this.cmbUnit.TabIndex = 68;
            // 
            // ExpiryDatePicker
            // 
            this.ExpiryDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDatePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDatePicker.Location = new System.Drawing.Point(27, 378);
            this.ExpiryDatePicker.Name = "ExpiryDatePicker";
            this.ExpiryDatePicker.Size = new System.Drawing.Size(237, 27);
            this.ExpiryDatePicker.TabIndex = 67;
            // 
            // btnEditInventory
            // 
            this.btnEditInventory.BackColor = System.Drawing.Color.Teal;
            this.btnEditInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInventory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInventory.ForeColor = System.Drawing.Color.White;
            this.btnEditInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditInventory.Location = new System.Drawing.Point(29, 533);
            this.btnEditInventory.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnEditInventory.Name = "btnEditInventory";
            this.btnEditInventory.Size = new System.Drawing.Size(235, 35);
            this.btnEditInventory.TabIndex = 66;
            this.btnEditInventory.Text = "EDIT INVENTORY";
            this.btnEditInventory.UseVisualStyleBackColor = false;
            this.btnEditInventory.Click += new System.EventHandler(this.btnEditInventory_Click);
            // 
            // lblStatusError
            // 
            this.lblStatusError.AutoSize = true;
            this.lblStatusError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblStatusError.ForeColor = System.Drawing.Color.Red;
            this.lblStatusError.Location = new System.Drawing.Point(29, 493);
            this.lblStatusError.Name = "lblStatusError";
            this.lblStatusError.Size = new System.Drawing.Size(164, 15);
            this.lblStatusError.TabIndex = 65;
            this.lblStatusError.Text = "Invalid username or password";
            this.lblStatusError.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(27, 435);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 20);
            this.lblStatus.TabIndex = 64;
            this.lblStatus.Text = "Status";
            // 
            // lblDateError
            // 
            this.lblDateError.AutoSize = true;
            this.lblDateError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblDateError.ForeColor = System.Drawing.Color.Red;
            this.lblDateError.Location = new System.Drawing.Point(29, 407);
            this.lblDateError.Name = "lblDateError";
            this.lblDateError.Size = new System.Drawing.Size(164, 15);
            this.lblDateError.TabIndex = 63;
            this.lblDateError.Text = "Invalid username or password";
            this.lblDateError.Visible = false;
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpireDate.Location = new System.Drawing.Point(27, 347);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(89, 20);
            this.lblExpireDate.TabIndex = 62;
            this.lblExpireDate.Text = "Expire Date";
            // 
            // lblUnitError
            // 
            this.lblUnitError.AutoSize = true;
            this.lblUnitError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblUnitError.ForeColor = System.Drawing.Color.Red;
            this.lblUnitError.Location = new System.Drawing.Point(29, 313);
            this.lblUnitError.Name = "lblUnitError";
            this.lblUnitError.Size = new System.Drawing.Size(164, 15);
            this.lblUnitError.TabIndex = 61;
            this.lblUnitError.Text = "Invalid username or password";
            this.lblUnitError.Visible = false;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(27, 253);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(39, 20);
            this.lblUnit.TabIndex = 60;
            this.lblUnit.Text = "Unit";
            // 
            // lblQuantityError
            // 
            this.lblQuantityError.AutoSize = true;
            this.lblQuantityError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblQuantityError.ForeColor = System.Drawing.Color.Red;
            this.lblQuantityError.Location = new System.Drawing.Point(27, 223);
            this.lblQuantityError.Name = "lblQuantityError";
            this.lblQuantityError.Size = new System.Drawing.Size(164, 15);
            this.lblQuantityError.TabIndex = 59;
            this.lblQuantityError.Text = "Invalid username or password";
            this.lblQuantityError.Visible = false;
            // 
            // Quantity_txtbox
            // 
            this.Quantity_txtbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_txtbox.Location = new System.Drawing.Point(27, 193);
            this.Quantity_txtbox.Name = "Quantity_txtbox";
            this.Quantity_txtbox.Size = new System.Drawing.Size(237, 27);
            this.Quantity_txtbox.TabIndex = 58;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(27, 163);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 20);
            this.lblQuantity.TabIndex = 57;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(29, 133);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(164, 15);
            this.lblNameError.TabIndex = 56;
            this.lblNameError.Text = "Invalid username or password";
            this.lblNameError.Visible = false;
            // 
            // Name_txtbox
            // 
            this.Name_txtbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_txtbox.Location = new System.Drawing.Point(27, 103);
            this.Name_txtbox.Name = "Name_txtbox";
            this.Name_txtbox.Size = new System.Drawing.Size(237, 27);
            this.Name_txtbox.TabIndex = 55;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(27, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 54;
            this.lblName.Text = "Name";
            // 
            // EditInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 599);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.ExpiryDatePicker);
            this.Controls.Add(this.btnEditInventory);
            this.Controls.Add(this.lblStatusError);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDateError);
            this.Controls.Add(this.lblExpireDate);
            this.Controls.Add(this.lblUnitError);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblQuantityError);
            this.Controls.Add(this.Quantity_txtbox);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.Name_txtbox);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEditInventory);
            this.Name = "EditInventoryForm";
            this.Text = "EditInventory";
            this.Load += new System.EventHandler(this.EditInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditInventory;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.DateTimePicker ExpiryDatePicker;
        private System.Windows.Forms.Button btnEditInventory;
        private System.Windows.Forms.Label lblStatusError;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDateError;
        private System.Windows.Forms.Label lblExpireDate;
        private System.Windows.Forms.Label lblUnitError;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblQuantityError;
        private System.Windows.Forms.TextBox Quantity_txtbox;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.TextBox Name_txtbox;
        private System.Windows.Forms.Label lblName;
    }
}