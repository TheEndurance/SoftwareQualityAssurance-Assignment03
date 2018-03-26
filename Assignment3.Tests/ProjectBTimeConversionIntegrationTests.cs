using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjectB;

namespace Assignment3.Tests
{
    [TestFixture]
    public class ProjectBTimeConversionIntegrationTests
    {
        [Test]
        public void TimeConversion_ConvertToIncorrectUnit_ReturnArgumentException()
        {
            string convertFrom = "Hours";
            string convertTo = "Secondess";
            double time = 2.00;

            Assert.That(() => TimeConversion.Convert(time, convertFrom, convertTo), Throws.ArgumentException);
        }

        [Test]
        public void TimeConversion_ConvertFromIncorrectUnit_ReturnArgumentException()
        {
            string convertFrom = "minimuntess";
            string convertTo = "Hours";
            double time = 2.00;

            Assert.That(() => TimeConversion.Convert(time, convertFrom, convertTo), Throws.ArgumentException);
        }

        [Test]
        public void TimeConversion_BothConvertToAndFromAreCorrect_DoesNotReturnArgumentException()
        {
            string convertFrom = "Minutes";
            string convertTo = "Seconds";
            double time = 2.00;

            Assert.That(() => TimeConversion.Convert(time, convertFrom, convertTo), !Throws.ArgumentException);
        }

        [Test]
        public void TimeConversion_BothConvertToAndFromAreIncorrectUnit_ReturnArgumentException()
        {
            string convertFrom = "minumutes";
            string convertTo = "shecondssess";
            double time = 2.00;

            Assert.That(() => TimeConversion.Convert(time, convertFrom, convertTo), Throws.ArgumentException);
        }
    }
}
