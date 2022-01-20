using PremiumCalculatorApp.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiumCalculatorApp.Repository
{
    public class CleanerFlouristPremium : IPremiumCalculator
    {
        public decimal CalculateMonthlyPremium(decimal sumInsured, int age)
        {
            decimal clcPrem;
            try
            {
                clcPrem = (sumInsured * (decimal)RatingFactor.LightManual * age) / 1000 * 12;
            }
            catch (Exception ex)
            {
                //Logic to log
                throw;
            }
            return clcPrem;
        }
    }

    public class DoctorPremium : IPremiumCalculator
    {
        public decimal CalculateMonthlyPremium(decimal sumInsured, int age)
        {
            return (sumInsured * (decimal)RatingFactor.Professional * age) / 1000 * 12;
        }
    }

    public class AuthorPremium : IPremiumCalculator
    {
        public decimal CalculateMonthlyPremium(decimal sumInsured, int age)
        {
            decimal clcPrem;
            try
            {
                clcPrem = (sumInsured * (decimal)RatingFactor.WhiteCollar * age) / 1000 * 12;
            }
            catch (Exception ex)
            {
                //Logic to log
                throw;
            }
            return clcPrem;
        }
    }

    public class FarmerMechanicPremium : IPremiumCalculator
    {
        public decimal CalculateMonthlyPremium(decimal sumInsured, int age)
        {
            decimal clcPrem;
            try
            {
                clcPrem = (sumInsured * (decimal)RatingFactor.HeavyManual * age) / 1000 * 12;
            }
            catch (Exception ex)
            {
                //Logic to log
                throw;
            }
            return clcPrem;
        }
    }

    //public class MechanicPremium : IPremiumCalculator
    //{
    //    public decimal CalculateMonthlyPremium()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public class FloristPremium : IPremiumCalculator
    //{
    //    public decimal CalculateMonthlyPremium(decimal sumInsured, int age)
    //    {
    //        decimal clcPrem;
    //        try
    //        {
    //            clcPrem = (sumInsured * (decimal)RatingFactor.LightManual * age) / RatingFactor.Divider;
    //        }
    //        catch (Exception ex)
    //        {
    //            //Logic to log
    //            throw;
    //        }
    //        return clcPrem;
    //    }
    //}
}