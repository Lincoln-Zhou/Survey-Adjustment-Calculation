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
    public partial class About : Form
    {
        const string content = "开发者\r\n\r\n1951331 周朗\r\n1953998 余江\r\n1954133孙豪\r\n1952057 白亨达\r\n\r\n\r\n\r\nCopyright 2020";

        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            // Load info string
            textBox1.Text = content;

            // Drop focus from textBox1
            label1.Select();
        }

        // Invoke system application to send email
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open email link
            System.Diagnostics.Process.Start("mailto:LincolnZh@protonmail.com");

            // Set link as visited
            linkLabel1.LinkVisited = true;
        }
    }
}
