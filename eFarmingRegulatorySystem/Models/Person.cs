using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eFarmingRegulatorySystem.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression(@"\d{6,10}", ErrorMessage = "Account # must be between 6 and 10 digits.")]
        [Display(Name = "Account #")]
        public string AccountNumber { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "First name is invalid.")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
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

        [Required]
        //[StringLength(10, MinimumLength=10)]
        [RegularExpression(@"\d{10,10}", ErrorMessage = "Mobile # must be 10 digits.")]
        [Display(Name = "Mobile #")]
        public string MobileNo { get; set; }

        [RegularExpression(@"\d{10,10}", ErrorMessage = "Landline # must be 10 digits.")]
        [Display(Name = "Landline #")]
        public string Landline { get; set; }

        [RegularExpression(@"\d{10,10}", ErrorMessage = "Other # must be 10 digits.")]
        [Display(Name = "Other #")]
        public string OtherNo { get; set; }

//        [RegularExpression(@"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
//         + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
//				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
//         + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
//				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
//         + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$", ErrorMessage = "Email is invalid.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [RegularExpression(@"\d{10,10}", ErrorMessage = "Fax # must be 10 digits.")]
        [Display(Name = "Fax #")]
        public string FaxNo { get; set; }

        [Display(Name = "Facebook ID")]
        public string FacebookId { get; set; }

        [RegularExpression(@"\d{10,10}", ErrorMessage = "Viber # must be 10 digits.")]
        [Display(Name = "Viber #")]
        public string ViberNo { get; set; }

        [RegularExpression(@"\d{10,10}", ErrorMessage = "WhatsApp # must be 10 digits.")]
        [Display(Name = "WhatsApp #")]
        public string WhatsAppNo { get; set; }

        [Display(Name = "Picture")]
        public string Picture { get; set; }

        [Required]
        [RegularExpression(@"(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}", ErrorMessage = "Joining Date must be dd/mm/yyyy format and valid.")]
        [Display(Name = "Joining Date")]
        public string JoinDate { get; set; }

        [RegularExpression(@"(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}", ErrorMessage = "Resigning Date must be dd/mm/yyyy format and valid.")]
        [Display(Name = "Resigning Date")]
        public string EndDate { get; set; }


        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Alternate first name is invalid.")]
        [Display(Name = "Alternate first name")]
        public string AlternateContactFirstName { get; set; }

        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Alternate last name is invalid.")]
        [Display(Name = "Alternate last name")]
        public string AlternateContactLastName { get; set; }

        public string AlternateContactName
        {
            get
            {
                return String.Format("{0} {1}", this.AlternateContactFirstName, this.AlternateContactLastName);
            }
        }

        [Display(Name = "Core Team Member ?")]
        public bool IsCoreTeamMember { get; set; }

        [Required]
        [Display(Name = "Account Active ?")]
        public bool IsActive { get; set; }

        [Display(Name = "Additional Comment")]
        public string Comment { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "Rego # is invalid.")]
        [Display(Name = "Rego #")]
        public string VechileRegoNo { get; set; }

        [Display(Name = "Model")]
        public string VechileMake { get; set; }

        [RegularExpression(@"\d{1,2}", ErrorMessage = "Average per km is invalid.")]
        [Display(Name = "Avg / KM")]
        public string AveragePerKM { get; set; }

        [Display(Name = "Is Chowkidar ?")]
        public bool IsChowkidar { get; set; }
        
        [Display(Name = "Is Supplier ?")]
        public bool IsSupplier { get; set; }

        [Display(Name = "Is Member ?")]
        public bool IsMember { get; set; }

        [Display(Name = "Member #")]
        public string MemberNo { get; set; }

        [Display(Name = "Address Verified ?")]
        public bool IsResidentialProofChecked { get; set; }

        [Display(Name = "Supporting Documents")]
        public string SupportingDocuments { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        //Allow us to quickly access all the related regulatory trips carried out by a given person
        //by doing the join on that foreign key behind the scene
        public virtual ICollection<Regulate> Regulates { get; set; } 
    }
}