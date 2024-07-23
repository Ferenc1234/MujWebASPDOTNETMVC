using System;
using System.ComponentModel.DataAnnotations;

namespace MujWeb.Data
{
    public class StringToDoubleAttribute : ValidationAttribute
    {
        // Override the IsValid method from ValidationAttribute
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            // Check if value is null
            if (value == null)
            {
                return new ValidationResult("Value cannot be null.");
            }

            // Convert value to string
            var stringValue = value.ToString();
            try
            {
                // Try to convert the string to double
                Convert.ToDouble(stringValue.Replace('.', ','));
                return ValidationResult.Success;
            }
            catch
            {
                // Return the error message if conversion fails
                return new ValidationResult(ErrorMessage ?? "Invalid number format.");
            }
        }
    }
}
