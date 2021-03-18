namespace Final_Project
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.precisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.group_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.survey_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adjustment_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_times_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculate_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "Text files|*.txt|CSV files|*.csv";
            this.openFileDialog1.Title = "选择要导入的数据文件";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "exported";
            this.saveFileDialog1.Filter = "Text files|*.txt|csv files|*.csv";
            this.saveFileDialog1.Title = "选择数据文件导出路径";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.805756F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(23, 23);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(757, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.805756F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.importToolStripMenuItem.Text = "导入";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.ImportToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.exportToolStripMenuItem.Text = "导出";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.quitToolStripMenuItem.Text = "退出程序";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculationToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.operationsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.805756F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.operationsToolStripMenuItem.Text = "操作";
            // 
            // calculationToolStripMenuItem
            // 
            this.calculationToolStripMenuItem.Name = "calculationToolStripMenuItem";
            this.calculationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.calculationToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.calculationToolStripMenuItem.Text = "计算";
            this.calculationToolStripMenuItem.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.resetToolStripMenuItem.Text = "清零";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilitiesToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.modeToolStripMenuItem.Text = "选项";
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageToolStripMenuItem,
            this.convertToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.805756F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(179, 32);
            this.utilitiesToolStripMenuItem.Text = "实用工具";
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(352, 32);
            this.averageToolStripMenuItem.Text = "平均值计算工具";
            this.averageToolStripMenuItem.Click += new System.EventHandler(this.AverageToolStripMenuItem_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(352, 32);
            this.convertToolStripMenuItem.Text = "角度换算工具";
            this.convertToolStripMenuItem.Click += new System.EventHandler(this.ConvertToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatToolStripMenuItem,
            this.precisionToolStripMenuItem,
            this.pageSetupToolStripMenuItem});
            this.preferencesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.805756F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(179, 32);
            this.preferencesToolStripMenuItem.Text = "偏好设置";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DMSToolStripMenuItem,
            this.decimalToolStripMenuItem});
            this.formatToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.805756F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.formatToolStripMenuItem.Text = "角度格式";
            // 
            // DMSToolStripMenuItem
            // 
            this.DMSToolStripMenuItem.Checked = true;
            this.DMSToolStripMenuItem.CheckOnClick = true;
            this.DMSToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DMSToolStripMenuItem.Name = "DMSToolStripMenuItem";
            this.DMSToolStripMenuItem.Size = new System.Drawing.Size(161, 32);
            this.DMSToolStripMenuItem.Text = "度分秒";
            this.DMSToolStripMenuItem.Click += new System.EventHandler(this.DMSToolStripMenuItem_Click);
            // 
            // decimalToolStripMenuItem
            // 
            this.decimalToolStripMenuItem.Name = "decimalToolStripMenuItem";
            this.decimalToolStripMenuItem.Size = new System.Drawing.Size(161, 32);
            this.decimalToolStripMenuItem.Text = "小数";
            this.decimalToolStripMenuItem.Click += new System.EventHandler(this.DecimalToolStripMenuItem_Click);
            // 
            // precisionToolStripMenuItem
            // 
            this.precisionToolStripMenuItem.Name = "precisionToolStripMenuItem";
            this.precisionToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.precisionToolStripMenuItem.Text = "计算结果精度";
            this.precisionToolStripMenuItem.Click += new System.EventHandler(this.PrecisionToolStripMenuItem_Click);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(215, 32);
            this.pageSetupToolStripMenuItem.Text = "页面设置";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(143, 32);
            this.fontToolStripMenuItem.Text = "字体";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.userManualToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.805756F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.helpToolStripMenuItem.Text = "帮助";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.aboutToolStripMenuItem.Text = "关于此程序";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.userManualToolStripMenuItem.Text = "用户手册";
            this.userManualToolStripMenuItem.Click += new System.EventHandler(this.userManualToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 10.8777F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 495);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(757, 229);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.group_number,
            this.survey_count,
            this.group_average,
            this.weight,
            this.adjustment_v,
            this.p_times_v});
            this.dataGridView1.Location = new System.Drawing.Point(0, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 59;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 374);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            // 
            // group_number
            // 
            this.group_number.HeaderText = "组号";
            this.group_number.MinimumWidth = 7;
            this.group_number.Name = "group_number";
            this.group_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.group_number.Width = 120;
            // 
            // survey_count
            // 
            this.survey_count.HeaderText = "测回数";
            this.survey_count.MinimumWidth = 7;
            this.survey_count.Name = "survey_count";
            this.survey_count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.survey_count.Width = 145;
            // 
            // group_average
            // 
            this.group_average.HeaderText = "各组平均值";
            this.group_average.MinimumWidth = 7;
            this.group_average.Name = "group_average";
            this.group_average.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.group_average.Width = 150;
            // 
            // weight
            // 
            this.weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.weight.HeaderText = "权P";
            this.weight.MinimumWidth = 7;
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            this.weight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.weight.Width = 120;
            // 
            // adjustment_v
            // 
            this.adjustment_v.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.adjustment_v.HeaderText = "改正值v/(\'\')";
            this.adjustment_v.MinimumWidth = 7;
            this.adjustment_v.Name = "adjustment_v";
            this.adjustment_v.ReadOnly = true;
            this.adjustment_v.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.adjustment_v.Width = 132;
            // 
            // p_times_v
            // 
            this.p_times_v.HeaderText = "Pv/(\'\')";
            this.p_times_v.MinimumWidth = 7;
            this.p_times_v.Name = "p_times_v";
            this.p_times_v.ReadOnly = true;
            this.p_times_v.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.p_times_v.Width = 121;
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(12, 425);
            this.calculate_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(100, 50);
            this.calculate_button.TabIndex = 3;
            this.calculate_button.Text = "计算";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(194, 425);
            this.reset_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(100, 50);
            this.reset_button.TabIndex = 4;
            this.reset_button.Text = "清零";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.805756F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(436, 415);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(309, 70);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "角度格式";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(175, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 28);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "度分秒制";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.DMSToolStripMenuItem_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "小数制";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.DecimalToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 724);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8777F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "单位权中误差计算程序";
            this.Load += new System.EventHandler(this.Main_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            this.DragLeave += new System.EventHandler(this.Main_DragLeave);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem precisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn survey_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_average;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn adjustment_v;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_times_v;
    }
}

