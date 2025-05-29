using System;
using System.Windows.Forms;

namespace SaveNServe
{
    partial class InventoryControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryControl));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panelSearchBox = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ActionClick = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColActions = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.info = new System.Windows.Forms.Label();
            this.Titele = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.ExpiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.btnAddInventory = new System.Windows.Forms.Button();
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
            this.lblManage = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panelSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.panelSearchBox);
            this.leftPanel.Controls.Add(this.lbl_ActionClick);
            this.leftPanel.Controls.Add(this.dgvInventory);
            this.leftPanel.Controls.Add(this.info);
            this.leftPanel.Controls.Add(this.Titele);
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(674, 601);
            this.leftPanel.TabIndex = 9;
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
            this.panelSearchBox.TabIndex = 18;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.DimGray;
            this.searchBox.Location = new System.Drawing.Point(36, 7);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(584, 20);
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
            this.lbl_ActionClick.Location = new System.Drawing.Point(546, 147);
            this.lbl_ActionClick.Name = "lbl_ActionClick";
            this.lbl_ActionClick.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbl_ActionClick.Size = new System.Drawing.Size(67, 26);
            this.lbl_ActionClick.TabIndex = 17;
            this.lbl_ActionClick.Text = "Actions";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColQuantity,
            this.ColUnit,
            this.colExpireDate,
            this.colStatus,
            this.ColActions,
            this.ColEdit});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInventory.EnableHeadersVisualStyles = false;
            this.dgvInventory.GridColor = System.Drawing.SystemColors.Window;
            this.dgvInventory.Location = new System.Drawing.Point(23, 131);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvInventory.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvInventory.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvInventory.RowTemplate.Height = 40;
            this.dgvInventory.Size = new System.Drawing.Size(628, 420);
            this.dgvInventory.TabIndex = 16;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellContentClick);
            // 
            // ColName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColName.FillWeight = 197.3093F;
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColQuantity
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColQuantity.FillWeight = 80.67416F;
            this.ColQuantity.HeaderText = "Qty";
            this.ColQuantity.Name = "ColQuantity";
            this.ColQuantity.ReadOnly = true;
            // 
            // ColUnit
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColUnit.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColUnit.FillWeight = 80.67416F;
            this.ColUnit.HeaderText = "Unit";
            this.ColUnit.Name = "ColUnit";
            this.ColUnit.ReadOnly = true;
            this.ColUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colExpireDate
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colExpireDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.colExpireDate.FillWeight = 107.932F;
            this.colExpireDate.HeaderText = "Expiry Date";
            this.colExpireDate.Name = "colExpireDate";
            this.colExpireDate.ReadOnly = true;
            // 
            // colStatus
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colStatus.DefaultCellStyle = dataGridViewCellStyle7;
            this.colStatus.FillWeight = 87.61211F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // ColActions
            // 
            this.ColActions.ActiveLinkColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColActions.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColActions.FillWeight = 77.25938F;
            this.ColActions.HeaderText = "";
            this.ColActions.LinkColor = System.Drawing.Color.Red;
            this.ColActions.Name = "ColActions";
            this.ColActions.ReadOnly = true;
            this.ColActions.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColActions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColActions.Text = "Delete";
            this.ColActions.UseColumnTextForLinkValue = true;
            this.ColActions.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // ColEdit
            // 
            this.ColEdit.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ColEdit.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColEdit.FillWeight = 75.26481F;
            this.ColEdit.HeaderText = "";
            this.ColEdit.LinkColor = System.Drawing.Color.DodgerBlue;
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.ReadOnly = true;
            this.ColEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColEdit.Text = "Edit";
            this.ColEdit.UseColumnTextForLinkValue = true;
            this.ColEdit.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(13, 54);
            this.info.Name = "info";
            this.info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.info.Size = new System.Drawing.Size(0, 20);
            this.info.TabIndex = 10;
            this.info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Titele
            // 
            this.Titele.AutoSize = true;
            this.Titele.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titele.Location = new System.Drawing.Point(23, 20);
            this.Titele.Name = "Titele";
            this.Titele.Size = new System.Drawing.Size(109, 30);
            this.Titele.TabIndex = 8;
            this.Titele.Text = "Inventory";
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.Controls.Add(this.cmbUnit);
            this.rightPanel.Controls.Add(this.ExpiryDatePicker);
            this.rightPanel.Controls.Add(this.Clearbtn);
            this.rightPanel.Controls.Add(this.btnAddInventory);
            this.rightPanel.Controls.Add(this.lblDateError);
            this.rightPanel.Controls.Add(this.lblExpireDate);
            this.rightPanel.Controls.Add(this.lblUnitError);
            this.rightPanel.Controls.Add(this.lblUnit);
            this.rightPanel.Controls.Add(this.lblQuantityError);
            this.rightPanel.Controls.Add(this.Quantity_txtbox);
            this.rightPanel.Controls.Add(this.lblQuantity);
            this.rightPanel.Controls.Add(this.lblNameError);
            this.rightPanel.Controls.Add(this.Name_txtbox);
            this.rightPanel.Controls.Add(this.lblName);
            this.rightPanel.Controls.Add(this.lblManage);
            this.rightPanel.Location = new System.Drawing.Point(685, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(335, 601);
            this.rightPanel.TabIndex = 10;
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
            this.cmbUnit.Location = new System.Drawing.Point(45, 343);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(243, 28);
            this.cmbUnit.TabIndex = 52;
            // 
            // ExpiryDatePicker
            // 
            this.ExpiryDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDatePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDatePicker.Location = new System.Drawing.Point(45, 453);
            this.ExpiryDatePicker.Name = "ExpiryDatePicker";
            this.ExpiryDatePicker.Size = new System.Drawing.Size(243, 27);
            this.ExpiryDatePicker.TabIndex = 51;
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.White;
            this.Clearbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.Color.Black;
            this.Clearbtn.Image = ((System.Drawing.Image)(resources.GetObject("Clearbtn.Image")));
            this.Clearbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clearbtn.Location = new System.Drawing.Point(226, 76);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(62, 26);
            this.Clearbtn.TabIndex = 50;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.BackColor = System.Drawing.Color.Teal;
            this.btnAddInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInventory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInventory.ForeColor = System.Drawing.Color.White;
            this.btnAddInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddInventory.Location = new System.Drawing.Point(45, 529);
            this.btnAddInventory.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(241, 35);
            this.btnAddInventory.TabIndex = 49;
            this.btnAddInventory.Text = "SAVE";
            this.btnAddInventory.UseVisualStyleBackColor = false;
            this.btnAddInventory.Click += new System.EventHandler(this.btnAddInventory_Click);
            // 
            // lblDateError
            // 
            this.lblDateError.AutoSize = true;
            this.lblDateError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblDateError.ForeColor = System.Drawing.Color.Red;
            this.lblDateError.Location = new System.Drawing.Point(49, 483);
            this.lblDateError.Name = "lblDateError";
            this.lblDateError.Size = new System.Drawing.Size(164, 15);
            this.lblDateError.TabIndex = 45;
            this.lblDateError.Text = "Invalid username or password";
            this.lblDateError.Visible = false;
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpireDate.Location = new System.Drawing.Point(41, 413);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(89, 20);
            this.lblExpireDate.TabIndex = 44;
            this.lblExpireDate.Text = "Expire Date";
            // 
            // lblUnitError
            // 
            this.lblUnitError.AutoSize = true;
            this.lblUnitError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblUnitError.ForeColor = System.Drawing.Color.Red;
            this.lblUnitError.Location = new System.Drawing.Point(49, 374);
            this.lblUnitError.Name = "lblUnitError";
            this.lblUnitError.Size = new System.Drawing.Size(164, 15);
            this.lblUnitError.TabIndex = 41;
            this.lblUnitError.Text = "Invalid username or password";
            this.lblUnitError.Visible = false;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(41, 302);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(39, 20);
            this.lblUnit.TabIndex = 39;
            this.lblUnit.Text = "Unit";
            // 
            // lblQuantityError
            // 
            this.lblQuantityError.AutoSize = true;
            this.lblQuantityError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblQuantityError.ForeColor = System.Drawing.Color.Red;
            this.lblQuantityError.Location = new System.Drawing.Point(51, 264);
            this.lblQuantityError.Name = "lblQuantityError";
            this.lblQuantityError.Size = new System.Drawing.Size(164, 15);
            this.lblQuantityError.TabIndex = 38;
            this.lblQuantityError.Text = "Invalid username or password";
            this.lblQuantityError.Visible = false;
            // 
            // Quantity_txtbox
            // 
            this.Quantity_txtbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_txtbox.Location = new System.Drawing.Point(45, 234);
            this.Quantity_txtbox.Name = "Quantity_txtbox";
            this.Quantity_txtbox.Size = new System.Drawing.Size(243, 27);
            this.Quantity_txtbox.TabIndex = 37;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(41, 195);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 20);
            this.lblQuantity.TabIndex = 36;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(49, 153);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(164, 15);
            this.lblNameError.TabIndex = 35;
            this.lblNameError.Text = "Invalid username or password";
            this.lblNameError.Visible = false;
            // 
            // Name_txtbox
            // 
            this.Name_txtbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_txtbox.Location = new System.Drawing.Point(45, 123);
            this.Name_txtbox.Name = "Name_txtbox";
            this.Name_txtbox.Size = new System.Drawing.Size(243, 27);
            this.Name_txtbox.TabIndex = 19;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(41, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            // 
            // lblManage
            // 
            this.lblManage.AutoSize = true;
            this.lblManage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManage.ForeColor = System.Drawing.Color.Black;
            this.lblManage.Location = new System.Drawing.Point(30, 20);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(194, 30);
            this.lblManage.TabIndex = 17;
            this.lblManage.Text = "Manage Inventory";
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "InventoryControl";
            this.Size = new System.Drawing.Size(1020, 601);
            this.Load += new System.EventHandler(this.InventoryControl_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panelSearchBox.ResumeLayout(false);
            this.panelSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        
        #endregion
        private Panel leftPanel;
        private Label info;
        private Label Titele;
        private Panel rightPanel;
        private Label lblManage;
        private Label lblName;
        private TextBox Name_txtbox;
        private Label lblQuantityError;
        private TextBox Quantity_txtbox;
        private Label lblQuantity;
        private Label lblNameError;
        private Label lblUnitError;
        private Label lblUnit;
        private Label lblExpireDate;
        private Label lblDateError;
        private Button btnAddInventory;
        private Button Clearbtn;
        private DateTimePicker ExpiryDatePicker;
        private DataGridView dgvInventory;
        private Label lbl_ActionClick;
        private Panel panelSearchBox;
        private TextBox searchBox;
        private PictureBox pictureBox1;
        private ComboBox cmbUnit;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColQuantity;
        private DataGridViewTextBoxColumn ColUnit;
        private DataGridViewTextBoxColumn colExpireDate;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewLinkColumn ColActions;
        private DataGridViewLinkColumn ColEdit;
    }
}
