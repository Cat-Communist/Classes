namespace My_type
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            comboBox4 = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(31, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(31, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(153, 46);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(31, 27);
            textBox3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-" });
            comboBox1.Location = new Point(12, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(52, 28);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "+";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(153, 83);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(31, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(116, 83);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(31, 27);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(79, 83);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(31, 27);
            textBox6.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "HSV", "RGB" });
            comboBox2.Location = new Point(201, 48);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(56, 28);
            comboBox2.TabIndex = 10;
            comboBox2.Text = "HSV";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "HSV", "RGB" });
            comboBox3.Location = new Point(201, 83);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(56, 28);
            comboBox3.TabIndex = 11;
            comboBox3.Text = "HSV";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(153, 116);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(31, 27);
            textBox7.TabIndex = 14;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(116, 116);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(31, 27);
            textBox8.TabIndex = 13;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(79, 116);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(31, 27);
            textBox9.TabIndex = 12;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "HSV", "RGB" });
            comboBox4.Location = new Point(201, 115);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(56, 28);
            comboBox4.TabIndex = 15;
            comboBox4.Text = "HSV";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 237);
            Controls.Add(comboBox4);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox9);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private ComboBox comboBox4;
    }
}
