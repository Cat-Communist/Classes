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
            firstRH = new TextBox();
            firstGS = new TextBox();
            firstBV = new TextBox();
            comboBox1 = new ComboBox();
            secondBV = new TextBox();
            secondGS = new TextBox();
            secondR = new TextBox();
            cmbFirstType = new ComboBox();
            cmbSecondType = new ComboBox();
            resultBV = new TextBox();
            resultGS = new TextBox();
            resultRH = new TextBox();
            cmbResultType = new ComboBox();
            SuspendLayout();
            // 
            // firstRH
            // 
            firstRH.Location = new Point(80, 36);
            firstRH.Name = "firstRH";
            firstRH.Size = new Size(31, 27);
            firstRH.TabIndex = 0;
            // 
            // firstGS
            // 
            firstGS.Location = new Point(117, 36);
            firstGS.Name = "firstGS";
            firstGS.Size = new Size(31, 27);
            firstGS.TabIndex = 1;
            // 
            // firstBV
            // 
            firstBV.Location = new Point(154, 36);
            firstBV.Name = "firstBV";
            firstBV.Size = new Size(31, 27);
            firstBV.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-" });
            comboBox1.Location = new Point(13, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(52, 28);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "+";
            // 
            // secondBV
            // 
            secondBV.Location = new Point(154, 73);
            secondBV.Name = "secondBV";
            secondBV.Size = new Size(31, 27);
            secondBV.TabIndex = 9;
            // 
            // secondGS
            // 
            secondGS.Location = new Point(117, 73);
            secondGS.Name = "secondGS";
            secondGS.Size = new Size(31, 27);
            secondGS.TabIndex = 8;
            // 
            // secondR
            // 
            secondR.Location = new Point(80, 73);
            secondR.Name = "secondR";
            secondR.Size = new Size(31, 27);
            secondR.TabIndex = 7;
            // 
            // cmbFirstType
            // 
            cmbFirstType.FormattingEnabled = true;
            cmbFirstType.Items.AddRange(new object[] { "HSV", "RGB" });
            cmbFirstType.Location = new Point(202, 38);
            cmbFirstType.Name = "cmbFirstType";
            cmbFirstType.Size = new Size(56, 28);
            cmbFirstType.TabIndex = 10;
            cmbFirstType.Text = "HSV";
            // 
            // cmbSecondType
            // 
            cmbSecondType.FormattingEnabled = true;
            cmbSecondType.Items.AddRange(new object[] { "HSV", "RGB" });
            cmbSecondType.Location = new Point(202, 73);
            cmbSecondType.Name = "cmbSecondType";
            cmbSecondType.Size = new Size(56, 28);
            cmbSecondType.TabIndex = 11;
            cmbSecondType.Text = "HSV";
            // 
            // resultBV
            // 
            resultBV.Location = new Point(154, 108);
            resultBV.Name = "resultBV";
            resultBV.Size = new Size(31, 27);
            resultBV.TabIndex = 14;
            // 
            // resultGS
            // 
            resultGS.Location = new Point(117, 108);
            resultGS.Name = "resultGS";
            resultGS.Size = new Size(31, 27);
            resultGS.TabIndex = 13;
            // 
            // resultRH
            // 
            resultRH.Location = new Point(80, 108);
            resultRH.Name = "resultRH";
            resultRH.Size = new Size(31, 27);
            resultRH.TabIndex = 12;
            // 
            // cmbResultType
            // 
            cmbResultType.FormattingEnabled = true;
            cmbResultType.Items.AddRange(new object[] { "HSV", "RGB" });
            cmbResultType.Location = new Point(202, 107);
            cmbResultType.Name = "cmbResultType";
            cmbResultType.Size = new Size(56, 28);
            cmbResultType.TabIndex = 15;
            cmbResultType.Text = "HSV";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 164);
            Controls.Add(cmbResultType);
            Controls.Add(resultBV);
            Controls.Add(resultGS);
            Controls.Add(resultRH);
            Controls.Add(cmbSecondType);
            Controls.Add(cmbFirstType);
            Controls.Add(secondBV);
            Controls.Add(secondGS);
            Controls.Add(secondR);
            Controls.Add(comboBox1);
            Controls.Add(firstBV);
            Controls.Add(firstGS);
            Controls.Add(firstRH);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox firstRH;
        private TextBox firstGS;
        private TextBox firstBV;
        private ComboBox comboBox1;
        private TextBox secondBV;
        private TextBox secondGS;
        private TextBox secondR;
        private ComboBox cmbFirstType;
        private ComboBox cmbSecondType;
        private TextBox resultBV;
        private TextBox resultGS;
        private TextBox resultRH;
        private ComboBox cmbResultType;
    }
}
