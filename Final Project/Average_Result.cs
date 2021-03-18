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
    public partial class Average_Result : Form
    {
        public static string result;

        public Average_Result()
        {
            InitializeComponent();
        }

        // Close window if user click confirm button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Load average result into form during form initialization
        private void Average_Result_Load(object sender, EventArgs e)
        {
            label2.Text = result;
        }

        // Copy average result to clipboard
        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(result);
            MessageBox.Show(Main.COPY_SUCCESS, Main.NOTIFICATION_CAPTION);  // Show notification when completed
        }
    }
}
