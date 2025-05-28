using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveNServe
{
    public partial class DashboardControl : UserControl
    {
        public event EventHandler HistoryIconClicked;
        public DashboardControl()
        {
            InitializeComponent();
            pictureBox1.Click += PictureBox1_Click;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            HistoryIconClicked?.Invoke(this, EventArgs.Empty);
        }

    }
}




