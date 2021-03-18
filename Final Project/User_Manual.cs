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
    public partial class User_Manual : Form
    {
        // User manual text strings
        private const string OVERVIEW = "本程序的主要目的是计算测量所得角度的加权平均值的其中误差。\r\n\r\n在测量工作中，误差分析是确保测量工作精确的重要步骤。在过往的测量学实验中，我们发现涉及到角度的误差计算常常较为棘手。主流计算器大多没有很好地支持度分秒制的相关复杂计算，而在涉及到角度的误差分析中，度分秒的计算和有关转换是相对而言较为重要的。为此我们编写优化了相关算法和程序来简化单位权中误差的计算。";
        private const string DATA_INPUT = "本程序主窗体中含有一个动态表格。其中，测回数和各组平均值必须输入，不得缺省，组号为选择性输入。\r\n\r\n本程序提供了两种输入模式，用户输入应与当前选择的输入模式相对应。\r\n\r\n度分秒输入：以dd°mm'ss\"的格式输入角度，其中°的输入也可以以字符串\\deg代替\r\n小数输入：输入整数或浮点数格式的角度\r\n\r\n输入完成检查无误后，点击计算按钮或快捷键Alt+C即可计算出结果，并显示在表格和文本框中。";
        private const string IMPORT_EXPORT = "本程序支持导入数据进行运算或将当前结果导出。\r\n\r\n导入文件格式为txt文本文档格式。文档的每一行应按顺序包含组号（可选）、测回数、各组平均值数据，每个数据之间以一个空格间隔。文件被正确导入后会显示内容在表格上，点击计算按钮即可开始计算。\r\n\r\n导出文件格式为txt文本文件或csv文件格式（可被Microsoft Excel、Numbers等电子表格程序读取），点击导出按钮选择文件路径和格式后即可导出。";
        private const string ERROR_HANDLING = "本程序会自动识别输入中的异常数据。如果计算时出现报错，程序会弹出窗口警告用户错误类型并在可能的情况下提示错误位置。\r\n\r\n若出现报错，请检查输入和角度格式的设置。";
        private const string AVERAGE_TOOL = "平均值计算程序支持用户输入/导入数字或角度格式的数据计算平均值，并支持不同角度格式。 \r\n\r\n导入数据的源文件须为txt格式，每个值占一行。导入完成后点击计算按钮即可。\r\n\r\n平均值计算出结果后会在新窗口显示，并可选择复制至剪切板。";
        private const string CONVERT_TOOL = "角度转换程序能够自动识别用户输入的格式并在度分秒制/小数制的角度表示中互相转换。\r\n\r\n输入数据的格式须为度分秒制和小数制中的一种。";
        private const string FORMAT = "使程序的计算模式在度分秒制和小数制间切换";
        private const string PRECISION = "设定程序输出结果的计算精度，默认为2，可在0~14间选择";
        private const string FONT = "设定程序输出结果文本框的字体和字号大小";

        public User_Manual()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index = int.Parse(treeView1.SelectedNode.Name.Remove(0, 4));

            int[] omitted_list = { 0, 2, 6, 9 };

            // Omit if current node is parental node
            if (omitted_list.Contains(index))
            {
                return;
            }

            // Set display text accordingly
            switch (index)
            {
                case 1:
                    textBox1.Text = OVERVIEW;
                    break;
                case 3:
                    textBox1.Text = DATA_INPUT;
                    break;
                case 4:
                    textBox1.Text = IMPORT_EXPORT;
                    break;
                case 5:
                    textBox1.Text = ERROR_HANDLING;
                    break;
                case 7:
                    textBox1.Text = AVERAGE_TOOL;
                    break;
                case 8:
                    textBox1.Text = CONVERT_TOOL;
                    break;
                case 10:
                    textBox1.Text = FORMAT;
                    break;
                case 11:
                    textBox1.Text = PRECISION;
                    break;
                case 12:
                    textBox1.Text = FONT;
                    break;
            }
        }

        // Set initial status
        private void User_Manual_Load(object sender, EventArgs e)
        {
            // Expand all first level nodes
            foreach (TreeNode t in treeView1.Nodes)
            {
                t.Expand();
            }

            // Select overview node
            treeView1.SelectedNode = treeView1.Nodes[0].Nodes[0];
        }
    }
}
