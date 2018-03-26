using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjectA;

namespace Assignment3.Tests
{
    [TestFixture]
    public class ProjectATimeConversionIntegrationTests
    {
        [Test]
        public void TimeConversion_5HoursToMinutes_NoExceptionsThrown()
        {
            //arrange
            double userInputTime = 5;
            string convertFrom = "Hours";
            string convertTo = "Minutes";
            double expectedResult = 0;
            //assert
            double actualResult = TimeConversion.Convert(userInputTime, convertFrom, convertTo);
            //act
            Assert.AreEqual(expectedResult,actualResult);
        }

        [Test]
        public void TimeConversion_Negative5MinutesToSeconds_NoExceptionsThrown()
        {
            //arrange
            double userInputTime = -5;
            string convertFrom = "Minutes";
            string convertTo = "Seconds";
            double expectedResult = 0;
            //assert
            double actualResult = TimeConversion.Convert(userInputTime, convertFrom, convertTo);
            //act
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TimeConversion_5EmptyStringToSeconds_NoExceptionsThrown()
        {
            //arrange
            double userInputTime = 5;
            string convertFrom = string.Empty;
            string convertTo = "Seconds";
            double expectedResult = 0;
            //assert
            double actualResult = TimeConversion.Convert(userInputTime, convertFrom, convertTo);
            //act
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TimeConversion_5MinutesToEmptyString_NoExceptionsThrown()
        {
            //arrange
            double userInputTime = -5;
            string convertFrom = "Minutes";
            string convertTo = string.Empty;
            double expectedResult = 0;
            //assert
            double actualResult = TimeConversion.Convert(userInputTime, convertFrom, convertTo);
            //act
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
