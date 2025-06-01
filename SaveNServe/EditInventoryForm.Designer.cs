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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInventoryForm));
            this.lblEditInventory = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.ExpiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnEditInventory = new System.Windows.Forms.Button();
            this.lblDateError = new System.Windows.Forms.Label();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.lblUnitError = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblQuantityError = new System.Windows.Forms.Label();
            this.Quantity_txtbox = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
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
            this.cmbUnit.Location = new System.Drawing.Point(27, 181);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(243, 28);
            this.cmbUnit.TabIndex = 68;
            // 
            // ExpiryDatePicker
            // 
            this.ExpiryDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDatePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDatePicker.Location = new System.Drawing.Point(27, 271);
            this.ExpiryDatePicker.Name = "ExpiryDatePicker";
            this.ExpiryDatePicker.Size = new System.Drawing.Size(243, 27);
            this.ExpiryDatePicker.TabIndex = 67;
            // 
            // btnEditInventory
            // 
            this.btnEditInventory.BackColor = System.Drawing.Color.Teal;
            this.btnEditInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInventory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInventory.ForeColor = System.Drawing.Color.White;
            this.btnEditInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditInventory.Location = new System.Drawing.Point(32, 331);
            this.btnEditInventory.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnEditInventory.Name = "btnEditInventory";
            this.btnEditInventory.Size = new System.Drawing.Size(235, 35);
            this.btnEditInventory.TabIndex = 66;
            this.btnEditInventory.Text = "EDIT INVENTORY";
            this.btnEditInventory.UseVisualStyleBackColor = false;
            this.btnEditInventory.Click += new System.EventHandler(this.btnEditInventory_Click);
            // 
            // lblDateError
            // 
            this.lblDateError.AutoSize = true;
            this.lblDateError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblDateError.ForeColor = System.Drawing.Color.Red;
            this.lblDateError.Location = new System.Drawing.Point(29, 301);
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
            this.lblExpireDate.Location = new System.Drawing.Point(27, 241);
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
            this.lblUnitError.Location = new System.Drawing.Point(29, 211);
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
            this.lblUnit.Location = new System.Drawing.Point(27, 151);
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
            this.lblQuantityError.Location = new System.Drawing.Point(27, 121);
            this.lblQuantityError.Name = "lblQuantityError";
            this.lblQuantityError.Size = new System.Drawing.Size(164, 15);
            this.lblQuantityError.TabIndex = 59;
            this.lblQuantityError.Text = "Invalid username or password";
            this.lblQuantityError.Visible = false;
            // 
            // Quantity_txtbox
            // 
            this.Quantity_txtbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_txtbox.Location = new System.Drawing.Point(27, 91);
            this.Quantity_txtbox.Name = "Quantity_txtbox";
            this.Quantity_txtbox.Size = new System.Drawing.Size(243, 27);
            this.Quantity_txtbox.TabIndex = 58;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(27, 61);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 20);
            this.lblQuantity.TabIndex = 57;
            this.lblQuantity.Text = "Quantity";
            // 
            // EditInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 392);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.ExpiryDatePicker);
            this.Controls.Add(this.btnEditInventory);
            this.Controls.Add(this.lblDateError);
            this.Controls.Add(this.lblExpireDate);
            this.Controls.Add(this.lblUnitError);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblQuantityError);
            this.Controls.Add(this.Quantity_txtbox);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblEditInventory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditInventoryForm";
            this.Text = "EditInventory";
            this.Load += new System.EventHandler(this.EditInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditInventory;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.DateTimePicker ExpiryDatePicker;
        private System.Windows.Forms.Button btnEditInventory;
        private System.Windows.Forms.Label lblDateError;
        private System.Windows.Forms.Label lblExpireDate;
        private System.Windows.Forms.Label lblUnitError;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblQuantityError;
        private System.Windows.Forms.TextBox Quantity_txtbox;
        private System.Windows.Forms.Label lblQuantity;
    }
}