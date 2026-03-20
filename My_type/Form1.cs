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

        // TODO: доделать Calculate()
        private void Calculate()
        {
            try
            {
                var firstRH = int.Parse(txtFirstRH.Text);
                var firstGS = int.Parse(txtFirstGS.Text);
                var firstBV = int.Parse(txtFirstBV.Text);

                dynamic firstColor;
                firstColor = AssignColor(cmbFirstType, firstRH, firstGS, firstBV);

                var secondRH = int.Parse(txtSecondRH.Text);
                var secondGS = int.Parse(txtSecondGS.Text);
                var secondBV = int.Parse(txtSecondBV.Text);

                dynamic secondColor;
                secondColor = AssignColor(cmbSecondType, secondBV, secondGS, secondRH);

                dynamic resultColor;
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
                        txtResultRH.Text = resultColor.hue.ToString();
                        txtResultGS.Text = resultColor.saturation.ToString();
                        txtResultBV.Text = resultColor.value.ToString();

                        var resultRGB = resultColor.ToRGB();
                        resultPanel.BackColor = Color.FromArgb(resultRGB.red, resultRGB.green, resultRGB.blue);
                        break;
                    case "RGB":
                        txtResultRH.Text = resultColor.red.ToString();
                        txtResultGS.Text = resultColor.green.ToString();
                        txtResultBV.Text = resultColor.blue.ToString();

                        resultPanel.BackColor = Color.FromArgb(resultColor.red, resultColor.green, resultColor.blue);
                        break;
                    default:
                        txtResultRH.Text = "0";
                        txtResultGS.Text = "0";
                        txtResultBV.Text = "0";
                        break;
                }
            }
            catch (Exception) { }
        }

        private void onValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
