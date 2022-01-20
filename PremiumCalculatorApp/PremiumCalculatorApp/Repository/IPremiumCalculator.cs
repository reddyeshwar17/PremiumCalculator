using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculatorApp.Repository
{
   public interface IPremiumCalculator
    {
        decimal CalculateMonthlyPremium(decimal sumInsured, int age);
    }
}
