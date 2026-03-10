using System.ComponentModel.DataAnnotations;

namespace AP.Web.Attributes
{

    public class AlwaysTrueAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            return ValidationResult.Success;
        }
    }
}