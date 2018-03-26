using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC
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
            return value * GetMultiplier(modifiedConvertFrom, modifiedConvertTo);
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

        private static double GetMultiplier(string convertFrom, string convertTo)
        {
            double convertFromValue = 0.00;
            double convertToValue = 0.00;

            switch (convertFrom)
            {
                case "seconds":
                    convertFromValue = 1;
                    break;
                case "minutes":
                    convertFromValue = 60;
                    break;
                case "hours":
                    convertFromValue = 3600;
                    break;
                case "days":
                    convertFromValue = 86400;
                    break;
            }

            switch (convertTo)
            {
                case "seconds":
                    convertToValue = 1;
                    break;
                case "minutes":
                    convertToValue = 60;
                    break;
                case "hours":
                    convertToValue = 3600;
                    break;
                case "days":
                    convertToValue = 86400;
                    break;
            }

            return convertFromValue / convertToValue;

        }
    }
}
