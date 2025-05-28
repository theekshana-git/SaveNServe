using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;



namespace SaveNServe
{
    public partial class SubstitutionsControl : UserControl
    {
        


        public SubstitutionsControl()
        {


            InitializeComponent();


            searchBox.Enter += TxtSearchIngredient_Enter;
            searchBox.LostFocus += TxtSearchIngredient_Leave;
            dataGridView1.CellPainting += dgvSubs_CellPainting;


            dataGridView1.Columns["original"].Width = 160;
            dataGridView1.Columns["suggestion"].Width = 160;
            dataGridView1.Columns["score"].Width = 140;
            dataGridView1.Columns["colActions"].Width = 84;
            dataGridView1.Columns["colDelete"].Width = 84;

            dataGridView1.CellContentClick += dataGridView1_CellContentClick;



        }



        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

          

            dataGridView1.Visible = true;

            add_btn.Click += BtnAdd_Click;




        }













        // For the search box
        private void TxtSearchIngredient_Enter(object sender, EventArgs e)
        {

            if (searchBox.Text == "Search By Ingredient")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }

        private void TxtSearchIngredient_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                searchBox.Text = "Search By Ingredient";
                searchBox.ForeColor = Color.DimGray;
            }
        }


       

        private void dgvSubs_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                using (Pen pen = new Pen(Color.LightGray, 1))
                {
                    int y = e.CellBounds.Bottom - 1;
                    e.Graphics.DrawLine(pen, e.CellBounds.Left, y, e.CellBounds.Right, y);
                }

                e.Handled = true;
            }
        }













        // validation
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool hasError = false;

            string originalIngredient = txtoriginal.Text.Trim();
            string substitute = txtsubstitute.Text.Trim();
            string score = txtscore.Text.Trim();

            // Reset error messages
            error1.Text = "";
            error2.Text = "";

            if (string.IsNullOrEmpty(originalIngredient))
            {
                error1.Text = "Please enter an original ingredient";
                hasError = true;
            }

            if (string.IsNullOrEmpty(substitute))
            {
                error2.Text = "Please enter a substitute";
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

            // Add to DataGridView directly
            dataGridView1.Rows.Add(originalIngredient, substitute, score, "Delete", "Edit");

            // Clear input fields
            txtoriginal.Clear();
            txtsubstitute.Clear();
            txtscore.Clear();

            // Hide error messages
            error1.Visible = false;
            error2.Visible = false;
        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "colActions")
                {
                    string ing = dataGridView1.Rows[e.RowIndex].Cells["original"].Value.ToString();
                    string sub = dataGridView1.Rows[e.RowIndex].Cells["suggestion"].Value.ToString();
                    string score = dataGridView1.Rows[e.RowIndex].Cells["score"].Value.ToString();

                    EditSubstitutionForm editForm = new EditSubstitutionForm(ing, sub, score);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["original"].Value = editForm.UpdatedIngredient;
                        dataGridView1.Rows[e.RowIndex].Cells["suggestion"].Value = editForm.UpdatedSubstitute;
                        dataGridView1.Rows[e.RowIndex].Cells["score"].Value = editForm.UpdatedScore;
                    }
                }
                else if (columnName == "colDelete")
                {
                    DialogResult result = MessageBox.Show("Delete this substitution?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            txtoriginal.Clear();
            txtsubstitute.Clear();
            txtscore.Clear();

        }
    }
}

