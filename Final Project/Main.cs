// Developed by Group 3
// 1951331 Zhou Lang

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
    public partial class Main : Form
    {
        // Constant global variables
        public const string INVALID_FILE_CONTENT_WARNING = "文件内容无法正确读取，请检查导入数据文件格式";
        public const string DATA_RESET_WARNING = "此操作可能会导致数据丢失，继续？";
        public const string DATA_OVERWRITE_WARNING = "此操作会覆盖现有数据，继续？";
        public const string INVALID_USER_INPUT_ERROR = "检测到非法数据";
        public const string INVALID_OUTPUT_PARAMETERS = "导出文件参数无效";
        public const string EXPORT_SUCCESS = "导出成功";
        public const string COPY_SUCCESS = "复制成功";
        public const string ERROR_CAPTION = "错误";
        public const string WARNING_CAPTION = "警告";
        public const string NOTIFICATION_CAPTION = "提示";

        // Global variables
        // Do not change
        public static int OUTPUT_PRECISION = 2;   // An int value indicating result output precision, ranges between [0, 14]
        public static bool DEGREE_FORMAT = true;  // A boolean value indicating degree format. true: DMS, false: decimal. Default as true
        public static string ERROR_EXTRA_INFO = ""; // String storing potential error info, default as empty

        public Main()
        {
            InitializeComponent();
        }

        // Import data from text file
        private void Import(System.IO.Stream file_stream)
        {
            string line;
            string[] data;

            using (System.IO.StreamReader reader = new System.IO.StreamReader(file_stream))
            {
                while ((line = reader.ReadLine()) != null)  // Omit empty lines
                {
                    // Omit empty lines
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }

                    data = line.Split(' ');

                    int index;

                    for (index = 0; index < data.Length; index++)
                    {
                        if (!Is_numeric(data[index]) && !Is_coordinate(data[index]))
                        {
                            if (index == 0 && data.Length == 3)
                            {
                                continue;   // No need to verify if unit is group marker
                            }

                            // Display a warning when values can't be interpreted properly
                            MessageBox.Show(INVALID_FILE_CONTENT_WARNING, ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    switch (data.Length)    // The group marker column is optional
                    {
                        // Add the values into dataGridView1
                        case 2:
                            dataGridView1.Rows.Add(null, data[0], data[1]);
                            break;

                        case 3:
                            dataGridView1.Rows.Add(data[0], data[1], data[2]);
                            break;

                        default:    // Display a warning when values can't be interpreted properly
                            MessageBox.Show(INVALID_FILE_CONTENT_WARNING, ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                }
            }
        }

        // Export existing data to text/csv file
        private void Export()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                string file_path = saveFileDialog1.FileName;
                string file_extension = System.IO.Path.GetExtension(file_path);

                if (file_extension == ".txt")
                {
                    using (System.IO.StreamWriter writer = new System.IO.StreamWriter(file_path))
                    {
                        foreach (DataGridViewRow r in dataGridView1.Rows)
                        {
                            // Omit empty row
                            if (r.IsNewRow)
                            {
                                continue;
                            }

                            // Generate output string for each row
                            string output = $"{r.Cells[0].Value} {r.Cells[1].Value} {r.Cells[2].Value} {r.Cells[3].Value} {r.Cells[4].Value} {r.Cells[5].Value}";
                            writer.WriteLine(output);   // Write output string as a single line to text file
                        }

                        // Write calculate results
                        writer.Write(textBox1.Text);
                    }
                }
                else
                {
                    if (file_extension == ".csv")
                    {
                        string[] output = new string[dataGridView1.Rows.Count];

                        // Generate header line
                        foreach (DataGridViewColumn c in dataGridView1.Columns)
                        {
                            output[0] += $"{c.HeaderText},";
                        }

                        // Fetch data from dataGridView1
                        for (int i = 1; i < dataGridView1.Rows.Count; i++)
                        {
                            // Omit empty row
                            if (dataGridView1.Rows[i - 1].IsNewRow)
                            {
                                continue;
                            }

                            foreach (DataGridViewCell c in dataGridView1.Rows[i - 1].Cells)
                            {
                                output[i] += $"{c.Value},";
                            }
                        }

                        // Write all lines to csv
                        System.IO.File.WriteAllLines(file_path, output, Encoding.UTF8);
                    }
                    else
                    {
                        MessageBox.Show(INVALID_OUTPUT_PARAMETERS, ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                // Show notification if export succeed
                MessageBox.Show(EXPORT_SUCCESS, NOTIFICATION_CAPTION);
            }
        }

        // Set error detail string
        public static void Error_detail(DataGridViewRow r)
        {
            ERROR_EXTRA_INFO = $"在第{r.Index + 1}行开始出现错误";
        }

        // Convert dd%mm%ss% coordinate string to a decimal value
        public static double DMS_to_decimal(string dms)
        {
            char[] coordinate_separators = { '°', '\'', '"' };
            string[] splitted = dms.Split(coordinate_separators);
            return double.Parse(splitted[0]) + double.Parse(splitted[1]) / 60 + double.Parse(splitted[2]) / 3600;
        }

        // Convert decimal value to coordinate string
        public static string Decimal_to_DMS(double number)
        {
            double sec = Math.Round(number * 3600);
            sec = Math.Abs(sec % 3600);
            int min = (int) sec / 60;
            sec %= 60;
            int deg = (int) Math.Floor(number);
            return $"{deg}°{min}'{sec}\"";
        }

        // Get decimal string with user-set precision and optional prefix
        public static string Get_modified_decimal(double number, int precision, bool prefix = true)
        {
            string symbol = prefix ? "+" : "";
            return number > 0 ? $"{symbol}{number.ToString($"F{precision}")}" : number.ToString($"F{precision}");
        }

        // Method to check if a given string is a integer
        private bool Is_integer(string input)
        {
            return int.TryParse(input, out _);
        }

        // Method to check if a given string is numeric (int, double, etc.)
        public static bool Is_numeric(string input)
        {
            return double.TryParse(input, out _);
        }

        // Method to check if a given string is dd%mm%ss% formatted coordinate string
        public static bool Is_coordinate(string input)
        {
            char[] coordinate_separators = { '°', '\'', '"' };
            string[] temp = input.Split(coordinate_separators);

            if (temp.Length != 4)
            {
                return false;
            }

            int index;

            // Judge if the coordinate consists of numbers only
            for (index = 0; index < 3; index++)
            {
                if (!Is_numeric(temp[index]))
                {
                    return false;
                }
            }

            // Judge if the coordinate symbols are in the right order
            if (input.IndexOf('°') > input.IndexOf('\'') || input.IndexOf('\'') > input.IndexOf('\"'))
            {
                return false;
            }

            return true;
        }

        // Overwrite Cells[2] in each row
        private void Row_overwrite(DataGridViewRow row, bool mode)
        {
            row.Cells[2].Value = mode ? DMS_to_decimal(row.Cells[2].Value.ToString()).ToString() : Decimal_to_DMS(double.Parse(row.Cells[2].Value.ToString()));
        }

        // Verify all cells in a row for empty or not-numeric value
        private bool Check_row_integrity(DataGridViewRow row)
        {
            // If a row contains empty cell, return false
            foreach (DataGridViewCell c in row.Cells)
            {
                // Rule out cells with no intended user-input
                if (c.ColumnIndex == 0 || c.ColumnIndex >= 3)
                {
                    continue;
                }
                
                // Return false if compulsory cell is empty
                if (c.Value == null)
                {
                    return false;
                }

                // Detect "\deg" pattern
                c.Value = c.Value.ToString().Replace("\\deg", "°");

                // Check by column index
                switch (c.ColumnIndex)
                {
                    case 1:
                        if (!Is_integer(c.Value.ToString()) || int.Parse(c.Value.ToString()) <= 0)
                        {
                            return false;
                        }
                        break;

                    case 2:
                        if (DEGREE_FORMAT)  // Apply mode-specific checking methods
                        {
                            if (!Is_coordinate(c.Value.ToString()))
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (!Is_numeric(c.Value.ToString()))
                            {
                                return false;
                            }
                        }
                        break;
                }
            }
            return true;
        }

        // Main calculation part
        private void Calculate(DataGridView dgd)
        {
            string output = "";     // String for display in textBox
            int survey_sum = 0;
            double degree_sum = 0;

            // Return error if input is insufficient for calculation
            if (dgd.Rows.Count <= 2)
            {
                MessageBox.Show(INVALID_USER_INPUT_ERROR, WARNING_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow r in dgd.Rows)
            {
                // Verify user input
                if (!r.IsNewRow && !Check_row_integrity(r))
                {
                    Error_detail(r);
                    MessageBox.Show($"{INVALID_USER_INPUT_ERROR} {ERROR_EXTRA_INFO}", WARNING_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Skip final row
                if (r.IsNewRow)
                {
                    continue;
                }

                // Collecting data
                double l = DEGREE_FORMAT ? DMS_to_decimal(r.Cells[2].Value.ToString()) : double.Parse(r.Cells[2].Value.ToString());

                survey_sum += int.Parse(r.Cells[1].Value.ToString());
                degree_sum += int.Parse(r.Cells[1].Value.ToString()) * l;
            }

            double weighed_arithmetic_mean = degree_sum / survey_sum;

            output += "x = " + (DEGREE_FORMAT ? Decimal_to_DMS(weighed_arithmetic_mean) : Get_modified_decimal(weighed_arithmetic_mean, OUTPUT_PRECISION)) + "\r\n";

            double temp_m_0 = 0;

            foreach (DataGridViewRow r in dgd.Rows)
            {
                if (r.IsNewRow)
                {
                    continue;
                }

                r.Cells[3].Value = r.Cells[1].Value.ToString();

                double p = int.Parse(r.Cells[1].Value.ToString());
                double l = DEGREE_FORMAT ? DMS_to_decimal(r.Cells[2].Value.ToString()) : double.Parse(r.Cells[2].Value.ToString());
                double v = 3600 * (weighed_arithmetic_mean - l);
                double pv = p * v;

                r.Cells[4].Value = Get_modified_decimal(v, precision: OUTPUT_PRECISION);
                r.Cells[5].Value = Get_modified_decimal(pv, precision: OUTPUT_PRECISION);

                temp_m_0 += p * v * v;
            }

            double m_0 = Math.Sqrt(temp_m_0 / (dgd.Rows.Count - 2));
            double m_x = m_0 / Math.Sqrt(survey_sum);
            output += $"m_0 = ±{Get_modified_decimal(m_0, precision: OUTPUT_PRECISION, prefix: false)}\"\r\n";
            output += $"m_x = ±{Get_modified_decimal(m_x, precision: OUTPUT_PRECISION, prefix: false)}\"\r\n";

            textBox1.Text = output;

        }

        // Reset all user input and program output
        private void Reset(DataGridView dgd, TextBox t)
        {
            dgd.Rows.Clear();
            t.Text = "";
        }

        // Load some elements when program starts
        private void Main_Load(object sender, EventArgs e)
        {
            // Initiate background color for none-input fields
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                if (c.Index >= 3)
                {
                    c.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }

            // Initiate column header format
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                c.HeaderCell.Style.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold);
            }

            // Initiate default radio button selection
            radioButton2.Checked = DEGREE_FORMAT;

        }

        // Import data event
        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Warn user of potential data loss
            if (MessageBox.Show(DATA_OVERWRITE_WARNING, WARNING_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            // Reset dataGridView
            Reset(dataGridView1, textBox1);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Import(openFileDialog1.OpenFile());
            }
        }

        // Quit application
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Trigger calculation when user clicks the button
        private void Calculate_button_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            Calculate(dataGridView1);
        }

        // Display a new form giving info of this program
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about_instance = new About();
            about_instance.ShowDialog();
        }

        // Display user manual window
        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Manual user_manual_instance = new User_Manual();
            user_manual_instance.ShowDialog();
        }

        // Reset user input when triggered
        private void Reset_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(DATA_RESET_WARNING, WARNING_CAPTION, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Reset(dataGridView1, textBox1);
            }
        }

        // Change cursor type to indicate none-input fields
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 3)
            {
                dataGridView1.Cursor = Cursors.No;
            }
        }

        // Reset cursor type to default if cursor leaves restricted fields
        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex <= 3 || e.ColumnIndex >= dataGridView1.Columns.Count - 1 || e.RowIndex >= dataGridView1.Rows.Count - 1)   // Notice that e.ColumnIndex returns the index of column the cursor just LEFT
            {
                dataGridView1.Cursor = Cursors.Default;
            }
        }

        // Change degree mode to DMS
        private void DMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DMSToolStripMenuItem.Checked = true;
            decimalToolStripMenuItem.Checked = false;

            radioButton2.Checked = true;

            DEGREE_FORMAT = true;   // Change format type

            // Try-catch to avoid unhandled exception in certain circumstances
            try
            {
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    // Skip final row
                    if (r.IsNewRow)
                    {
                        continue;
                    }

                    // Rewrite dataGridView in new format
                    Row_overwrite(r, false);
                }
            }
            catch
            { }
            
        }

        // Change degree mode to decimal
        private void DecimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimalToolStripMenuItem.Checked = true;
            DMSToolStripMenuItem.Checked = false;

            radioButton1.Checked = true;

            DEGREE_FORMAT = false;

            try
            {
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.IsNewRow)
                    {
                        continue;
                    }

                    Row_overwrite(r, true);
                }
            }
            catch
            { }
        }

        // Show precision setting form
        private void PrecisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Precision precision_instance = new Precision();
            precision_instance.Show();
        }

        // Export data when triggered
        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export();
        }

        // Show average calculation tool when clicked
        private void AverageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Average average_instance = new Average();
            average_instance.Show();
        }

        // Show convert tool when clicked
        private void ConvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Convert convert_instance = new Convert();
            convert_instance.Show();
        }

        // Show font picker when clicked
        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }


        // The following code trys to achieve a drag-drop to import file function
        // Not workable under Windows 10 environment
        // Drag-drop to import file
        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            // Get drag & drop file path
            string[] file_path = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Invoke Import() method to read file
            Import(System.IO.File.Open(file_path[0], System.IO.FileMode.Open));
        }

        // Change cursor when drag in
        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
        }

        // Change cursor when drag out
        private void Main_DragLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }
    }
}
