using Foolproof;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace SupplementalCASample.Models
{
    public enum BloodPressureCategory { low,Ideal, Prehigh, High}
    public class BloodPressure
    {
        [Range(70, 140)]
        public int SystolicPressure { get; set; }

        [Range(40, 100)]
        [LessThan("SystolicPressure")]
        public int DiastolicPressure { get; set; }

        [Display(Name = "Your Blood Pressure is: ")]
        public BloodPressureCategory UserBloodPressure { get; set; }

        public BloodPressureCategory CalculateBloodPressurecategory()
        {
            if(SystolicPressure<= 90)
            {
               return BloodPressureCategory.low;
            }
            else if (SystolicPressure <= 120)
            {
                return BloodPressureCategory.Ideal;
            }
            else if (SystolicPressure <= 140)
            {
                return BloodPressureCategory.Prehigh;
            }
            else 
            {
                return BloodPressureCategory.High;
            }
        }

         

    }
}