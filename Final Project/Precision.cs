using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Precision : Form
    {
        public Precision()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.OUTPUT_PRECISION = int.Parse(numericUpDown1.Value.ToString());     // Set relating variable in Main.cs
            this.Close();   // Close window after user confirmation
        }

        // Set default value according to previous setting
        private void Precision_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = Main.OUTPUT_PRECISION;
        }
    }
}
