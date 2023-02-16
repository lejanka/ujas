namespace zad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb1 = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb_min = new System.Windows.Forms.TextBox();
            this.tb_median = new System.Windows.Forms.TextBox();
            this.tb_max = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_zero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(12, 28);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(292, 23);
            this.tb1.TabIndex = 0;
            this.tb1.TextChanged += new System.EventHandler(this.te);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(87, 240);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(217, 47);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "Ready!";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(12, 85);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(292, 23);
            this.tb2.TabIndex = 2;
            this.tb2.TextChanged += new System.EventHandler(this.tb2_TextChanged);
            // 
            // tb_min
            // 
            this.tb_min.Location = new System.Drawing.Point(28, 181);
            this.tb_min.Name = "tb_min";
            this.tb_min.Size = new System.Drawing.Size(84, 23);
            this.tb_min.TabIndex = 3;
            // 
            // tb_median
            // 
            this.tb_median.Location = new System.Drawing.Point(170, 181);
            this.tb_median.Name = "tb_median";
            this.tb_median.Size = new System.Drawing.Size(84, 23);
            this.tb_median.TabIndex = 4;
            // 
            // tb_max
            // 
            this.tb_max.Location = new System.Drawing.Point(297, 181);
            this.tb_max.Name = "tb_max";
            this.tb_max.Size = new System.Drawing.Size(84, 23);
            this.tb_max.TabIndex = 5;
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(53, 164);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(28, 15);
            this.min.TabIndex = 6;
            this.min.Text = "min";
            this.min.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "median";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "max";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "sorted Array";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter Numbers";
            // 
            // tb_zero
            // 
            this.tb_zero.Location = new System.Drawing.Point(413, 181);
            this.tb_zero.Name = "tb_zero";
            this.tb_zero.Size = new System.Drawing.Size(73, 23);
            this.tb_zero.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "number of 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 341);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_zero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.min);
            this.Controls.Add(this.tb_max);
            this.Controls.Add(this.tb_median);
            this.Controls.Add(this.tb_min);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.tb1);
            this.Name = "Form1";
            this.Text = "Ujas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb1;
        private Button bt1;
        private TextBox tb2;
        private TextBox tb_min;
        private TextBox tb_median;
        private TextBox tb_max;
        private Label min;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_zero;
        private Label label5;
    }
}