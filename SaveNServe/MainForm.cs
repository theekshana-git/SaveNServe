using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SaveNServe
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

            btnDashboard.Click += btnDashboard_Click;
            btnIngredients.Click += btnIngredients_Click;
            btnSubs.Click += btnSubs_Click;
            btnInven.Click += btnInven_Click;
            btnManage.Click += btnManage_Click;
            btnHelp.Click += btnHelp_Click;


            




            InitializeTopPanel();
            InitializeHistoryOverlayPanel();


        }

        

        private void ResetButtonColors()
        {
            btnDashboard.BackColor = Color.DarkGray;
            btnDashboard.ForeColor = Color.White;
            

            btnIngredients.BackColor = Color.DarkGray;
            btnIngredients.ForeColor = Color.White;
            

            btnSubs.BackColor = Color.DarkGray;
            btnSubs.ForeColor = Color.White;
            

            btnInven.BackColor = Color.DarkGray;
            btnInven.ForeColor = Color.White;
            

            btnManage.BackColor = Color.DarkGray;
            btnManage.ForeColor = Color.White;
            
            btnHelp.BackColor = Color.DarkGray;
            btnHelp.ForeColor = Color.White;
           
        }

        private void HighlightButton(Button activeButton)
        {
            ResetButtonColors();

            activeButton.BackColor = Color.Teal;
            activeButton.ForeColor = Color.White;

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


            dashboard.HistoryIconClicked += Dashboard_HistoryIconClicked;


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HighlightButton(btnDashboard);
            LoadDashBoard();
           
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        { 
            HighlightButton(btnDashboard);

            panelMainContent.Controls.Clear();
            DashboardControl dashboard = new DashboardControl();
            dashboard.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(dashboard);


            dashboard.HistoryIconClicked += Dashboard_HistoryIconClicked;

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

        private void panelUserMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxUserIcon_Click(object sender, EventArgs e)
        {
            
        }
    }
}
