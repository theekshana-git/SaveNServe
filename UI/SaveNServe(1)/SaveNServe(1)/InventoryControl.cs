using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Permissions;

namespace SaveNServe_1_
{
    public partial class InventoryControl : UserControl
    {
        public InventoryControl()
        {
            InitializeComponent();
        }
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search ingredients...")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                searchBox.Text = "Search ingredients...";
                searchBox.ForeColor = Color.White;
            }
        }
        private void InventoryControl_Load(object sender, EventArgs e)
        {
            searchBox.Text = "Search ingredients...";
            searchBox.ForeColor = Color.White;

            searchBox.GotFocus += RemovePlaceholder;
            searchBox.LostFocus += SetPlaceholder;

            searchBox.TextChanged += searchbox_TextChanged;

            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("IngredientName", "Ingredient Name");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Unit", "Unit");
            dataGridView1.Columns.Add("ExpirationDate", "Expiration Date");
            dataGridView1.Columns.Add("Status", "Status");

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.Name = "Edit";
            editButton.HeaderText = "Actions";
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(editButton);

            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Rows.Add("Milk", "2", "L", "2025-06-15", "OK");
            dataGridView1.Rows.Add("Eggs", "12", "pcs", "2025-06-01", "Expired");
            dataGridView1.Rows.Add("Sugar", "10", "Kg", "2026-01-01", "Low");

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string status = dataGridView1.Rows[i].Cells[4].Value?.ToString();

                switch (status)
                {
                    case "OK":
                        dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.MediumSeaGreen;
                        break;
                    case "Expired":
                        dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.FromArgb(217, 83, 79);
                        break;
                    case "Low":
                        dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.FromArgb(244, 185, 66);
                        break;
                }
            }


        }

        private void Titele_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butinfo_Click(object sender, EventArgs e)
        {

            string infor = "“This tab manages the available quantity and shelf life of ingredients. To add new ingredients, use the Add Ingredients tab.”";
            info.Text = infor;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            string filterText = searchBox.Text.ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string ingredient = row.Cells["IngredientName"].Value?.ToString().ToLower() ?? "";

                row.Visible = ingredient.Contains(filterText);
            }
        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string currentQuantity = row.Cells["Quantity"].Value?.ToString() ?? "";
                string currentDate = row.Cells["ExpirationDate"].Value?.ToString() ?? "";

                string inputQuantity = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter new quantity:", "Edit Quantity", currentQuantity);

                DateTimePicker datePicker = new DateTimePicker();
                if (DateTime.TryParse(currentDate, out DateTime dt)) datePicker.Value = dt;

                Form prompt = new Form();
                Button ok = new Button() { Text = "OK", DialogResult = DialogResult.OK, Dock = DockStyle.Bottom };
                datePicker.Dock = DockStyle.Fill;
                prompt.Controls.Add(datePicker);
                prompt.Controls.Add(ok);
                prompt.AcceptButton = ok;
                prompt.StartPosition = FormStartPosition.CenterScreen;

                string inputDate = "";
                if (prompt.ShowDialog() == DialogResult.OK)
                    inputDate = datePicker.Value.ToString("yyyy-MM-dd");

                if (!string.IsNullOrWhiteSpace(inputQuantity) && !string.IsNullOrWhiteSpace(inputDate))
                {
                    if (DateTime.TryParse(inputDate, out DateTime parsedDate))
                    {
                        row.Cells["Quantity"].Value = inputQuantity;
                        row.Cells["ExpirationDate"].Value = parsedDate.ToShortDateString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid date.", "Error");
                    }
                }
            }
        }

        bool exapned = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (exapned == false)
            {

                dropdown.Height += 15;
                if (dropdown.Height >= dropdown.MaximumSize.Height)
                {
                    timer2.Stop();
                    exapned = true;

                }
            }
            else
            {

                dropdown.Height -= 15;
                if (dropdown.Height <= dropdown.MinimumSize.Height)
                {
                    timer2.Stop();
                    exapned = false;
                }
            }
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }


    }

}
