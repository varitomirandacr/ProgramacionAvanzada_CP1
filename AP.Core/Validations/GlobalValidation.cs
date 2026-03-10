using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.Core.Validations
{
    public static class GlobalValidation
    {
        /// <summary>
        /// Determines whether the specified password meets the minimum length requirement.
        /// </summary>
        /// <remarks>This method only checks the length of the password. It does not perform any
        /// additional validation such as checking for character complexity or prohibited patterns.</remarks>
        /// <param name="password">The password string to validate. Cannot be null.</param>
        /// <returns><see langword="true"/> if the password is at least 4 characters long; otherwise, <see langword="false"/>.</returns>
        public static bool ValidatePassword(string password)
        {
            return password.Length >= 12;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <param name="checkCaps"></param>
        /// <returns></returns>
        public static bool ValidatePassword(string password, bool checkCaps)
        {
            return ValidatePassword(password) && (!checkCaps || password.Any(char.IsUpper));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <param name="checkCaps"></param>
        /// <param name="checkSmallCaps"></param>
        /// <returns></returns>
        public static bool ValidatePassword(string password, bool checkCaps, bool checkSmallCaps)
        {
            return ValidatePassword(password) && ValidatePassword(password)
                && (checkCaps && password.Any(char.IsUpper)) 
                && (checkSmallCaps && !password.Any(char.IsUpper));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <param name="checkCaps"></param>
        /// <param name="checkSmallCaps"></param>
        /// <param name="checkMaxLength"></param>
        /// <returns></returns>
        public static bool ValidatePassword(string password, bool checkCaps, bool checkSmallCaps, bool checkMaxLength)
        {
            return ValidatePassword(password) 
                && ValidatePassword(password, checkCaps: true) 
                && ValidatePassword(password, checkCaps: true, checkSmallCaps: true)
                && (!checkMaxLength || password.Length <= 100);
        }
    }
}
