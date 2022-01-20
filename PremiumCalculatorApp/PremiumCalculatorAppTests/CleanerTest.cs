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
        [TestCase(8000, 35, 5040)]
        [TestCase(25000, 45, 20250)]
        [TestCase(90000, 26, 42120)]
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
        [TestCase(40000, 23, 2000)]
        [TestCase(70000, 45, 4000)]
        [TestCase(80000, 26, 6000)]
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

        [Test]
        public void CalculatePremium_Exception()
        {
            //Arrange
            CalculatorFactory calObj = new ConcreteCalculator();

            //Act
            IPremiumCalculator premiumCalculator = calObj.GetPremium("Cleaner");

            //Assert 
            //Assert.AreEqual(typeof(premiu), actual);
        }
    }
}

