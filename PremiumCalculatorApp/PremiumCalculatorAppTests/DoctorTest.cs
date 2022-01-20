using NUnit.Framework;
using PremiumCalculatorApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculatorAppTests
{
    class DoctorTest
    {

        [Test]
        [TestCase(70000, 38, 31920)]
        [TestCase(25000, 45, 13500)]
        [TestCase(90000, 26, 28080)]
        public void CalculatePremium_Positive(decimal sumInsured, int age, decimal expected)
        {
            //Arrange
            CalculatorFactory calObj = new ConcreteCalculator();
            IPremiumCalculator premiumCalculator = calObj.GetPremium("Doctor");

            //Act
            decimal result = premiumCalculator.CalculateMonthlyPremium(sumInsured, age);
            decimal actual = result;
            actual = Math.Truncate(actual * 1000) / 1000;
            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(40000, 23, 2000)]
        [TestCase(70000, 45, 4500)]
        [TestCase(80000, 26, 6300)]
        public void CalculatePremium_Negative(decimal sumInsured, int age, decimal expected)
        {
            //Arrange
            CalculatorFactory calObj = new ConcreteCalculator();
            IPremiumCalculator premiumCalculator = calObj.GetPremium("Doctor");

            //Act
            decimal actual = premiumCalculator.CalculateMonthlyPremium(sumInsured, age);

            //Assert 
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void CalculatePremium_Exception()
        {
            //Arrange
            CalculatorFactory calObj = new ConcreteCalculator();

            //Act
            IPremiumCalculator premiumCalculator = calObj.GetPremium("Doctor");

            //Assert 
            //Assert.AreEqual(typeof(premiumCalculator), actual);
        }
    }

}
