using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB
{
    public static class TimeConversion
    {
        private static readonly string[] AllowedTimeStringForSeconds = { "seconds", "Seconds", "s", "S" };
        private static readonly string[] AllowedTimeStringForMinutes = { "minutes", "Minutes", "m", "M" };
        private static readonly string[] AllowedTimeStringForHours = { "hours", "Hours", "h", "H" };
        private static readonly string[] AllowedTimeStringForDays = { "days", "Days", "d", "D" };

        public static double Convert(double value, string convertFrom, string convertTo)
        {
            string modifiedConvertFrom = ModifyInput(convertFrom);
            string modifiedConvertTo = ModifyInput(convertTo);
            return value * GetMultiplierStub(modifiedConvertFrom, modifiedConvertTo);
        }

        private static string ModifyInput(string input)
        {
            string output = string.Empty;
            foreach (string dateTimeString in AllowedTimeStringForSeconds)
            {
                if (input.Equals(dateTimeString))
                {
                    output = "seconds";
                }
            }
            foreach (string dateTimeString in AllowedTimeStringForMinutes)
            {
                if (input.Equals(dateTimeString))
                {
                    output = "minutes";
                }
            }
            foreach (string dateTimeString in AllowedTimeStringForHours)
            {
                if (input.Equals(dateTimeString))
                {
                    output = "hours";
                }
            }
            foreach (string dateTimeString in AllowedTimeStringForDays)
            {
                if (input.Equals(dateTimeString))
                {
                    output = "days";
                }
            }
            if (output.Equals(string.Empty))
            {
                throw new ArgumentException("Incorrect time unit");
            }
            return output;
        }

        private static double GetMultiplierStub(string convertFrom, string convertTo)
        {
            return 0.00;
        }
    }
}
