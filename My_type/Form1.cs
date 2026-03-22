using MyType;

namespace My_type
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            firstPanel.BackColor = Color.Black;
            secondPanel.BackColor = Color.Black;
            resultPanel.BackColor = Color.Black;
        }

        private dynamic AssignColor(ComboBox cmbType, int RH, int GS, int BV)
        {
            switch (cmbType.Text)
            {
                case "HSV":
                    return new HSV(RH, GS, BV);
                case "RGB":
                    return new RGB(RH, GS, BV);
                default:
                    return new HSV(RH, GS, BV);
            }
        }

        private void PaintPanel(ComboBox cmbType, Panel panel, dynamic color)
        {
            switch (cmbType.Text)
            {
                case "HSV":
                    var colorRGB = color.ToRGB();

                    panel.BackColor = Color.FromArgb(colorRGB.red, colorRGB.green, colorRGB.blue);
                    break;
                case "RGB":
                    panel.BackColor = Color.FromArgb(color.red, color.green, color.blue);
                    break;
                default:
                    panel.BackColor = Color.Black;
                    break;
            }
        }

        // TODO: доделать Calculate()
        private void Calculate()
        {
            int firstRH, firstGS, firstBV;
            dynamic firstColor;
            try
            {
                firstRH = int.Parse(txtFirstRH.Text);
                firstGS = int.Parse(txtFirstGS.Text);
                firstBV = int.Parse(txtFirstBV.Text);

                firstColor = AssignColor(cmbFirstType, firstRH, firstGS, firstBV);
                PaintPanel(cmbFirstType, firstPanel, firstColor);
            }
            catch
            {
                firstRH = firstGS = firstBV = 0;
                firstColor = AssignColor(cmbFirstType, firstRH, firstGS, firstBV);
            }

            int secondRH, secondGS, secondBV;
            dynamic secondColor;
            try
            {
                secondRH = int.Parse(txtSecondRH.Text);
                secondGS = int.Parse(txtSecondGS.Text);
                secondBV = int.Parse(txtSecondBV.Text);

                secondColor = AssignColor(cmbSecondType, secondRH, secondGS, secondBV);
                PaintPanel(cmbSecondType, secondPanel, secondColor);
            }
            catch
            {
                secondRH = secondGS = secondBV = 0;
                secondColor = AssignColor(cmbSecondType, secondRH, secondGS, secondBV);
            }

            dynamic resultColor;
            try
            {
                switch (cmbOperation.Text)
                {
                    case "+":
                        resultColor = firstColor + secondColor; break;
                    case "-":
                        resultColor = firstColor - secondColor; break;
                    default:
                        resultColor = new HSV(0, 0, 0); break;
                }

                switch (cmbResultType.Text)
                {
                    case "HSV":
                        if (resultColor is RGB) resultColor = resultColor.ToHSV();

                        txtResultRH.Text = resultColor.hue.ToString();
                        txtResultGS.Text = resultColor.saturation.ToString();
                        txtResultBV.Text = resultColor.value.ToString();
                        break;
                    case "RGB":
                        if (resultColor is HSV) resultColor = resultColor.ToRGB();
                        txtResultRH.Text = resultColor.red.ToString();
                        txtResultGS.Text = resultColor.green.ToString();
                        txtResultBV.Text = resultColor.blue.ToString();
                        break;
                    default:
                        txtResultRH.Text = "0";
                        txtResultGS.Text = "0";
                        txtResultBV.Text = "0";
                        break;
                }
                PaintPanel(cmbResultType, resultPanel, resultColor);
            }
            catch { }
        }

        private void onValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
