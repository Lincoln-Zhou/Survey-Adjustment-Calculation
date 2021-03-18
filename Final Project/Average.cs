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
    public partial class Average : Form
    {
        private string average; // Variable used to store calculation result
        private bool mode;  // Indicating current data format. true: numeric, false: DMS
        private bool calculation_succeed;  // Indicating whether the calculation process succeed

        public Average()
        {
            InitializeComponent();
        }

        // Import data method
        private void Import()
        {
            // Warn user of potential data loss
            if (MessageBox.Show(Main.DATA_OVERWRITE_WARNING, Main.WARNING_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            // Reset dataGridView
            dataGridView1.Rows.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var file_stream = openFileDialog1.OpenFile();

                string line;

                using (System.IO.StreamReader reader = new System.IO.StreamReader(file_stream))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Omit empty lines
                        if (string.IsNullOrWhiteSpace(line))
                        {
                            continue;
                        }

                        if (!Main.Is_coordinate(line) && !Main.Is_numeric(line))
                        {
                            MessageBox.Show(Main.INVALID_FILE_CONTENT_WARNING, Main.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        dataGridView1.Rows.Add(line);
                    }
                }
            }
        }

        // Verify if all cells are numeric string
        private bool Verify_numeric()
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (r.IsNewRow)
                {
                    continue;
                }

                if (!Main.Is_numeric(r.Cells[0].Value.ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        // Verify if all cells are DMS formatted string
        private bool Verify_DMS()
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (r.IsNewRow)
                {
                    continue;
                }

                if (r.Cells[0].Value == null)
                {
                    return false;
                }

                // Detect "\deg" pattern
                r.Cells[0].Value = r.Cells[0].Value.ToString().Replace("\\deg", "°");

                if (!Main.Is_coordinate(r.Cells[0].Value.ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        // Calculate average and assign result to average: string
        private void Calculate(bool mode)
        {
            double sum = 0;

            if (mode)
            {
                if (!Verify_numeric())
                {

                    MessageBox.Show(Main.INVALID_USER_INPUT_ERROR, Main.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.IsNewRow)
                    {
                        continue;
                    }

                    sum += double.Parse(r.Cells[0].Value.ToString());
                }

                average = (sum / (dataGridView1.Rows.Count - 1)).ToString();

                calculation_succeed = true;     // Change calculation status to success
            }
            else
            {
                if (!Verify_DMS())
                {
                    MessageBox.Show(Main.INVALID_USER_INPUT_ERROR, Main.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.IsNewRow)
                    {
                        continue;
                    }

                    sum += Main.DMS_to_decimal(r.Cells[0].Value.ToString());
                }

                average = Main.Decimal_to_DMS(sum / (dataGridView1.Rows.Count - 1));

                calculation_succeed = true;
            }
        }

        // Invoke calculation method
        private void button1_Click(object sender, EventArgs e)
        {
            // Set calculation status 
            calculation_succeed = false;

            // Get data format
            if (radioButton1.Checked)
            {
                mode = true;
            }
            else
            {
                mode = false;
            }

            Calculate(mode);

            // Pass value to Average_Result class if calculation completed successfully
            if (calculation_succeed)
            {
                Average_Result.result = average;

                // Show result window
                Average_Result average_result_instance = new Average_Result();
                average_result_instance.ShowDialog();
            }
        }

        // Reset user input
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        // Default format preference for average calculation tool is in accordance with the main program
        private void Average_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = Main.DEGREE_FORMAT;
        }

        // Invoke import method when clicked
        private void importToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Import();
        }
    }
}
