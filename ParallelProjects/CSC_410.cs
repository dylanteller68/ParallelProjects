using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelProjects
{
    public partial class CSC_410 : Form
    {
        public CSC_410()
        {
            InitializeComponent();
        }

        private void mat_mul_button_Click(object sender, EventArgs e)
        {
            // run matrix multiplication program
            mat_mul_textbox.Text = "Lots of data processed";
        }

        private void seed_finder_button_Click(object sender, EventArgs e)
        {
            // run seed finder program
            seed_finder_textbox.Text = "Lot of data processed";
        }
    }
}
