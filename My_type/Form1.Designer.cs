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
            cmbOperation = new ComboBox();
            cmbFirstType = new ComboBox();
            cmbSecondType = new ComboBox();
            cmbResultType = new ComboBox();
            txtSecondRH = new TextBox();
            txtSecondGS = new TextBox();
            txtSecondBV = new TextBox();
            txtResultRH = new TextBox();
            txtResultGS = new TextBox();
            txtResultBV = new TextBox();
            txtFirstBV = new TextBox();
            txtFirstGS = new TextBox();
            txtFirstRH = new TextBox();
            firstPanel = new Panel();
            secondPanel = new Panel();
            resultPanel = new Panel();
            SuspendLayout();
            // 
            // cmbOperation
            // 
            cmbOperation.FormattingEnabled = true;
            cmbOperation.Items.AddRange(new object[] { "+", "-" });
            cmbOperation.Location = new Point(13, 55);
            cmbOperation.Name = "cmbOperation";
            cmbOperation.Size = new Size(52, 28);
            cmbOperation.TabIndex = 6;
            cmbOperation.Text = "+";
            cmbOperation.SelectedIndexChanged += onValueChanged;
            // 
            // cmbFirstType
            // 
            cmbFirstType.FormattingEnabled = true;
            cmbFirstType.Items.AddRange(new object[] { "HSV", "RGB" });
            cmbFirstType.Location = new Point(205, 40);
            cmbFirstType.Name = "cmbFirstType";
            cmbFirstType.Size = new Size(56, 28);
            cmbFirstType.TabIndex = 10;
            cmbFirstType.Text = "HSV";
            cmbFirstType.SelectedIndexChanged += onValueChanged;
            // 
            // cmbSecondType
            // 
            cmbSecondType.FormattingEnabled = true;
            cmbSecondType.Items.AddRange(new object[] { "HSV", "RGB" });
            cmbSecondType.Location = new Point(205, 75);
            cmbSecondType.Name = "cmbSecondType";
            cmbSecondType.Size = new Size(56, 28);
            cmbSecondType.TabIndex = 11;
            cmbSecondType.Text = "HSV";
            cmbSecondType.SelectedIndexChanged += onValueChanged;
            // 
            // cmbResultType
            // 
            cmbResultType.FormattingEnabled = true;
            cmbResultType.Items.AddRange(new object[] { "HSV", "RGB" });
            cmbResultType.Location = new Point(205, 109);
            cmbResultType.Name = "cmbResultType";
            cmbResultType.Size = new Size(56, 28);
            cmbResultType.TabIndex = 15;
            cmbResultType.Text = "HSV";
            cmbResultType.SelectedIndexChanged += onValueChanged;
            // 
            // txtSecondRH
            // 
            txtSecondRH.Location = new Point(85, 73);
            txtSecondRH.Name = "txtSecondRH";
            txtSecondRH.Size = new Size(35, 27);
            txtSecondRH.TabIndex = 0;
            txtSecondRH.TextChanged += onValueChanged;
            // 
            // txtSecondGS
            // 
            txtSecondGS.Location = new Point(122, 73);
            txtSecondGS.Name = "txtSecondGS";
            txtSecondGS.Size = new Size(35, 27);
            txtSecondGS.TabIndex = 1;
            txtSecondGS.TextChanged += onValueChanged;
            // 
            // txtSecondBV
            // 
            txtSecondBV.Location = new Point(159, 73);
            txtSecondBV.Name = "txtSecondBV";
            txtSecondBV.Size = new Size(35, 27);
            txtSecondBV.TabIndex = 2;
            txtSecondBV.TextChanged += onValueChanged;
            // 
            // txtResultRH
            // 
            txtResultRH.Location = new Point(85, 108);
            txtResultRH.Name = "txtResultRH";
            txtResultRH.Size = new Size(35, 27);
            txtResultRH.TabIndex = 0;
            // 
            // txtResultGS
            // 
            txtResultGS.Location = new Point(122, 108);
            txtResultGS.Name = "txtResultGS";
            txtResultGS.Size = new Size(35, 27);
            txtResultGS.TabIndex = 1;
            // 
            // txtResultBV
            // 
            txtResultBV.Location = new Point(159, 108);
            txtResultBV.Name = "txtResultBV";
            txtResultBV.Size = new Size(35, 27);
            txtResultBV.TabIndex = 2;
            // 
            // txtFirstBV
            // 
            txtFirstBV.Location = new Point(159, 38);
            txtFirstBV.Name = "txtFirstBV";
            txtFirstBV.Size = new Size(35, 27);
            txtFirstBV.TabIndex = 2;
            txtFirstBV.TextChanged += onValueChanged;
            // 
            // txtFirstGS
            // 
            txtFirstGS.Location = new Point(122, 38);
            txtFirstGS.Name = "txtFirstGS";
            txtFirstGS.Size = new Size(35, 27);
            txtFirstGS.TabIndex = 1;
            txtFirstGS.TextChanged += onValueChanged;
            // 
            // txtFirstRH
            // 
            txtFirstRH.Location = new Point(85, 38);
            txtFirstRH.Name = "txtFirstRH";
            txtFirstRH.Size = new Size(35, 27);
            txtFirstRH.TabIndex = 0;
            txtFirstRH.TextChanged += onValueChanged;
            // 
            // firstPanel
            // 
            firstPanel.Location = new Point(267, 40);
            firstPanel.Name = "firstPanel";
            firstPanel.Size = new Size(28, 28);
            firstPanel.TabIndex = 16;
            // 
            // secondPanel
            // 
            secondPanel.Location = new Point(267, 74);
            secondPanel.Name = "secondPanel";
            secondPanel.Size = new Size(28, 28);
            secondPanel.TabIndex = 17;
            // 
            // resultPanel
            // 
            resultPanel.Location = new Point(267, 108);
            resultPanel.Name = "resultPanel";
            resultPanel.Size = new Size(28, 28);
            resultPanel.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 164);
            Controls.Add(resultPanel);
            Controls.Add(secondPanel);
            Controls.Add(firstPanel);
            Controls.Add(txtResultRH);
            Controls.Add(txtResultGS);
            Controls.Add(txtSecondRH);
            Controls.Add(txtResultBV);
            Controls.Add(txtSecondGS);
            Controls.Add(txtFirstRH);
            Controls.Add(txtSecondBV);
            Controls.Add(txtFirstGS);
            Controls.Add(txtFirstBV);
            Controls.Add(cmbResultType);
            Controls.Add(cmbSecondType);
            Controls.Add(cmbFirstType);
            Controls.Add(cmbOperation);
            Name = "Form1";
            Text = "ColorCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ComboBox cmbOperation;
        private ComboBox cmbFirstType;
        private ComboBox cmbSecondType;
        private ComboBox cmbResultType;
        private TextBox txtSecondRH;
        private TextBox txtSecondGS;
        private TextBox txtSecondBV;
        private TextBox txtResultRH;
        private TextBox txtResultGS;
        private TextBox txtResultBV;
        private TextBox txtFirstBV;
        private TextBox txtFirstGS;
        private TextBox txtFirstRH;
        private Panel firstPanel;
        private Panel secondPanel;
        private Panel resultPanel;
    }
}
