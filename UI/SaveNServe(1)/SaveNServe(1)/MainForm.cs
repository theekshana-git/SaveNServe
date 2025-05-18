using System;
using System.Drawing;
using System.Windows.Forms;

namespace SaveNServe_1_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "SaveNServe - Smart Ingredient Substitution System";
            this.Size = new Size(1280, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            InitializeTopPanel();
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

        private void BtnLogout_Click(object sender, EventArgs e)
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            HighlightButton(btnDashboard);
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

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HighlightButton(btnHelp);
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
    }
}