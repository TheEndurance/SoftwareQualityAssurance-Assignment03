using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public static class TimeConversion
    {
        private static readonly string[] AllowedTimeStringForSeconds = { "seconds", "Seconds", "s", "S" };
        private static readonly string[] AllowedTimeStringForMinutes = { "minutes", "Minutes", "m", "M" };
        private static readonly string[] AllowedTimeStringForHours = { "hours", "Hours", "h", "H" };
        private static readonly string[] AllowedTimeStringForDays = { "days", "Days", "d", "D" };

        public static double Convert(double value, string convertFrom, string convertTo)
        {
            string modifiedConvertFrom = ModifyInputStub(convertFrom);
            string modifiedConvertTo = ModifyInputStub(convertTo);
            return value * GetMultiplierStub(modifiedConvertFrom, modifiedConvertTo);
        }

        private static string ModifyInputStub(string input)
        {
            return "";
        }

        private static double GetMultiplierStub(string convertFrom, string convertTo)
        {
            return 0.00;
        }
    }
}
