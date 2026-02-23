using System;

namespace AP.Core.Validations
{
    internal static class ProductValidations
    {
        public static bool IsWithinTimeRange()
        {
            DateTime startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
            DateTime endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 6, 0, 0);
            return DateTime.Now.Hour >= startTime.Hour || DateTime.Now.Hour < endTime.Hour;                
        }
    }
}
