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
        private string loggedInUsername;
        private string loggedInRole;

        public MainForm(string username, string role)
        {
            InitializeComponent();
            loggedInUsername = username;
            loggedInRole = role;

            if(loggedInRole != "Admin")
            {
                btnManage.Enabled = false;
               
            }

            this.Text = "SaveNServe - Smart Ingredient Substitution System";
            this.Size = new Size(1280, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Load += MainForm_Load;

            btnDashboard.Click += btnDashboard_Click;
            btnIngredients.Click += btnIngredients_Click;
            btnSubs.Click += btnSubs_Click;
            btnInven.Click += btnInven_Click;
            btnManage.Click += btnManage_Click;
            btnHelp.Click += btnHelp_Click;


            




            
            


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



        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }












        private void LoadDashBoard()
        {
            panelMainContent.Controls.Clear();
            DashboardControl dashboard = new DashboardControl();
            dashboard.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(dashboard);


           


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HighlightButton(btnDashboard);
            LoadDashBoard();

            label2.Text = loggedInUsername;
           
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        { 
            HighlightButton(btnDashboard);

            panelMainContent.Controls.Clear();
            DashboardControl dashboard = new DashboardControl();
            dashboard.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(dashboard);


            

        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            HighlightButton(btnIngredients);

            panelMainContent.Controls.Clear();
            AddIngredientControl ingredients = new AddIngredientControl();
            ingredients.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(ingredients);

        }

        private void btnSubs_Click(object sender, EventArgs e)
        {
            HighlightButton(btnSubs);

            panelMainContent.Controls.Clear();
            SubstitutionsControl subs = new SubstitutionsControl(loggedInUsername);
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

    
        

        

        

       

        

       

       
    }
}
