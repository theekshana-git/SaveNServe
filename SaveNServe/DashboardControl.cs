using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SaveNServe
{
    public partial class DashboardControl : UserControl
    {
        public event EventHandler HistoryIconClicked;
        public DashboardControl()
        {
            InitializeComponent();

            LoadDashboardData();
            LoadRecentActivities();
        }


        private void LoadDashboardData()
        {
            try
            {
                // 1. Total Ingredients Count
                DataTable ingredientsTable = DatabaseHelper.ExecuteQuery("SELECT COUNT(*) AS Total FROM Ingredients");
                if (ingredientsTable != null && ingredientsTable.Rows.Count > 0)
                    lblTotalIngredientsCount.Text = ingredientsTable.Rows[0]["Total"].ToString();

                // 2. Expired Items Count
                DataTable expiredTable = DatabaseHelper.ExecuteQuery(
                    "SELECT COUNT(*) AS Expired FROM Inventory WHERE ExpiryDate < @Today",
                    new System.Data.SqlClient.SqlParameter("@Today", DateTime.Now.Date)
                );
                if (expiredTable != null && expiredTable.Rows.Count > 0)
                    lblExpiredCount.Text = expiredTable.Rows[0]["Expired"].ToString();

                // 3. Low Stock Items Count
                DataTable lowStockTable = DatabaseHelper.ExecuteQuery(
                    "SELECT COUNT(*) AS LowStock FROM Inventory WHERE Quantity < 2"
                );
                if (lowStockTable != null && lowStockTable.Rows.Count > 0)
                    lblLowStockCount.Text = lowStockTable.Rows[0]["LowStock"].ToString();

                // 4. Total Users Count
                DataTable usersTable = DatabaseHelper.ExecuteQuery("SELECT COUNT(*) AS Users FROM Users");
                if (usersTable != null && usersTable.Rows.Count > 0)
                    lblUsersCount.Text = usersTable.Rows[0]["Users"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message, "Dashboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRecentActivities()
        {
            // Latest Ingredient Added
            DataTable ingredientActivity = DatabaseHelper.ExecuteQuery(
                "SELECT TOP 1 Name, DateCreated FROM Ingredients ORDER BY DateCreated DESC"
            );
            if (ingredientActivity.Rows.Count > 0)
            {
                var name = ingredientActivity.Rows[0]["Name"].ToString();
                var date = Convert.ToDateTime(ingredientActivity.Rows[0]["DateCreated"]);
                label2.Text = $"Added '{name}'";
                label2.Location = new Point(18, 53);
                label5.Text = GetFormattedTime(date);
                label5.AutoSize = true;
                label5.Location = new Point(panelRecentActivity.Width - label5.Width - 18, 53); // right aligned
            }

            // Latest Substitution (using JOIN)
            DataTable substitutionActivity = DatabaseHelper.ExecuteQuery(
                @"SELECT TOP 1 i.Name AS IngredientName, s.CreatedDate 
          FROM Substitutions s
          INNER JOIN Ingredients i ON s.IngredientId = i.IngredientId
          ORDER BY s.CreatedDate DESC"
            );
            if (substitutionActivity.Rows.Count > 0)
            {
                var name = substitutionActivity.Rows[0]["IngredientName"].ToString();
                var date = Convert.ToDateTime(substitutionActivity.Rows[0]["CreatedDate"]);
                label3.Text = $"Approved substitution for '{name}'";
                label3.Location = new Point(18, 97);
                label6.Text = GetFormattedTime(date);
                label6.AutoSize = true;
                label6.Location = new Point(panelRecentActivity.Width - label6.Width - 18, 97);
            }

            // Latest Stock Update (using JOIN)
            DataTable stockActivity = DatabaseHelper.ExecuteQuery(
                @"SELECT TOP 1 i.Name AS IngredientName, inv.LastUpdated 
          FROM Inventory inv
          INNER JOIN Ingredients i ON inv.IngredientId = i.IngredientId
          ORDER BY inv.LastUpdated DESC"
            );
            if (stockActivity.Rows.Count > 0)
            {
                var name = stockActivity.Rows[0]["IngredientName"].ToString();
                var date = Convert.ToDateTime(stockActivity.Rows[0]["LastUpdated"]);
                label4.Text = $"Updated stock for '{name}'";
                label4.Location = new Point(18, 141);
                label7.Text = GetFormattedTime(date);
                label7.AutoSize = true;
                label7.Location = new Point(panelRecentActivity.Width - label7.Width - 18, 141);
            }
        }

        private string GetFormattedTime(DateTime date)
        {
            if (date.Date == DateTime.Today)
                return $"Today, {date:hh:mm tt}";
            else if (date.Date == DateTime.Today.AddDays(-1))
                return $"Yesterday, {date:hh:mm tt}";
            else
                return $"{date:dddd}, {date:hh:mm tt}";
        }








    }
}




