
namespace Final_Project
{
    partial class User_Manual
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
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("简介");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("数据输入");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("数据导入和导出");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("异常处理");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("主界面", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("平均值计算实用工具");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("角度格式换算工具");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("实用工具", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("角度格式设置");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("计算精度设置");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("字体设置");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("偏好设置", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("用户手册", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode18,
            treeNode21,
            treeNode25});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Control;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.805756F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode14.Name = "Node1";
            treeNode14.Text = "简介";
            treeNode15.Name = "Node3";
            treeNode15.Text = "数据输入";
            treeNode16.Name = "Node4";
            treeNode16.Text = "数据导入和导出";
            treeNode17.Name = "Node5";
            treeNode17.Text = "异常处理";
            treeNode18.Name = "Node2";
            treeNode18.Text = "主界面";
            treeNode19.Name = "Node7";
            treeNode19.Text = "平均值计算实用工具";
            treeNode20.Name = "Node8";
            treeNode20.Text = "角度格式换算工具";
            treeNode21.Name = "Node6";
            treeNode21.Text = "实用工具";
            treeNode22.Name = "Node10";
            treeNode22.Text = "角度格式设置";
            treeNode23.Name = "Node11";
            treeNode23.Text = "计算精度设置";
            treeNode24.Name = "Node12";
            treeNode24.Text = "字体设置";
            treeNode25.Name = "Node9";
            treeNode25.Text = "偏好设置";
            treeNode26.Name = "Node0";
            treeNode26.Text = "用户手册";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26});
            this.treeView1.Size = new System.Drawing.Size(232, 335);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(270, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(352, 335);
            this.textBox1.TabIndex = 3;
            // 
            // User_Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 359);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8777F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User_Manual";
            this.ShowIcon = false;
            this.Text = "用户手册";
            this.Load += new System.EventHandler(this.User_Manual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}