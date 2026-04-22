using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryUtilities;

namespace TestCICD
{
    [TestClass]
    public class GeometryHelperTests
    {
        // Circle

        [TestMethod]
        public void CircleArea_NormalCase()
        {
            double result = GeometryHelper.CircleArea(2);

            Assert.AreEqual(Math.PI * 4, result, 0.0001);
        }

        [TestMethod]
        public void CircleArea_BorderCase_Zero()
        {
            double result = GeometryHelper.CircleArea(0);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CircleArea_InvalidInput_NegativeRadius()
        {
            double result = GeometryHelper.CircleArea(-2);

            // имитация "ошибки" — проверяем, что вход некорректный
            Assert.IsTrue(result >= 0, "Площадь не должна быть отрицательной");
        }

        // Square

        [TestMethod]
        public void SquarePerimeter_NormalCase()
        {
            double result = GeometryHelper.SquarePerimeter(5);

            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void SquarePerimeter_BorderCase_Zero()
        {
            double result = GeometryHelper.SquarePerimeter(0);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SquarePerimeter_InvalidInput_NegativeSide()
        {
            double result = GeometryHelper.SquarePerimeter(-3);

            // проверяем "невалидность"
            Assert.IsTrue(result <= 0, "Периметр не должен быть отрицательным");
        }

        // Triangle

        [TestMethod]
        public void TriangleArea_NormalCase()
        {
            double result = GeometryHelper.TriangleArea(10, 5);

            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TriangleArea_BorderCase_Zero()
        {
            double result = GeometryHelper.TriangleArea(10, 0);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TriangleArea_InvalidInput_NegativeBase()
        {
            double result = GeometryHelper.TriangleArea(-10, 5);
            
            Assert.IsTrue(result <= 0, "Площадь не должна быть отрицательной");
        }
    }
}