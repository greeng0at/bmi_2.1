using System;
using System.ComponentModel.DataAnnotations;

namespace BMICalculator
{
    public class ReverseBMI
    {

        // conversion factors from imperial to metric
        const double InchestoMetres = 39.37;
        const double KgToPound = 2.205;

        [Display(Name = "Height - Feet")]
        [Range(4, 7, ErrorMessage = "Feet must be between 4 and 7")]                               // max 7 feet
        public int HeightFeet { get; set; }

        [Display(Name = "Inches")]
        [Range(0, 11, ErrorMessage = "Inches must be between 0 and 11")]                              // 12 inches in a foot
        public int HeightInches { get; set; }

        [Display(Name = "Desired BMI")]
        [Range(9, 65, ErrorMessage = "Desired BMI must be between 9 and 65")]                              // 14 lbs in a stone
        public int DerisredBMI { get; set; }

        [Display(Name = "Desired weight - Stones: ")]
        [Range(5, 50, ErrorMessage = "Stones must be between 5 and 50")]                              // max 50 stone
        public int DesiredWeightStones { 
            get
            {
                double meters = ((HeightFeet * 12) + HeightInches) / InchestoMetres;
                double totalWeightKg = DerisredBMI * Math.Pow(meters, 2);
                double totalWeightPound = totalWeightKg * KgToPound;

                int desiredWeightStones = (int)totalWeightPound / 14;
                return desiredWeightStones;
            }
        }

        [Display(Name = "Desired weight - Pounds: ")]
        [Range(0, 13, ErrorMessage = "Pounds must be between 0 and 13")]                              // 14 lbs in a stone
        public int DesiredWeightPounds
        {
            get
            {
                double meters = ((HeightFeet * 12) + HeightInches) / InchestoMetres;
                double totalWeightKg = DerisredBMI * Math.Pow(meters, 2);
                double totalWeightPound = totalWeightKg * KgToPound;

                int desiredWeightPounds = (int)totalWeightPound % 14;
                return desiredWeightPounds;
            }
        }

    }
}
