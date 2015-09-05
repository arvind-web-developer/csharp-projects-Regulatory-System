using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eFarmingRegulatorySystem.Models
{
    public class Investment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression(@"\d{6,10}", ErrorMessage = "Investment # must be between 6 and 10 digits.")]
        [Display(Name = "Investment #")]
        public string InvestmentNo { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "First name is invalid.")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Last name is invalid.")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return String.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [RegularExpression(@"\d{10,10}", ErrorMessage = "Mobile # must be 10 digits.")]
        [Display(Name = "Mobile #")]
        public string MobileNo { get; set; }

        [RegularExpression(@"\d{10,10}", ErrorMessage = "Landline # must be 10 digits.")]
        [Display(Name = "Landline #")]
        public string Landline { get; set; }

        [RegularExpression(@"\d{10,10}", ErrorMessage = "Other # must be 10 digits.")]
        [Display(Name = "Other #")]
        public string OtherNo { get; set; }

        [RegularExpression(@"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                 + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
        				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                 + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
        				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                 + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$", ErrorMessage = "Email is invalid.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal InvestmentAmount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string InvestmentDate { get; set; }

        public bool IsActive { get; set; }

        public string Comment { get; set; }
    
    }
}