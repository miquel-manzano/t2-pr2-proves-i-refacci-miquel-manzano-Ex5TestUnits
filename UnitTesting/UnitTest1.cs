using System;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(2,2)]
        [DataRow(3,5)]
        public void CalculateAreaIsTrue(double width, double height)
        {
            //Arrange (^-^)
            double resultat;

            //Act
            resultat = Ex4Refactoring.Program.CalculateArea(width, height);

            //Assert
            Assert.AreEqual(width * height, resultat);
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(25)]
        public void CalculateCircumference(double radius)
        {
            //Arrange (^-^)
            double resultat;

            //Act
            resultat = Ex4Refactoring.Program.CalculateCircumference(radius);

            //Assert
            Assert.AreEqual(2 * Math.PI * radius, resultat);
        }
    }
}