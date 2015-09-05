using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eFarmingRegulatorySystem.Models
{
    public class Regulate
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression(@"\d{6,10}", ErrorMessage = "Regulate # must be between 6 and 10 digits.")]
        [Display(Name = "Regulate #")]
        public string RegulateNo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(@"(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}", ErrorMessage = "In Date must be dd/mm/yyyy format and valid.")]
        [Display(Name = "In Date")]
        public string InDate { get; set; }

        [DataType(DataType.Date)]
        [RegularExpression(@"(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}", ErrorMessage = "Out Date must be dd/mm/yyyy format and valid.")]
        [Display(Name = "Out Date")]
        public string OutDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        //             @"^(?:0?[0-9]|1[0-2]):[0-5][0-9] [ap]m$"   -- 12 hours format
        [RegularExpression(@"^(?:[01][0-9]|2[0-3]):[0-5][0-9]$", ErrorMessage = "Invalid time 24 hours format only.")]
        [Display(Name = "In Time")]
        public string InTime { get; set; }

        [DataType(DataType.Time)]
        [RegularExpression(@"^(?:[01][0-9]|2[0-3]):[0-5][0-9]$", ErrorMessage = "Invalid time 24 hours format.")]
        [Display(Name = "Out Time")]
        public string OutTime { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "Rego # is invalid.")]
        [Display(Name = "Rego #")]
        public string VechileRegoNo { get; set; }

        [Display(Name = "Model")]
        public string VechileMake { get; set; }

        [RegularExpression(@"\d{1,2}", ErrorMessage = "Average per km is invalid.")]
        [Display(Name = "Avg / KM")]
        public string AveragePerKM { get; set; }

        [Display(Name = "Regulate Active ?")]
        public bool IsActive { get; set; }

        [Display(Name = "Additional Information")]
        public string Comment { get; set; }

        [Required]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}