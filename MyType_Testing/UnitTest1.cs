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
        public void SumLeftRGB()
        {
            var rgbLeft = new RGB(10, 20, 55);
            var hsvRight = new HSV(100, 50, 80);

            var result = rgbLeft + hsvRight;

            Assert.AreEqual(new RGB(146, 224, 157), result);
        }

        [Test]
        public void DiffLeftRGB()
        {
            var rgbLeft = new RGB(10, 20, 55);
            var hsvRight = new HSV(100, 50, 80);

            var result = rgbLeft - hsvRight;

            Assert.AreEqual(new RGB(-126, -184, -47), result);
        }

        [Test]
        public void SumLeftHSV()
        {
            var hsvLeft = new HSV(10, 20, 55);
            var rgbRight = new RGB(123, 231, 132);

            var result = hsvLeft + rgbRight;

            Assert.AreEqual(new HSV(135, 67, 146), result);
        }

        [Test]
        public void DiffLeftHSV()
        {
            var hsvLeft = new HSV(10, 20, 55);
            var rgbRight = new RGB(123, 231, 132);

            var result = hsvLeft - rgbRight;

            Assert.AreEqual(new HSV(-115, -27, -36), result);
        }

        [Test]
        public void ToHSV()
        {
            var rgb = new RGB(123, 231, 132);

            var result = rgb.ToHSV();

            Assert.AreEqual(new HSV(125, 47, 91), result);
        }

        [Test]
        public void ToRGB()
        {
            var hsv = new HSV(100, 50, 80);

            var result = hsv.ToRGB();

            Assert.AreEqual(new RGB(136, 204, 102), result);
        }
    }
}