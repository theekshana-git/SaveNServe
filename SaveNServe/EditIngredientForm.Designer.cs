namespace SaveNServe
{
    partial class EditIngredientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditIngredientForm));
            this.Addlbl = new System.Windows.Forms.Label();
            this.lblAvailbilityError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.AddIngredients_lbl = new System.Windows.Forms.Label();
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.Availbility_lbl = new System.Windows.Forms.Label();
            this.OutOfStock_chk = new System.Windows.Forms.CheckBox();
            this.Available_chk = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbl_NIfnoError = new System.Windows.Forms.Label();
            this.lbl_NInfo = new System.Windows.Forms.Label();
            this.lbl_TasteError = new System.Windows.Forms.Label();
            this.lblTaste = new System.Windows.Forms.Label();
            this.lblTextureError = new System.Windows.Forms.Label();
            this.lblTexture = new System.Windows.Forms.Label();
            this.cmbNutInfo = new System.Windows.Forms.ComboBox();
            this.cmbTaste = new System.Windows.Forms.ComboBox();
            this.cmbTexture = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Addlbl
            // 
            this.Addlbl.AutoSize = true;
            this.Addlbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addlbl.ForeColor = System.Drawing.Color.Black;
            this.Addlbl.Location = new System.Drawing.Point(20, 28);
            this.Addlbl.Name = "Addlbl";
            this.Addlbl.Size = new System.Drawing.Size(160, 30);
            this.Addlbl.TabIndex = 21;
            this.Addlbl.Text = "Edit Ingredient";
            // 
            // lblAvailbilityError
            // 
            this.lblAvailbilityError.AutoSize = true;
            this.lblAvailbilityError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblAvailbilityError.ForeColor = System.Drawing.Color.Red;
            this.lblAvailbilityError.Location = new System.Drawing.Point(22, 240);
            this.lblAvailbilityError.Name = "lblAvailbilityError";
            this.lblAvailbilityError.Size = new System.Drawing.Size(164, 15);
            this.lblAvailbilityError.TabIndex = 47;
            this.lblAvailbilityError.Text = "Invalid username or password";
            this.lblAvailbilityError.Visible = false;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(22, 142);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(164, 15);
            this.lblNameError.TabIndex = 45;
            this.lblNameError.Text = "Invalid username or password";
            this.lblNameError.Visible = false;
            // 
            // AddIngredients_lbl
            // 
            this.AddIngredients_lbl.AutoSize = true;
            this.AddIngredients_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIngredients_lbl.Location = new System.Drawing.Point(21, 82);
            this.AddIngredients_lbl.Name = "AddIngredients_lbl";
            this.AddIngredients_lbl.Size = new System.Drawing.Size(60, 21);
            this.AddIngredients_lbl.TabIndex = 37;
            this.AddIngredients_lbl.Text = "Name:";
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Textbox.Location = new System.Drawing.Point(25, 115);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(280, 24);
            this.Name_Textbox.TabIndex = 38;
            // 
            // Availbility_lbl
            // 
            this.Availbility_lbl.AutoSize = true;
            this.Availbility_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Availbility_lbl.Location = new System.Drawing.Point(21, 179);
            this.Availbility_lbl.Name = "Availbility_lbl";
            this.Availbility_lbl.Size = new System.Drawing.Size(93, 21);
            this.Availbility_lbl.TabIndex = 43;
            this.Availbility_lbl.Text = "Availbility:";
            // 
            // OutOfStock_chk
            // 
            this.OutOfStock_chk.AutoSize = true;
            this.OutOfStock_chk.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutOfStock_chk.Location = new System.Drawing.Point(138, 213);
            this.OutOfStock_chk.Name = "OutOfStock_chk";
            this.OutOfStock_chk.Size = new System.Drawing.Size(112, 24);
            this.OutOfStock_chk.TabIndex = 42;
            this.OutOfStock_chk.Text = "Out Of Stock";
            this.OutOfStock_chk.UseVisualStyleBackColor = true;
            this.OutOfStock_chk.CheckedChanged += new System.EventHandler(this.OutOfStock_chk_CheckedChanged);
            // 
            // Available_chk
            // 
            this.Available_chk.AutoSize = true;
            this.Available_chk.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available_chk.Location = new System.Drawing.Point(24, 213);
            this.Available_chk.Name = "Available_chk";
            this.Available_chk.Size = new System.Drawing.Size(90, 24);
            this.Available_chk.TabIndex = 41;
            this.Available_chk.Text = "Available";
            this.Available_chk.UseVisualStyleBackColor = true;
            this.Available_chk.CheckedChanged += new System.EventHandler(this.Available_chk_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(24, 562);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbl_NIfnoError
            // 
            this.lbl_NIfnoError.AutoSize = true;
            this.lbl_NIfnoError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lbl_NIfnoError.ForeColor = System.Drawing.Color.Red;
            this.lbl_NIfnoError.Location = new System.Drawing.Point(22, 334);
            this.lbl_NIfnoError.Name = "lbl_NIfnoError";
            this.lbl_NIfnoError.Size = new System.Drawing.Size(164, 15);
            this.lbl_NIfnoError.TabIndex = 52;
            this.lbl_NIfnoError.Text = "Invalid username or password";
            this.lbl_NIfnoError.Visible = false;
            // 
            // lbl_NInfo
            // 
            this.lbl_NInfo.AutoSize = true;
            this.lbl_NInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NInfo.Location = new System.Drawing.Point(21, 273);
            this.lbl_NInfo.Name = "lbl_NInfo";
            this.lbl_NInfo.Size = new System.Drawing.Size(130, 21);
            this.lbl_NInfo.TabIndex = 51;
            this.lbl_NInfo.Text = "Nutritional Info";
            // 
            // lbl_TasteError
            // 
            this.lbl_TasteError.AutoSize = true;
            this.lbl_TasteError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lbl_TasteError.ForeColor = System.Drawing.Color.Red;
            this.lbl_TasteError.Location = new System.Drawing.Point(22, 431);
            this.lbl_TasteError.Name = "lbl_TasteError";
            this.lbl_TasteError.Size = new System.Drawing.Size(164, 15);
            this.lbl_TasteError.TabIndex = 56;
            this.lbl_TasteError.Text = "Invalid username or password";
            this.lbl_TasteError.Visible = false;
            // 
            // lblTaste
            // 
            this.lblTaste.AutoSize = true;
            this.lblTaste.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaste.Location = new System.Drawing.Point(21, 370);
            this.lblTaste.Name = "lblTaste";
            this.lblTaste.Size = new System.Drawing.Size(53, 21);
            this.lblTaste.TabIndex = 55;
            this.lblTaste.Text = "Taste:";
            // 
            // lblTextureError
            // 
            this.lblTextureError.AutoSize = true;
            this.lblTextureError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblTextureError.ForeColor = System.Drawing.Color.Red;
            this.lblTextureError.Location = new System.Drawing.Point(22, 527);
            this.lblTextureError.Name = "lblTextureError";
            this.lblTextureError.Size = new System.Drawing.Size(164, 15);
            this.lblTextureError.TabIndex = 60;
            this.lblTextureError.Text = "Invalid username or password";
            this.lblTextureError.Visible = false;
            // 
            // lblTexture
            // 
            this.lblTexture.AutoSize = true;
            this.lblTexture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexture.Location = new System.Drawing.Point(21, 466);
            this.lblTexture.Name = "lblTexture";
            this.lblTexture.Size = new System.Drawing.Size(71, 21);
            this.lblTexture.TabIndex = 59;
            this.lblTexture.Text = "Texture:";
            // 
            // cmbNutInfo
            // 
            this.cmbNutInfo.BackColor = System.Drawing.Color.White;
            this.cmbNutInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNutInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNutInfo.FormattingEnabled = true;
            this.cmbNutInfo.Items.AddRange(new object[] {
            "High Protein",
            "Low Fat",
            "Rich in Fiber",
            "Low Carb",
            "Low Calorie",
            "High Calorie",
            "High Carb",
            "High Fat",
            "Other"});
            this.cmbNutInfo.Location = new System.Drawing.Point(24, 303);
            this.cmbNutInfo.Name = "cmbNutInfo";
            this.cmbNutInfo.Size = new System.Drawing.Size(280, 28);
            this.cmbNutInfo.TabIndex = 61;
            // 
            // cmbTaste
            // 
            this.cmbTaste.BackColor = System.Drawing.Color.White;
            this.cmbTaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaste.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTaste.FormattingEnabled = true;
            this.cmbTaste.Items.AddRange(new object[] {
            "Sweet",
            "Sour",
            "Salty",
            "Bitter",
            "Savory"});
            this.cmbTaste.Location = new System.Drawing.Point(24, 400);
            this.cmbTaste.Name = "cmbTaste";
            this.cmbTaste.Size = new System.Drawing.Size(280, 28);
            this.cmbTaste.TabIndex = 62;
            // 
            // cmbTexture
            // 
            this.cmbTexture.BackColor = System.Drawing.Color.White;
            this.cmbTexture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTexture.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTexture.FormattingEnabled = true;
            this.cmbTexture.Items.AddRange(new object[] {
            "Crunchy ",
            "Creamy",
            "Chewy",
            "Soft",
            "Grainy",
            "Other"});
            this.cmbTexture.Location = new System.Drawing.Point(24, 490);
            this.cmbTexture.Name = "cmbTexture";
            this.cmbTexture.Size = new System.Drawing.Size(280, 28);
            this.cmbTexture.TabIndex = 63;
            // 
            // EditIngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 619);
            this.Controls.Add(this.cmbTexture);
            this.Controls.Add(this.cmbTaste);
            this.Controls.Add(this.cmbNutInfo);
            this.Controls.Add(this.lblTextureError);
            this.Controls.Add(this.lblTexture);
            this.Controls.Add(this.lbl_TasteError);
            this.Controls.Add(this.lblTaste);
            this.Controls.Add(this.lbl_NIfnoError);
            this.Controls.Add(this.lbl_NInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAvailbilityError);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.AddIngredients_lbl);
            this.Controls.Add(this.Name_Textbox);
            this.Controls.Add(this.Availbility_lbl);
            this.Controls.Add(this.OutOfStock_chk);
            this.Controls.Add(this.Available_chk);
            this.Controls.Add(this.Addlbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditIngredientForm";
            this.Text = "EditIngredientForm";
            this.Load += new System.EventHandler(this.EditIngredientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Addlbl;
        private System.Windows.Forms.Label lblAvailbilityError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label AddIngredients_lbl;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.Label Availbility_lbl;
        private System.Windows.Forms.CheckBox OutOfStock_chk;
        private System.Windows.Forms.CheckBox Available_chk;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbl_NIfnoError;
        private System.Windows.Forms.Label lbl_NInfo;
        private System.Windows.Forms.Label lbl_TasteError;
        private System.Windows.Forms.Label lblTaste;
        private System.Windows.Forms.Label lblTextureError;
        private System.Windows.Forms.Label lblTexture;
        private System.Windows.Forms.ComboBox cmbNutInfo;
        private System.Windows.Forms.ComboBox cmbTaste;
        private System.Windows.Forms.ComboBox cmbTexture;
    }
}