using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SaveNServe_1_
{
    public partial class MainForm : Form
    {
        private Panel HistoryOverlayPanel;
        private bool isDashboardActive = false;

        public MainForm()
        {
            InitializeComponent();
            this.Text = "SaveNServe - Smart Ingredient Substitution System";
            this.Size = new Size(1280, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Load += MainForm_Load;
            btnIngredients.Click += btnIngredients_Click;
            btnSubs.Click += btnSubs_Click;
            btnInven.Click += btnInven_Click;
            btnManage.Click += btnManage_Click;
            btnHelp.Click += btnHelp_Click;



            btnIngredients.MouseEnter += btnIngredients_MouseEnter;
            btnIngredients.MouseLeave += btnIngredients_MouseLeave;

            btnSubs.MouseEnter += btnSubs_MouseEnter;
            btnSubs.MouseLeave += btnSubs_MouseLeave;

            btnInven.MouseEnter += btnInven_MouseEnter;
            btnInven.MouseLeave += btnInven_MouseLeave;

            btnManage.MouseEnter += btnManage_MouseEnter;
            btnManage.MouseLeave += btnManage_MouseLeave;

            btnHelp.MouseEnter += btnHelp_MouseEnter;
            btnHelp.MouseLeave += btnHelp_MouseLeave;

            btnLogout.MouseEnter += btnLogout_MouseEnter;
            btnLogout.MouseLeave += btnLogout_MouseLeave;



            InitializeTopPanel();
            InitializeHistoryOverlayPanel();


        }

        private void ResetButtonColors()
        {
            btnDashboard.BackColor = Color.DarkGray;
            btnDashboard.ForeColor = Color.White;
            picDashboard.BackColor = Color.DarkGray;

            btnIngredients.BackColor = Color.DarkGray;
            btnIngredients.ForeColor = Color.White;
            picIngredients.BackColor = Color.DarkGray;

            btnSubs.BackColor = Color.DarkGray;
            btnSubs.ForeColor = Color.White;
            picSubs.BackColor = Color.DarkGray;

            btnInven.BackColor = Color.DarkGray;
            btnInven.ForeColor = Color.White;
            picInven.BackColor = Color.DarkGray;

            btnManage.BackColor = Color.DarkGray;
            btnManage.ForeColor = Color.White;
            picManage.BackColor = Color.DarkGray;

            btnHelp.BackColor = Color.DarkGray;
            btnHelp.ForeColor = Color.White;
            picHelp.BackColor = Color.DarkGray;
        }

        private void HighlightButton(Button activeButton)
        {
            ResetButtonColors();

            activeButton.BackColor = Color.Teal;
            activeButton.ForeColor = Color.White;

            if (activeButton == btnDashboard)
                picDashboard.BackColor = Color.Teal;
            else if (activeButton == btnIngredients)
                picIngredients.BackColor = Color.Teal;
            else if (activeButton == btnSubs)
                picSubs.BackColor = Color.Teal;
            else if (activeButton == btnInven)
                picInven.BackColor = Color.Teal;
            else if (activeButton == btnManage)
                picManage.BackColor = Color.Teal;
            else if (activeButton == btnHelp)
                picHelp.BackColor = Color.Teal;
        }

        private void InitializeTopPanel()
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void panel5_Paint(object sender, PaintEventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_HistoryIconClicked(object sender, EventArgs e)
        {
            HistoryControl historyControl = new HistoryControl();
            historyControl.Dock = DockStyle.Fill;

            HistoryOverlayPanel.Controls.Clear();
            HistoryOverlayPanel.Controls.Add(historyControl);
            HistoryOverlayPanel.Visible = true;
            HistoryOverlayPanel.BringToFront();

            historyControl.CloseRequested += (s, args) =>
            {
                HistoryOverlayPanel.Controls.Clear();
                HistoryOverlayPanel.Visible = false;
            };
        }

        private void InitializeHistoryOverlayPanel()
        {
            HistoryOverlayPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Visible = false,
            };

            this.Controls.Add(HistoryOverlayPanel);
            HistoryOverlayPanel.BringToFront();
        }

        private void LoadDashBoard()
        {
            panelMainContent.Controls.Clear();
            DashboardControl dashboard = new DashboardControl();
            dashboard.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(dashboard);
            isDashboardActive = true;

            dashboard.HistoryIconClicked += Dashboard_HistoryIconClicked;

          
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HighlightButton(btnDashboard);
            LoadDashBoard();
           
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            isDashboardActive = true;
            HighlightButton(btnDashboard);
            LoadDashBoard();

        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            HighlightButton(btnIngredients);

            panelMainContent.Controls.Clear();
            IngredientsControl ingredients = new IngredientsControl();
            ingredients.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(ingredients);

        }

        private void btnSubs_Click(object sender, EventArgs e)
        {
            HighlightButton(btnSubs);

            panelMainContent.Controls.Clear();
            SubstitutionsControl subs = new SubstitutionsControl();
            subs.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(subs);

        }

        private void btnInven_Click(object sender, EventArgs e)
        {
            HighlightButton(btnInven);

            panelMainContent.Controls.Clear();
            InventoryControl inventory = new InventoryControl();
            inventory.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(inventory);

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            HighlightButton(btnManage);

            panelMainContent.Controls.Clear();
            ManageUsers users = new ManageUsers();
            users.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(users);

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HighlightButton(btnHelp);

            panelMainContent.Controls.Clear();
            HelpAbout Help = new HelpAbout();
            Help.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(Help);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblPendingSubs_Click(object sender, EventArgs e)
        {

        }

        private void splitContainerbottom_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void overlayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            picDashboard.BackColor = (btnDashboard.BackColor == Color.Teal) ? Color.FromArgb(0, 153, 153) : Color.FromArgb(152, 152, 152);
        }

        private void btnDasboard_MouseLeave(object sender, EventArgs e)
        {
            picDashboard.BackColor = (btnDashboard.BackColor == Color.Teal) ? Color.Teal : Color.DarkGray;
        }

        private void btnIngredients_MouseEnter(object sender, EventArgs e)
        {
            picIngredients.BackColor = (btnIngredients.BackColor == Color.Teal) ? Color.FromArgb(0, 153, 153) : Color.FromArgb(152, 152, 152);
        }

        private void btnIngredients_MouseLeave(object sender, EventArgs e)
        {
            picIngredients.BackColor = (btnIngredients.BackColor == Color.Teal) ? Color.Teal : Color.DarkGray;
        }

        private void btnSubs_MouseEnter(object sender, EventArgs e)
        {
            picSubs.BackColor = (btnSubs.BackColor == Color.Teal) ? Color.FromArgb(0, 153, 153) : Color.FromArgb(152, 152, 152);
        }

        private void btnSubs_MouseLeave(object sender, EventArgs e)
        {
            picSubs.BackColor = (btnSubs.BackColor == Color.Teal) ? Color.Teal : Color.DarkGray;
        }

        private void btnInven_MouseEnter(object sender, EventArgs e)
        {
            picInven.BackColor = (btnInven.BackColor == Color.Teal) ? Color.FromArgb(0, 153, 153) : Color.FromArgb(152, 152, 152);
        }

        private void btnInven_MouseLeave(object sender, EventArgs e)
        {
            picInven.BackColor = (btnInven.BackColor == Color.Teal) ? Color.Teal : Color.DarkGray;
        }

        private void btnManage_MouseEnter(object sender, EventArgs e)
        {
            picManage.BackColor = (btnManage.BackColor == Color.Teal) ? Color.FromArgb(0, 153, 153) : Color.FromArgb(152, 152, 152);
        }

        private void btnManage_MouseLeave(object sender, EventArgs e)
        {
            picManage.BackColor = (btnManage.BackColor == Color.Teal) ? Color.Teal : Color.DarkGray;
        }

        private void btnHelp_MouseEnter(object sender, EventArgs e)
        {
            picHelp.BackColor = (btnHelp.BackColor == Color.Teal) ? Color.FromArgb(0, 153, 153) : Color.FromArgb(152, 152, 152);
        }

        private void btnHelp_MouseLeave(object sender, EventArgs e)
        {
            picHelp.BackColor = (btnHelp.BackColor == Color.Teal) ? Color.Teal : Color.DarkGray;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            picLogout.BackColor = Color.FromArgb(229, 68, 53);
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            picLogout.BackColor = Color.FromArgb(255, 76, 60);
        }

        private void picLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
