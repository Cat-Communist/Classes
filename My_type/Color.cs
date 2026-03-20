using System.Configuration;
using System.Windows.Forms;

namespace MyType
{
    public class RGB
    {
        public int red;
        public int green;
        public int blue;

        public RGB(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public static RGB operator +(RGB left, RGB right)
        {
            var newRed = left.red + right.red;
            var newGreen = left.green + right.green;
            var newBlue = left.blue + right.blue;

            return new RGB(newRed, newGreen, newBlue);
        }

        public static RGB operator -(RGB left, RGB right)
        {
            var newRed = left.red - right.red;
            var newGreen = left.green - right.green;
            var newBlue = left.blue - right.blue;

            return new RGB(newRed, newGreen, newBlue);
        }

        public static RGB operator +(RGB left, HSV right)
        {
            var rightRGB = right.ToRGB();

            var newRed = left.red + rightRGB.red;
            var newGreen = left.green + rightRGB.green;
            var newBlue = left.blue + rightRGB.blue;

            return new RGB(newRed, newGreen, newBlue);
        }

        public static RGB operator -(RGB left, HSV right)
        {
            var rightRGB = right.ToRGB();

            var newRed = left.red - rightRGB.red;
            var newGreen = left.green - rightRGB.green;
            var newBlue = left.blue - rightRGB.blue;

            return new RGB(newRed, newGreen, newBlue);
        }

        public HSV ToHSV()
        {
            double redNorm = this.red / 255.0;
            double greenNorm = this.green / 255.0;
            double blueNorm = this.blue / 255.0;

            double max = Math.Max(redNorm, Math.Max(greenNorm, blueNorm));
            double min = Math.Min(redNorm, Math.Min(greenNorm, blueNorm));
            double delta = max - min;

            int hue = 0;

            if (delta != 0)
            {
                if (max == redNorm)
                {
                    hue = (int)Math.Round(60 * ((greenNorm - blueNorm) / delta));
                    if (greenNorm < blueNorm)
                        hue += 360;
                }
                else if (max == greenNorm)
                {
                    hue = (int)Math.Round(60 * ((blueNorm - redNorm) / delta) + 120);
                }
                else if (max == blueNorm)
                {
                    hue = (int)Math.Round(60 * ((redNorm - greenNorm) / delta) + 240);
                }
            }

            int saturation = (max == 0) ? 0 : (int)Math.Round((delta / max) * 100); // delta = max - min, de
            int value = (int)Math.Round(max * 100);

            return new HSV(hue, saturation, value);
        }

        public override string ToString()
        {
            return $"R - {red}, G - {green}, B - {blue}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            /**
             * as Используйте оператор, чтобы явно преобразовать 
             * результат выражения в заданный ссылочный или пустой 
             * тип значения. Если такое преобразование невозможно, 
             * оператор as возвращает значение null. В отличие от 
             * выражения приведения, оператор as никогда не создает 
             * исключение. 
             * https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/type-testing-and-cast#the-as-operator
             */

            var other = (RGB)obj;
            var equalsFlag = true;
            if (this.red != other.red)
                equalsFlag = false;
            if (this.green != other.green)
                equalsFlag = false;
            if (this.blue != other.blue)
                equalsFlag = false;

            return equalsFlag;
        }
    }

    public class HSV
    {
        public int hue;
        public int saturation;
        public int value;

        public HSV(int hue, int saturation, int value)
        {
            this.hue = hue; 
            this.saturation = saturation;
            this.value = value;
        }

        public static HSV operator +(HSV left, HSV right)
        {
            var newHue = left.hue + right.hue;
            var newSaturation = left.saturation + right.saturation;
            var newValue = left.value + right.value;

            return new HSV(newHue, newSaturation, newValue);
        }

        public static HSV operator -(HSV left, HSV right)
        {
            var newHue = left.hue - right.hue;
            var newSaturation = left.saturation - right.saturation;
            var newValue = left.value - right.value;

            return new HSV(newHue, newSaturation, newValue);
        }

        public static HSV operator +(HSV left, RGB right)
        {
            var rightHSV = right.ToHSV();

            var newHue = left.hue + rightHSV.hue;
            var newSat = left.saturation + rightHSV.saturation;
            var newValue = left.value + rightHSV.value;

            return new HSV(newHue, newSat, newValue);
        }

        public static HSV operator -(HSV left, RGB right)
        {
            var rightHSV = right.ToHSV();

            var newHue = left.hue - rightHSV.hue;
            var newSat = left.saturation - rightHSV.saturation;
            var newValue = left.value - rightHSV.value;

            return new HSV(newHue, newSat, newValue);
        }

        public RGB ToRGB()
        {
            double Hi = (int)(this.hue / 60) % 6;

            double Vmin = (100 - this.saturation) * this.value / 100;
            double a = (this.value - Vmin) * (this.hue % 60) / 60;
            double Vinc = Vmin + a;
            double Vdec = this.value - a;

            var redNorm = 0d;
            var greenNorm = 0d;
            var blueNorm = 0d;
            switch(Hi)
            {
                case 0: redNorm = this.value; greenNorm = Vinc; blueNorm = Vmin; break;
                case 1: redNorm = Vdec; greenNorm = this.value; blueNorm = Vmin; break;
                case 2: redNorm = Vmin; greenNorm = this.value; blueNorm = Vinc; break;
                case 3: redNorm = Vmin; greenNorm = Vdec; blueNorm = this.value; break;
                case 4: redNorm = Vinc; greenNorm = Vmin; blueNorm = this.value; break;
                case 5: redNorm = this.value; greenNorm = Vmin; blueNorm = Vdec; break;
            }

            int red = (int)Math.Round(redNorm * 255 / 100);
            int green = (int)Math.Round(greenNorm * 255 / 100);
            int blue = (int)Math.Round(blueNorm * 255 / 100);
            return new RGB(red, green, blue);
        }

        public override string ToString()
        {
            return $"H - {hue}, S - {saturation}%, V - {value}%";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            var other = obj as HSV;
            var equalsFlag = true;
            if (this.hue != other.hue)
                equalsFlag = false;
            if (this.saturation != other.saturation)
                equalsFlag = false;
            if (this.value != other.value)
                equalsFlag = false;

            return equalsFlag;
        }
    }
}
