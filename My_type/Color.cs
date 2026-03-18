using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyType
{
    public class RGB
    {
        private int red;
        private int green;
        private int blue;

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

            var other = obj as RGB;
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
        private int hue;
        private int saturation;
        private int value;

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

        //TODO доделать HSV - RGB

        //public RGB ToRGB()
        //{
        //    double Hi = (this.hue / 60) % 6;
        //    double s = Math.Clamp(this.saturation, 0, 1);
        //    double v = Math.Clamp(this.value, 0, 1);

        //    double red = 0, g = 0, b = 0;

        //    if (s == 0)
        //    {
        //        r = g = b = v;
        //    }
        //    else
        //    {
        //        int hi = (int)Math.Floor(h / 60) % 6;
        //        double f = (h / 60) - Math.Floor(h / 60);

        //        double p = v * (1 - s);
        //        double q = v * (1 - f * s);
        //        double t = v * (1 - (1 - f) * s);

        //        switch (hi)
        //        {
        //            case 0: r = v; g = t; b = p; break;
        //            case 1: r = q; g = v; b = p; break;
        //            case 2: r = p; g = v; b = t; break;
        //            case 3: r = p; g = q; b = v; break;
        //            case 4: r = t; g = p; b = v; break;
        //            case 5: r = v; g = p; b = q; break;
        //        }
        //    }

        //    return new RGB(r, g, b);
        //}

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
