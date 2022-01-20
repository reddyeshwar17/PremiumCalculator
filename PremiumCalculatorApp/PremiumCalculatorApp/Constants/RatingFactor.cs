using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiumCalculatorApp.Constants
{
    public class RatingFactor
    {
        public const double Professional = 1.0;
        public const double WhiteCollar = 1.25;
        public const double LightManual = 1.50;
        public const double HeavyManual = 1.75;
        public const int Divider = 1000 * 12;
    }
}