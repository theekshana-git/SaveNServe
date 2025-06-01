using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;




namespace SaveNServe
{
    public partial class SubstitutionsControl : UserControl
    {

        private string currentUser;

        public SubstitutionsControl(string username)
        {


            InitializeComponent();
            currentUser = username;

            searchBox.Enter += TxtSearchIngredient_Enter;
            searchBox.LostFocus += TxtSearchIngredient_Leave;
            dataGridView1.CellPainting += dgvSubs_CellPainting;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            searchBox.KeyDown += SearchBox_KeyDown;
            add_btn.Click += BtnAdd_Click;
            Clearbtn.Click += Clearbtn_Click;

            dataGridView1.Columns["original"].Width = 160;
            dataGridView1.Columns["suggestion"].Width = 160;
            dataGridView1.Columns["score"].Width = 140;
            dataGridView1.Columns["colActions"].Width = 84;
            dataGridView1.Columns["colDelete"].Width = 84;

            LoadSubstitutions();

        }

        private void LoadSubstitutions()
        {
            string query = @"
        SELECT 
            i1.Name AS Ingredient, 
            i2.Name AS Substitute, 
            s.SimilarityScore
        FROM Substitutions s
        INNER JOIN Ingredients i1 ON s.IngredientID = i1.IngredientID
        INNER JOIN Ingredients i2 ON s.SubstituteID = i2.IngredientID
        ORDER BY s.CreatedDate DESC";

            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dataGridView1.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    string original = row["Ingredient"].ToString();
                    string substitute = row["Substitute"].ToString();
                    string score = row["SimilarityScore"].ToString();

                    dataGridView1.Rows.Add(original, substitute, score, "Delete", "Edit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading substitutions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            // Validate ingredients exist and get their IDs
            int originalId = GetIngredientIdByName(originalIngredient);
            int substituteId = GetIngredientIdByName(substitute);

            if (originalId == -1 || substituteId == -1)
            {
                MessageBox.Show("Both ingredients must exist in the ingredients table.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert into Substitutions using foreign keys
            string insertQuery = @"
        INSERT INTO Substitutions 
        (IngredientID, SubstituteID, SimilarityScore, CreatedBy, CreatedDate) 
        VALUES (@OriginalID, @SubstituteID, @Score, @CreatedBy, @DateCreated)";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@OriginalID", originalId),
        new SqlParameter("@SubstituteID", substituteId),
        new SqlParameter("@Score", score),
        new SqlParameter("@CreatedBy", currentUser),
        new SqlParameter("@DateCreated", DateTime.Now)
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);
                LoadSubstitutions();

                txtoriginal.Clear();
                txtsubstitute.Clear();
                txtscore.Clear();

                error1.Visible = false;
                error2.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding substitution: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetIngredientIdByName(string name)
        {
            string query = "SELECT IngredientID FROM Ingredients WHERE Name = @Name";
            SqlParameter param = new SqlParameter("@Name", name);

            DataTable dt = DatabaseHelper.ExecuteQuery(query, param);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["IngredientID"]);
            }
            return -1; // Not found
        }






        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                string originalName = dataGridView1.Rows[e.RowIndex].Cells["original"].Value.ToString();
                string substituteName = dataGridView1.Rows[e.RowIndex].Cells["suggestion"].Value.ToString();

                int originalId = GetIngredientIdByName(originalName);
                int substituteId = GetIngredientIdByName(substituteName);

                if (originalId == -1 || substituteId == -1)
                {
                    MessageBox.Show("Ingredient IDs not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (columnName == "colActions")
                {
                    string score = dataGridView1.Rows[e.RowIndex].Cells["score"].Value.ToString();
                    string buttonText = dataGridView1.Rows[e.RowIndex].Cells["colActions"].Value.ToString();

                    if (buttonText == "Approve")
                    {
                        DialogResult confirm = MessageBox.Show("Add this system-generated suggestion to the database?", "Approve Suggestion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirm == DialogResult.Yes)
                        {
                            string insertQuery = @"
                        INSERT INTO Substitutions 
                        (IngredientID, SubstituteID, SimilarityScore, CreatedBy, CreatedDate) 
                        VALUES (@OriginalID, @SubstituteID, @Score, @CreatedBy, @DateCreated)";

                            SqlParameter[] parameters = new SqlParameter[]
                            {
                        new SqlParameter("@OriginalID", originalId),
                        new SqlParameter("@SubstituteID", substituteId),
                        new SqlParameter("@Score", score),
                        new SqlParameter("@CreatedBy", currentUser), 
                        new SqlParameter("@DateCreated", DateTime.Now)
                            };

                            try
                            {
                                DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);
                                LoadSubstitutions();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error approving suggestion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        EditSubstitutionForm editForm = new EditSubstitutionForm(originalName, substituteName, score);
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            int newOriginalId = GetIngredientIdByName(editForm.UpdatedIngredient);
                            int newSubstituteId = GetIngredientIdByName(editForm.UpdatedSubstitute);

                            if (newOriginalId == -1 || newSubstituteId == -1)
                            {
                                MessageBox.Show("Updated ingredients not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string updateQuery = @"
                        UPDATE Substitutions 
                        SET IngredientID = @NewOriginalID, SubstituteID = @NewSubstituteID, SimilarityScore = @Score 
                        WHERE IngredientID = @OldOriginalID AND SubstituteID = @OldSubstituteID";

                            SqlParameter[] parameters = new SqlParameter[]
                            {
                        new SqlParameter("@NewOriginalID", newOriginalId),
                        new SqlParameter("@NewSubstituteID", newSubstituteId),
                        new SqlParameter("@Score", editForm.UpdatedScore),
                        new SqlParameter("@OldOriginalID", originalId),
                        new SqlParameter("@OldSubstituteID", substituteId)
                            };

                            try
                            {
                                DatabaseHelper.ExecuteNonQuery(updateQuery, parameters);
                                LoadSubstitutions();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error updating substitution: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else if (columnName == "colDelete")
                {
                    DialogResult result = MessageBox.Show("Delete this substitution?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string deleteQuery = "DELETE FROM Substitutions WHERE IngredientID = @OriginalID AND SubstituteID = @SubstituteID";

                        SqlParameter[] parameters = new SqlParameter[]
                        {
                    new SqlParameter("@OriginalID", originalId),
                    new SqlParameter("@SubstituteID", substituteId)
                        };

                        try
                        {
                            DatabaseHelper.ExecuteNonQuery(deleteQuery, parameters);
                            LoadSubstitutions();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting substitution: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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



        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchText = searchBox.Text.Trim();

                if (string.IsNullOrEmpty(searchText) || searchText == "Search By Ingredient")
                {
                    LoadSubstitutions();
                    return;
                }

                try
                {
                    string query = @"
                SELECT 
                    s.SubstitutionID,
                    i1.Name AS OriginalName,
                    i2.Name AS SubstituteName,
                    s.SimilarityScore
                FROM 
                    Substitutions s
                JOIN Ingredients i1 ON s.IngredientID = i1.IngredientID
                JOIN Ingredients i2 ON s.SubstituteID = i2.IngredientID
                WHERE 
                    i1.Name LIKE @Search";

                    SqlParameter param = new SqlParameter("@Search", "%" + searchText + "%");
                    DataTable dt = DatabaseHelper.ExecuteQuery(query, param);

                    dataGridView1.Rows.Clear();

                    if (dt == null || dt.Rows.Count == 0)
                    {
                        int searchedId = GetIngredientIdByName(searchText);
                        if (searchedId == -1)
                        {
                            MessageBox.Show("No results found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // Ingredient exists, do similarity logic
                        DataRow ingredient = DatabaseHelper.ExecuteQuery("SELECT * FROM Ingredients WHERE IngredientID = @ID", new SqlParameter("@ID", searchedId)).Rows[0];
                        string taste = ingredient["Taste"].ToString();
                        string texture = ingredient["Texture"].ToString();
                        string nutrition = ingredient["NutritionalInfo"].ToString();

                        string fetchOthersQuery = "SELECT * FROM Ingredients WHERE IngredientID != @ID";
                        DataTable otherIngredients = DatabaseHelper.ExecuteQuery(fetchOthersQuery, new SqlParameter("@ID", searchedId));

                        // Temporary list to store auto suggestions with their similarity score
                        List<(string Substitute, double Score)> autoSuggestions = new List<(string, double)>();

                        foreach (DataRow row in otherIngredients.Rows)
                        {
                            int score = 0;
                            if (row["Taste"].ToString() == taste) score++;
                            if (row["Texture"].ToString() == texture) score++;
                            if (row["NutritionalInfo"].ToString() == nutrition) score++;

                            double similarityScore = 0;
                            if (score == 1) similarityScore = 2.5;
                            else if (score == 2) similarityScore = 3.5;
                            else if (score == 3) similarityScore = 6.0;

                            if (similarityScore > 0)
                            {
                                autoSuggestions.Add((row["Name"].ToString(), similarityScore));
                            }
                        }

                        // Sort by similarity score descending
                        autoSuggestions = autoSuggestions.OrderByDescending(x => x.Score).ToList();

                        // Now add to the DataGridView
                        foreach (var suggestion in autoSuggestions)
                        {
                            dataGridView1.Rows.Add(searchText, suggestion.Substitute, suggestion.Score.ToString(), "", "Approve");

                            int lastRowIndex = dataGridView1.Rows.Count - 1;
                            if (lastRowIndex >= 0)
                            {
                                dataGridView1.Rows[lastRowIndex].Cells["colDelete"].ReadOnly = true;
                                dataGridView1.Rows[lastRowIndex].Cells["colDelete"].Style.ForeColor = Color.Gray;
                            }
                        }


                        if (dataGridView1.Rows.Count == 0)
                        {
                            MessageBox.Show("No automatic substitutes found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Automatic suggestions found. Click 'Approve' to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        return;
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        string original = row["OriginalName"].ToString();
                        string substitute = row["SubstituteName"].ToString();
                        string score = row["SimilarityScore"].ToString();

                        dataGridView1.Rows.Add(original, substitute, score, "Delete", "Edit");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error executing search: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

    }
}

