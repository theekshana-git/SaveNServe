using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;



namespace SaveNServe_1_
{
    public partial class SubstitutionsControl : UserControl
    {
        private DataTable substitutionsTable;
        //private string connectionString = "Data Source=DESKTOP-IS0OJNF\\SQLEXPRESS;Initial Catalog=testsubstitution;Integrated Security=True";

        public SubstitutionsControl()
        {


            InitializeComponent();

            if (panel3 != null)
            {
                txtsearchingredients.Padding = new Padding(10);
                RoundPanel(panel3);

            }

            txtsearchingredients.Enter += TxtSearchIngredient_Enter;
            txtsearchingredients.LostFocus += TxtSearchIngredient_Leave;

           

            

        }



        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RoundPanel(panel3);
            InitializeDataTable();
            CustomizeDataGridView();
            //LoadDataFromDatabase();
            dataGridView1.Visible = true;

            add_btn.Click += BtnAdd_Click;
            //txtsearchingredients.TextChanged += txtsearchingredients_TextChanged;



        }

        //round panel
        private void RoundPanel(Panel panel)
        {
            if (panel != null && panel.Width > 0 && panel.Height > 0) 
            {
                GraphicsPath path = new GraphicsPath();
                int radius = 15; 
                path.StartFigure();
                path.AddArc(0, 0, radius, radius, 180, 90);  
                path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90); 
                path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90); 
                path.AddArc(0, panel.Height - radius, radius, radius, 90, 90); 
                path.CloseFigure();
                panel.Region = new Region(path);

            }
        }





        //Data grid customization
        private void CustomizeDataGridView()
        {
            
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;

            // Column Header Styling
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Row Styling
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Cell Padding
            dataGridView1.DefaultCellStyle.Padding = new Padding(6);

            // Grid Lines & Borders
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.GridColor = Color.LightGray;

            // Adjust Row Height
            dataGridView1.RowTemplate.Height = 30;

            // Enable Smooth Scrolling
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.SetProperty,
                null, dataGridView1, new object[] { true });

            dataGridView1.ReadOnly = true; // Makes all cells non-editable
            dataGridView1.AllowUserToAddRows = false; // Prevents adding empty rows
            dataGridView1.AllowUserToDeleteRows = false; // Prevents deleting rows
            dataGridView1.AllowUserToOrderColumns = false; // Prevents column reordering

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

        }


       


        // For the search box
        private void TxtSearchIngredient_Enter(object sender, EventArgs e)
        {

            if (txtsearchingredients.Text == "Search by ingredient…")
            {
                txtsearchingredients.Text = "";
                txtsearchingredients.ForeColor = Color.Black;
            }
        }

        private void TxtSearchIngredient_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtsearchingredients.Text))
            {
                txtsearchingredients.Text = "Search by ingredient…";
                txtsearchingredients.ForeColor = Color.Gray;

            }
        }


        private void InitializeDataTable()
        {
            // Ensure columns are not duplicated
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true; // Allow automatic column generation

            // Initialize DataTable
            substitutionsTable = new DataTable();
            substitutionsTable.Columns.Add("Original Ingredient");
            substitutionsTable.Columns.Add("Suggested Substitute");
            substitutionsTable.Columns.Add("Similarity Score");
            substitutionsTable.Columns.Add("Created By");
            substitutionsTable.Columns.Add("Date");


            // Bind DataTable to DataGridView
            dataGridView1.DataSource = substitutionsTable;
        }



        //loading data from database
        //private void LoadDataFromDatabase()
        //{
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            string query = "SELECT OriginalIngredient as [Original Ingredient], SuggestedSubstitute as [Suggested Substitute ], Notes, CreatedBy, Date FROM mainT2";

        //            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
        //            {
        //                DataTable table = new DataTable();
        //                adapter.Fill(table);
        //                dataGridView1.DataSource = table;
        //            }
        //        }
        //    }
        //    catch (SqlException sqlEx)
        //    {
        //        MessageBox.Show($"⚠ SQL Error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"⚠ Error loading data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}









        // validation
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool hasError = false;

            string originalIngredient = txtoriginal.Text.Trim();
            string substitute = txtsubstitute.Text.Trim();
            string score = txtscore.Text.Trim();
            string createdBy = "The system";

            

            // Reset error messages
            error1.Text = "";
            error2.Text = "";

            // Validate input fields
            if (string.IsNullOrEmpty(originalIngredient))
            {
                error1.Text = "⚠ Please enter an original ingredient";
                hasError = true;
            }

            if (string.IsNullOrEmpty(substitute))
            {
                error2.Text = "⚠ Please enter a substitute";
                hasError = true;
            }

            if (hasError)
            {
                error1.ForeColor = Color.Red;
                error1.Visible = true;
                error2.ForeColor = Color.Red;
                error2.Visible = true;
                return;
            }

            // Insert data into database
            //    try
            //    {
            //        using (SqlConnection connection = new SqlConnection(connectionString))
            //        {
            //            connection.Open();
            //            string query = "INSERT INTO MainT2 (OriginalIngredient, SuggestedSubstitute, Notes, CreatedBy, Date) VALUES (@OriginalIngredient, @SuggestedSubstitute, @Notes, @CreatedBy, @Date)";

            //            using (SqlCommand command = new SqlCommand(query, connection))
            //            {
            //                command.Parameters.AddWithValue("@OriginalIngredient", originalIngredient);
            //                command.Parameters.AddWithValue("@SuggestedSubstitute", substitute);
            //                command.Parameters.AddWithValue("@Notes", notes);
            //                command.Parameters.AddWithValue("@CreatedBy", "YourName"); 
            //                command.Parameters.AddWithValue("@Date", DateTime.Now);

            //                command.ExecuteNonQuery();
            //            }
            //        }

            //        // **Fix: Use correct method name to refresh DataGridView**
            //        LoadDataFromDatabase();



            // ✅ Add row to DataTable for temporary display in DataGridView
            DataRow row = substitutionsTable.NewRow();
            row["Original Ingredient"] = originalIngredient;
            row["Suggested Substitute"] = substitute;
            row["Similarity Score"] = score;
            row["Date"] = "Approved"; // Initially "Approved", updates when clicked
            substitutionsTable.Rows.Add(row);




            //Clear input fields
                txtoriginal.Clear();
                txtsubstitute.Clear();
                txtscore.Clear();

               // Hide validation messages
               error1.Visible = false;
               error2.Visible = false;
            }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"⚠ Error saving to database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Date"].Index)
            {
                // ✅ Only update the date if the current value is "Approved"
                if (dataGridView1.Rows[e.RowIndex].Cells["Date"].Value.ToString() == "Approved")
                {
                    dataGridView1.Rows[e.RowIndex].Cells["Date"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                }
            }
        }

























        // searchng part

        // LIVE SEARCH: Filters the DataGridView as you type
        //private void txtsearchingredients_TextChanged(object sender, EventArgs e)
        //{
        //    string searchValue = txtsearchingredients.Text.Trim().Replace("'", "''"); // Escape single quotes for SQL

        //    if (dataGridView1.DataSource is DataTable dt)
        //    {
        //        DataView dv = dt.DefaultView;
        //        if (string.IsNullOrEmpty(searchValue) || searchValue == "search by ingredient…")
        //            dv.RowFilter = "";  // Clear filter
        //        else
        //            dv.RowFilter = $"[Original Ingredient] LIKE '%{searchValue}%'";
        //    }
        //}

















        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }






        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick2(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
          

        }









        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

