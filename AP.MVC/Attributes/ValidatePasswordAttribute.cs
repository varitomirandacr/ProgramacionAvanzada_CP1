using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AP.MVC.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    public class ValidatePasswordAttribute : ValidationAttribute
    {
        /// <summary>
        ///     
        /// </summary>
        /// <param name="value"></param>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var password = value as string;
            if (password == null)
                return new ValidationResult("Password is required.");

            if (password.Length < 12 || password.Length > 50)
                return new ValidationResult("Password must be between 12 and 50 characters.");

            if (!password.Any(char.IsUpper))
                return new ValidationResult("Password must contain an uppercase letter.");

            if (!password.Any(char.IsLower))
                return new ValidationResult("Password must contain a lowercase letter.");

            if (!password.Any(char.IsDigit))
                return new ValidationResult("Password must contain a number.");

            return ValidationResult.Success;
        }
    }
}
