using NuGet.Frameworks;
using MyType;
using System.Security.Permissions;

namespace MyType_Testing
{
    public class Tests
    {
        [Test]
        public void SumOfRGB()
        {
            var rgbLeft = new RGB(10, 20, 55); 
            var rgbRight = new RGB(25, 10, 10);

            var result = rgbLeft + rgbRight;

            Assert.AreEqual(new RGB(35, 30, 65), result);
        }

        [Test]
        public void SumOfHSV()
        {
            var hsvLeft = new HSV(10, 20, 55);
            var hsvRight = new HSV(25, 10, 10);

            var result = hsvLeft + hsvRight;

            Assert.AreEqual(new HSV(35, 30, 65), result);
        }

        [Test]
        public void DiffOfRGB()
        {
            var rgbLeft = new RGB(10, 20, 55);
            var rgbRight = new RGB(25, 10, 10);

            var result = rgbLeft - rgbRight;

            Assert.AreEqual(new RGB(-15, 10, 45), result);
        }

        [Test]
        public void DiffOfHSV()
        {
            var hsvLeft = new HSV(10, 20, 55);
            var hsvRight = new HSV(25, 10, 10);

            var result = hsvLeft - hsvRight;

            Assert.AreEqual(new HSV(-15, 10, 45), result);
        }

        [Test]
        public void ToHSV()
        {
            var rgb = new RGB(123, 231, 132);
            var result = rgb.ToHSV();

            Assert.AreEqual(new HSV(125, 47, 91), result);
        }
    }
}