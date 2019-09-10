using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectManagement.Common
{
    // Class to validate date range
    public class ValidateDateRangeAttribute : ValidationAttribute
    {
        #region IsValid Method
        // Method to check whether date range is valid
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Convert.ToDateTime(value) >= Convert.ToDateTime("01/01/2000") && Convert.ToDateTime(value) <= DateTime.Now)
                return ValidationResult.Success;
            return new ValidationResult(this.ErrorMessage);
        }
        #endregion

        #region ValidateDateRangeAttribute Constructor
        // Constructor to display error message in view
        public ValidateDateRangeAttribute(string errorMessage)
            : base(errorMessage)
        {
        }
        #endregion
    }
}
