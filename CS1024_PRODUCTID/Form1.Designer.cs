namespace CS1024_PRODUCTID
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.filebindir = new System.Windows.Forms.TextBox();
            this.sdkdir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.freq = new System.Windows.Forms.TextBox();
            this.setupmac = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mac1 = new System.Windows.Forms.TextBox();
            this.mac2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mac3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bandrate = new System.Windows.Forms.TextBox();
            this.test = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setfreq = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.com = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择烧写文件目录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(516, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "选择SDK目录";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // filebindir
            // 
            this.filebindir.Location = new System.Drawing.Point(110, 32);
            this.filebindir.Name = "filebindir";
            this.filebindir.Size = new System.Drawing.Size(378, 21);
            this.filebindir.TabIndex = 1;
            this.filebindir.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sdkdir
            // 
            this.sdkdir.Location = new System.Drawing.Point(110, 63);
            this.sdkdir.Name = "sdkdir";
            this.sdkdir.Size = new System.Drawing.Size(378, 21);
            this.sdkdir.TabIndex = 1;
            this.sdkdir.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "烧写文件目录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "SDK目录";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(539, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "一键烧写";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 108);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(629, 238);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(431, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "清除日志";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "频偏设置：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // freq
            // 
            this.freq.Location = new System.Drawing.Point(20, 38);
            this.freq.Name = "freq";
            this.freq.Size = new System.Drawing.Size(111, 21);
            this.freq.TabIndex = 7;
            this.freq.TextChanged += new System.EventHandler(this.freq_TextChanged);
            // 
            // setupmac
            // 
            this.setupmac.Location = new System.Drawing.Point(56, 202);
            this.setupmac.Name = "setupmac";
            this.setupmac.Size = new System.Drawing.Size(75, 27);
            this.setupmac.TabIndex = 8;
            this.setupmac.Text = "设置";
            this.setupmac.UseVisualStyleBackColor = true;
            this.setupmac.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(677, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "MAC地址设置：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(677, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "0x";
            // 
            // mac1
            // 
            this.mac1.Location = new System.Drawing.Point(690, 134);
            this.mac1.MaxLength = 4;
            this.mac1.Name = "mac1";
            this.mac1.Size = new System.Drawing.Size(100, 21);
            this.mac1.TabIndex = 11;
            // 
            // mac2
            // 
            this.mac2.Location = new System.Drawing.Point(690, 161);
            this.mac2.MaxLength = 4;
            this.mac2.Name = "mac2";
            this.mac2.Size = new System.Drawing.Size(100, 21);
            this.mac2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(677, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "0x";
            // 
            // mac3
            // 
            this.mac3.Location = new System.Drawing.Point(690, 188);
            this.mac3.MaxLength = 4;
            this.mac3.Name = "mac3";
            this.mac3.Size = new System.Drawing.Size(100, 21);
            this.mac3.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(677, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "0x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "串口测试";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "波特率：";
            // 
            // bandrate
            // 
            this.bandrate.Location = new System.Drawing.Point(21, 79);
            this.bandrate.Name = "bandrate";
            this.bandrate.Size = new System.Drawing.Size(109, 21);
            this.bandrate.TabIndex = 18;
            this.bandrate.TextChanged += new System.EventHandler(this.bandrate_TextChanged);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(715, 368);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 27);
            this.test.TabIndex = 19;
            this.test.Text = "测试";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.setfreq);
            this.groupBox1.Controls.Add(this.setupmac);
            this.groupBox1.Controls.Add(this.freq);
            this.groupBox1.Location = new System.Drawing.Point(659, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 243);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // setfreq
            // 
            this.setfreq.Location = new System.Drawing.Point(56, 65);
            this.setfreq.Name = "setfreq";
            this.setfreq.Size = new System.Drawing.Size(75, 27);
            this.setfreq.TabIndex = 9;
            this.setfreq.Text = "设置";
            this.setfreq.UseVisualStyleBackColor = true;
            this.setfreq.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.com);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.bandrate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(658, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 141);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "测试";
            // 
            // com
            // 
            this.com.FormattingEnabled = true;
            this.com.Location = new System.Drawing.Point(57, 33);
            this.com.Name = "com";
            this.com.Size = new System.Drawing.Size(75, 20);
            this.com.TabIndex = 20;
            this.com.SelectedIndexChanged += new System.EventHandler(this.com_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "端口：";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 390);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "烧录";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 406);
            this.Controls.Add(this.test);
            this.Controls.Add(this.mac3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mac2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mac1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sdkdir);
            this.Controls.Add(this.filebindir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "CSR1024烧写工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox filebindir;
        private System.Windows.Forms.TextBox sdkdir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox freq;
        private System.Windows.Forms.Button setupmac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mac1;
        private System.Windows.Forms.TextBox mac2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mac3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bandrate;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button setfreq;
        private System.Windows.Forms.ComboBox com;
        private System.Windows.Forms.Label label10;
    }
}

