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
    public partial class Convert : Form
    {
        public Convert()
        {
            InitializeComponent();
        }

        // Main conversion process
        private void Convert_button_Click(object sender, EventArgs e)
        {
            // Detect "\deg" pattern
            textBox1.Text = textBox1.Text.Replace("\\deg", "°");

            // Verify if input is in one of the two formats
            if (!Main.Is_coordinate(textBox1.Text) && !Main.Is_numeric(textBox1.Text))
            {
                MessageBox.Show(Main.INVALID_USER_INPUT_ERROR, Main.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBox2.Text = "转换结果: ";

            // Invoke conversion method according to format deteted
            if (Main.Is_coordinate(textBox1.Text))
            {
                textBox2.Text += Main.DMS_to_decimal(textBox1.Text).ToString();
            }
            else
            {
                textBox2.Text += Main.Decimal_to_DMS(double.Parse(textBox1.Text));
            }
        }

        // Reset all input and output
        private void reset_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        // Reset result textbox if user input changed
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
