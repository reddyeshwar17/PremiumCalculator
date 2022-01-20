using PremiumCalculatorApp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PremiumCalculatorApp.Models
{
    public class PremiumModel
    {
        [StringLength(100)]
        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter age")]
        [Range(1, 100, ErrorMessage = "Age must be between 1-70")]
        public int Age { get; set; }

        //[MinimumAge(18)]
        [Display(Name = "Date of Birth")]
        //[DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Please enter DOB")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please enter occupation")]
        public Occupation Occupation { get; set; }

        [Range(10, double.MaxValue, ErrorMessage = "Sum insured must be greater than $10")]
        [Display(Name = "Death - Sum insured")]
        [Required(ErrorMessage = "Please enter sum insured amount")]
        public decimal SumInsured { get; set; }
    }

    public class MinimumAgeAttribute : ValidationAttribute
    {
        int _minimumAge;
        public MinimumAgeAttribute(int minimumAge)
        {
            _minimumAge = minimumAge;
        }

        public override bool IsValid(object value)
        {
            DateTime date;
            if (DateTime.TryParse(value.ToString(), out date))
            {
                return date.AddYears(_minimumAge) < DateTime.Now;
            }

            return false;
        }
    }
}