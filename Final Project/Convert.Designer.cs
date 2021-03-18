
namespace Final_Project
{
    partial class Convert
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.convert_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8777F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入一个数值: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(509, 35);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // convert_button
            // 
            this.convert_button.Font = new System.Drawing.Font("Microsoft YaHei", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_button.Location = new System.Drawing.Point(84, 193);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(100, 40);
            this.convert_button.TabIndex = 5;
            this.convert_button.Text = "转换";
            this.convert_button.UseVisualStyleBackColor = true;
            this.convert_button.Click += new System.EventHandler(this.Convert_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Font = new System.Drawing.Font("Microsoft YaHei", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.Location = new System.Drawing.Point(350, 193);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(100, 40);
            this.reset_button.TabIndex = 6;
            this.reset_button.Text = "清零";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(19, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(509, 28);
            this.textBox2.TabIndex = 7;
            // 
            // Convert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 258);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.8777F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Convert";
            this.ShowIcon = false;
            this.Text = "角度换算工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button convert_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.TextBox textBox2;
    }
}