using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

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

        //TODO

        //public HSV ToHSV()
        //{
        //    var hue = this.

        //    return hsvObject;
        //}

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
