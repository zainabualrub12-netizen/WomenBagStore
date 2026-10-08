using System;
using System.ComponentModel.DataAnnotations;

namespace WomenBagsStore.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        public class BirthDateValidation : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (value == null)
                    return new ValidationResult("Birth date is required.");

                DateTime birthDate;
                if (!DateTime.TryParse(value.ToString(), out birthDate))
                    return new ValidationResult("Invalid date format.");

                var age = DateTime.Today.Year - birthDate.Year;
                if (birthDate > DateTime.Today.AddYears(-age)) age--; 

                if (age < 10 || age > 100)
                    return new ValidationResult(ErrorMessage);

                return ValidationResult.Success;
            }
            [Required(ErrorMessage = "Birth Date is required")]
            [DataType(DataType.Date)]
            [BirthDateValidation(ErrorMessage = "Age must be between 10 and 100 years")]
            public DateTime BirthDate { get; set; }

        }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
