using PremiumCalculatorApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiumCalculatorApp.Repository
{
    /// <summary>
    /// Abstrat factory design pattern
    /// </summary>
    public abstract class CalculatorFactory
    {
        public abstract IPremiumCalculator GetPremium(string occupation);
    }
    /// <summary>
    /// Abstrat factory concrete class
    /// </summary>
    public class ConcreteCalculator : CalculatorFactory
    {
        public override IPremiumCalculator GetPremium(string occupation)
        {
            try
            {
                int enumValue = (int)((Occupation)Enum.Parse(typeof(Occupation), occupation));
                switch (enumValue)
                {
                    case 1:
                    case 6:
                        return new CleanerFlouristPremium();
                    case 2:
                        return new DoctorPremium();
                    case 3:
                        return new AuthorPremium();
                    case 4:
                    case 5:
                        return new FarmerMechanicPremium();
                    //case 6:
                    //    return new FloristPremium();
                    default:
                        throw new ApplicationException(string.Format($"Premium not availablr for {occupation}"));
                }
            }
            catch (Exception ex)
            {
                //logic to log errors
                throw;
            }
        }
    }
}