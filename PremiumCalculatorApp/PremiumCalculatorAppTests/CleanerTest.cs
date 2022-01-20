using NUnit.Framework;
using PremiumCalculatorApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculatorAppTests
{
    [TestFixture]
    public class CleanerTest
    {

        [Test]
        public void CreateCleanerObject()
        {
            //Arrange
            CalculatorFactory calObj = new ConcreteCalculator();

            //Act
            IPremiumCalculator premiumCalculator = calObj.GetPremium("Cleaner");

            //Assert 
            //Assert.AreEqual(typeof(premiu), actual);
        }
        [Test]
        [TestCase(8000, 35, 35)]
        [TestCase(25000, 45, 140.625)]
        [TestCase(90000, 26, 292.5)]
        public void CalculatePremium_Positive(decimal sumInsured, int age, decimal expected)
        {
            //Arrange
            CalculatorFactory calObj = new ConcreteCalculator();
            IPremiumCalculator premiumCalculator = calObj.GetPremium("Cleaner");

            //Act
            decimal actual = premiumCalculator.CalculateMonthlyPremium(sumInsured, age);

            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(40000, 23, 36)]
        [TestCase(70000, 45, 120)]
        [TestCase(80000, 26, 290)]
        public void CalculatePremium_Negative(decimal sumInsured, int age, decimal expected)
        {
            //Arrange
            CalculatorFactory calObj = new ConcreteCalculator();
            IPremiumCalculator premiumCalculator = calObj.GetPremium("Cleaner");

            //Act
            decimal actual = premiumCalculator.CalculateMonthlyPremium(sumInsured, age);

            //Assert 
            Assert.AreNotEqual(expected, actual);
        }
    }
}

