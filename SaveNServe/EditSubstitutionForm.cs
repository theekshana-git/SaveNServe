using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveNServe
{
    public partial class EditSubstitutionForm : Form
    {
        public string UpdatedIngredient { get; private set; }
        public string UpdatedSubstitute { get; private set; }
        public string UpdatedScore { get; private set; }

        public EditSubstitutionForm(string ingredient, string substitute, string score)
        {
            InitializeComponent();
            txtIngredient.Text = ingredient;
            txtSubstitute.Text = substitute;
            txtScore.Text = score;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            UpdatedIngredient = txtIngredient.Text.Trim();
            UpdatedSubstitute = txtSubstitute.Text.Trim();
            UpdatedScore = txtScore.Text.Trim();

            // Reset error messages
            lblError1.Text = "";
            lblError2.Text = "";

            if (string.IsNullOrEmpty(UpdatedIngredient))
            {
                lblError1.Text = "Please enter an original ingredient";
                hasError = true;
            }

            if (string.IsNullOrEmpty(UpdatedSubstitute))
            {
                lblError2.Text = "Please enter a substitute";
                hasError = true;
            }

            if (hasError)
            {
                lblError1.Visible = true;
                lblError2.Visible = true;
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}
