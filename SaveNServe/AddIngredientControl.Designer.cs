namespace SaveNServe
{
    partial class AddIngredientControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIngredientControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.Left_panel = new System.Windows.Forms.Panel();
            this.panelSearchBox = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ActionClick = new System.Windows.Forms.Label();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Right_panel = new System.Windows.Forms.Panel();
            this.lblTextureError = new System.Windows.Forms.Label();
            this.lblTasteError = new System.Windows.Forms.Label();
            this.lblNinfoError = new System.Windows.Forms.Label();
            this.lblAvailbilityError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.cmbTexture = new System.Windows.Forms.ComboBox();
            this.cmbTaste = new System.Windows.Forms.ComboBox();
            this.cmbNutInfo = new System.Windows.Forms.ComboBox();
            this.Addlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddIngredients_lbl = new System.Windows.Forms.Label();
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NuInfo_lbl = new System.Windows.Forms.Label();
            this.Availbility_lbl = new System.Windows.Forms.Label();
            this.OutOfStock_chk = new System.Windows.Forms.CheckBox();
            this.Available_chk = new System.Windows.Forms.CheckBox();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Main_panel.SuspendLayout();
            this.Left_panel.SuspendLayout();
            this.panelSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            this.Right_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_panel
            // 
            this.Main_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Main_panel.Controls.Add(this.Left_panel);
            this.Main_panel.Controls.Add(this.Right_panel);
            this.Main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_panel.Location = new System.Drawing.Point(0, 0);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(1020, 601);
            this.Main_panel.TabIndex = 0;
            // 
            // Left_panel
            // 
            this.Left_panel.BackColor = System.Drawing.Color.White;
            this.Left_panel.Controls.Add(this.panelSearchBox);
            this.Left_panel.Controls.Add(this.lbl_ActionClick);
            this.Left_panel.Controls.Add(this.dgvIngredients);
            this.Left_panel.Controls.Add(this.lblTitle);
            this.Left_panel.Location = new System.Drawing.Point(3, 0);
            this.Left_panel.Name = "Left_panel";
            this.Left_panel.Size = new System.Drawing.Size(673, 601);
            this.Left_panel.TabIndex = 30;
            // 
            // panelSearchBox
            // 
            this.panelSearchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSearchBox.Controls.Add(this.searchBox);
            this.panelSearchBox.Controls.Add(this.pictureBox1);
            this.panelSearchBox.Location = new System.Drawing.Point(23, 73);
            this.panelSearchBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panelSearchBox.Name = "panelSearchBox";
            this.panelSearchBox.Padding = new System.Windows.Forms.Padding(5);
            this.panelSearchBox.Size = new System.Drawing.Size(628, 35);
            this.panelSearchBox.TabIndex = 4;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.DimGray;
            this.searchBox.Location = new System.Drawing.Point(36, 8);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(461, 20);
            this.searchBox.TabIndex = 2;
            this.searchBox.Text = "Search Ingredient";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SaveNServe.Properties.Resources.icons8_search_30;
            this.pictureBox1.InitialImage = global::SaveNServe.Properties.Resources.icons8_search_30;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_ActionClick
            // 
            this.lbl_ActionClick.AutoSize = true;
            this.lbl_ActionClick.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_ActionClick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ActionClick.Location = new System.Drawing.Point(513, 140);
            this.lbl_ActionClick.Name = "lbl_ActionClick";
            this.lbl_ActionClick.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbl_ActionClick.Size = new System.Drawing.Size(67, 26);
            this.lbl_ActionClick.TabIndex = 3;
            this.lbl_ActionClick.Text = "Actions";
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.AllowUserToAddRows = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIngredients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngredients.BackgroundColor = System.Drawing.Color.White;
            this.dgvIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIngredients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvIngredients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngredients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColAvailable,
            this.ColEdit});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngredients.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvIngredients.EnableHeadersVisualStyles = false;
            this.dgvIngredients.GridColor = System.Drawing.SystemColors.Window;
            this.dgvIngredients.Location = new System.Drawing.Point(23, 131);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngredients.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvIngredients.RowHeadersVisible = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngredients.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvIngredients.RowTemplate.Height = 40;
            this.dgvIngredients.Size = new System.Drawing.Size(628, 449);
            this.dgvIngredients.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(23, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage Ingredients";
            // 
            // Right_panel
            // 
            this.Right_panel.AutoScroll = true;
            this.Right_panel.BackColor = System.Drawing.Color.White;
            this.Right_panel.Controls.Add(this.lblTextureError);
            this.Right_panel.Controls.Add(this.lblTasteError);
            this.Right_panel.Controls.Add(this.lblNinfoError);
            this.Right_panel.Controls.Add(this.lblAvailbilityError);
            this.Right_panel.Controls.Add(this.lblNameError);
            this.Right_panel.Controls.Add(this.Clearbtn);
            this.Right_panel.Controls.Add(this.btnAddIngredient);
            this.Right_panel.Controls.Add(this.cmbTexture);
            this.Right_panel.Controls.Add(this.cmbTaste);
            this.Right_panel.Controls.Add(this.cmbNutInfo);
            this.Right_panel.Controls.Add(this.Addlbl);
            this.Right_panel.Controls.Add(this.label2);
            this.Right_panel.Controls.Add(this.AddIngredients_lbl);
            this.Right_panel.Controls.Add(this.Name_Textbox);
            this.Right_panel.Controls.Add(this.label1);
            this.Right_panel.Controls.Add(this.NuInfo_lbl);
            this.Right_panel.Controls.Add(this.Availbility_lbl);
            this.Right_panel.Controls.Add(this.OutOfStock_chk);
            this.Right_panel.Controls.Add(this.Available_chk);
            this.Right_panel.Location = new System.Drawing.Point(685, 0);
            this.Right_panel.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.Right_panel.Name = "Right_panel";
            this.Right_panel.Size = new System.Drawing.Size(335, 601);
            this.Right_panel.TabIndex = 29;
            // 
            // lblTextureError
            // 
            this.lblTextureError.AutoSize = true;
            this.lblTextureError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblTextureError.ForeColor = System.Drawing.Color.Red;
            this.lblTextureError.Location = new System.Drawing.Point(31, 510);
            this.lblTextureError.Name = "lblTextureError";
            this.lblTextureError.Size = new System.Drawing.Size(164, 15);
            this.lblTextureError.TabIndex = 39;
            this.lblTextureError.Text = "Invalid username or password";
            this.lblTextureError.Visible = false;
            // 
            // lblTasteError
            // 
            this.lblTasteError.AutoSize = true;
            this.lblTasteError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblTasteError.ForeColor = System.Drawing.Color.Red;
            this.lblTasteError.Location = new System.Drawing.Point(31, 418);
            this.lblTasteError.Name = "lblTasteError";
            this.lblTasteError.Size = new System.Drawing.Size(164, 15);
            this.lblTasteError.TabIndex = 38;
            this.lblTasteError.Text = "Invalid username or password";
            this.lblTasteError.Visible = false;
            // 
            // lblNinfoError
            // 
            this.lblNinfoError.AutoSize = true;
            this.lblNinfoError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblNinfoError.ForeColor = System.Drawing.Color.Red;
            this.lblNinfoError.Location = new System.Drawing.Point(31, 318);
            this.lblNinfoError.Name = "lblNinfoError";
            this.lblNinfoError.Size = new System.Drawing.Size(164, 15);
            this.lblNinfoError.TabIndex = 37;
            this.lblNinfoError.Text = "Invalid username or password";
            this.lblNinfoError.Visible = false;
            // 
            // lblAvailbilityError
            // 
            this.lblAvailbilityError.AutoSize = true;
            this.lblAvailbilityError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblAvailbilityError.ForeColor = System.Drawing.Color.Red;
            this.lblAvailbilityError.Location = new System.Drawing.Point(27, 223);
            this.lblAvailbilityError.Name = "lblAvailbilityError";
            this.lblAvailbilityError.Size = new System.Drawing.Size(164, 15);
            this.lblAvailbilityError.TabIndex = 36;
            this.lblAvailbilityError.Text = "Invalid username or password";
            this.lblAvailbilityError.Visible = false;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(27, 131);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(164, 15);
            this.lblNameError.TabIndex = 34;
            this.lblNameError.Text = "Invalid username or password";
            this.lblNameError.Visible = false;
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.White;
            this.Clearbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.Color.Black;
            this.Clearbtn.Image = ((System.Drawing.Image)(resources.GetObject("Clearbtn.Image")));
            this.Clearbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clearbtn.Location = new System.Drawing.Point(249, 65);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(61, 26);
            this.Clearbtn.TabIndex = 33;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.BackColor = System.Drawing.Color.Teal;
            this.btnAddIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIngredient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIngredient.ForeColor = System.Drawing.Color.White;
            this.btnAddIngredient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddIngredient.Location = new System.Drawing.Point(30, 545);
            this.btnAddIngredient.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(280, 35);
            this.btnAddIngredient.TabIndex = 32;
            this.btnAddIngredient.Text = "ADD INGREDIENT";
            this.btnAddIngredient.UseVisualStyleBackColor = false;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
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
            this.cmbTexture.Location = new System.Drawing.Point(30, 479);
            this.cmbTexture.Name = "cmbTexture";
            this.cmbTexture.Size = new System.Drawing.Size(280, 28);
            this.cmbTexture.TabIndex = 31;
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
            this.cmbTaste.Location = new System.Drawing.Point(30, 387);
            this.cmbTaste.Name = "cmbTaste";
            this.cmbTaste.Size = new System.Drawing.Size(280, 28);
            this.cmbTaste.TabIndex = 30;
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
            this.cmbNutInfo.Location = new System.Drawing.Point(30, 287);
            this.cmbNutInfo.Name = "cmbNutInfo";
            this.cmbNutInfo.Size = new System.Drawing.Size(280, 28);
            this.cmbNutInfo.TabIndex = 29;
            // 
            // Addlbl
            // 
            this.Addlbl.AutoSize = true;
            this.Addlbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addlbl.ForeColor = System.Drawing.Color.Black;
            this.Addlbl.Location = new System.Drawing.Point(30, 20);
            this.Addlbl.Name = "Addlbl";
            this.Addlbl.Size = new System.Drawing.Size(214, 30);
            this.Addlbl.TabIndex = 16;
            this.Addlbl.Text = "Add New Ingredient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Texture";
            // 
            // AddIngredients_lbl
            // 
            this.AddIngredients_lbl.AutoSize = true;
            this.AddIngredients_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIngredients_lbl.Location = new System.Drawing.Point(26, 70);
            this.AddIngredients_lbl.Name = "AddIngredients_lbl";
            this.AddIngredients_lbl.Size = new System.Drawing.Size(56, 21);
            this.AddIngredients_lbl.TabIndex = 17;
            this.AddIngredients_lbl.Text = "Name";
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Textbox.Location = new System.Drawing.Point(30, 97);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(280, 27);
            this.Name_Textbox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Taste";
            // 
            // NuInfo_lbl
            // 
            this.NuInfo_lbl.AutoSize = true;
            this.NuInfo_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuInfo_lbl.Location = new System.Drawing.Point(26, 263);
            this.NuInfo_lbl.Name = "NuInfo_lbl";
            this.NuInfo_lbl.Size = new System.Drawing.Size(130, 21);
            this.NuInfo_lbl.TabIndex = 24;
            this.NuInfo_lbl.Text = "Nutritional Info";
            // 
            // Availbility_lbl
            // 
            this.Availbility_lbl.AutoSize = true;
            this.Availbility_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Availbility_lbl.Location = new System.Drawing.Point(26, 171);
            this.Availbility_lbl.Name = "Availbility_lbl";
            this.Availbility_lbl.Size = new System.Drawing.Size(89, 21);
            this.Availbility_lbl.TabIndex = 23;
            this.Availbility_lbl.Text = "Availbility";
            // 
            // OutOfStock_chk
            // 
            this.OutOfStock_chk.AutoSize = true;
            this.OutOfStock_chk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutOfStock_chk.Location = new System.Drawing.Point(141, 195);
            this.OutOfStock_chk.Name = "OutOfStock_chk";
            this.OutOfStock_chk.Size = new System.Drawing.Size(117, 25);
            this.OutOfStock_chk.TabIndex = 22;
            this.OutOfStock_chk.Text = "Out Of Stock";
            this.OutOfStock_chk.UseVisualStyleBackColor = true;
            this.OutOfStock_chk.CheckedChanged += new System.EventHandler(this.OutOfStock_chk_CheckedChanged);
            // 
            // Available_chk
            // 
            this.Available_chk.AutoSize = true;
            this.Available_chk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available_chk.Location = new System.Drawing.Point(30, 195);
            this.Available_chk.Name = "Available_chk";
            this.Available_chk.Size = new System.Drawing.Size(92, 25);
            this.Available_chk.TabIndex = 21;
            this.Available_chk.Text = "Available";
            this.Available_chk.UseVisualStyleBackColor = true;
            this.Available_chk.CheckedChanged += new System.EventHandler(this.Available_CheckedChanged);
            // 
            // ColName
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColName.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColName.FillWeight = 39.50299F;
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColAvailable
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColAvailable.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColAvailable.FillWeight = 308.6655F;
            this.ColAvailable.HeaderText = "Availability";
            this.ColAvailable.Name = "ColAvailable";
            this.ColAvailable.ReadOnly = true;
            this.ColAvailable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAvailable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColEdit
            // 
            this.ColEdit.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ColEdit.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColEdit.FillWeight = 71.88435F;
            this.ColEdit.HeaderText = "";
            this.ColEdit.LinkColor = System.Drawing.Color.DodgerBlue;
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.ReadOnly = true;
            this.ColEdit.Text = "Edit";
            this.ColEdit.UseColumnTextForLinkValue = true;
            this.ColEdit.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            // 
            // AddIngredientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Main_panel);
            this.Name = "AddIngredientControl";
            this.Size = new System.Drawing.Size(1020, 601);
            this.Load += new System.EventHandler(this.AddIngredientControl_Load);
            this.Main_panel.ResumeLayout(false);
            this.Left_panel.ResumeLayout(false);
            this.Left_panel.PerformLayout();
            this.panelSearchBox.ResumeLayout(false);
            this.panelSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            this.Right_panel.ResumeLayout(false);
            this.Right_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.Label Availbility_lbl;
        private System.Windows.Forms.CheckBox OutOfStock_chk;
        private System.Windows.Forms.CheckBox Available_chk;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.Label AddIngredients_lbl;
        private System.Windows.Forms.Label NuInfo_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Addlbl;
        private System.Windows.Forms.Panel Right_panel;
        private System.Windows.Forms.ComboBox cmbNutInfo;
        private System.Windows.Forms.ComboBox cmbTexture;
        private System.Windows.Forms.ComboBox cmbTaste;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Panel Left_panel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Label lbl_ActionClick;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblTasteError;
        private System.Windows.Forms.Label lblNinfoError;
        private System.Windows.Forms.Label lblAvailbilityError;
        private System.Windows.Forms.Label lblTextureError;
        private System.Windows.Forms.Panel panelSearchBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAvailable;
        private System.Windows.Forms.DataGridViewLinkColumn ColEdit;
    }
}
