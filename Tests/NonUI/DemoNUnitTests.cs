using NUnit.Framework;
using System;

namespace Tests.NonUI
{
    public class DemoNUnitTests
    {

        [Test]
        public static void number4IsEven()
        {
            int expectedRemainder = 0;
            int actualRemainder = 4 % 2;

            Assert.AreEqual(expectedRemainder, actualRemainder);
        }

        [Test]
        public static void currentHourIsEqualTo19()
        {
            int expectedHour = 19;
            int actualHour = DateTime.Now.Hour;

            Assert.AreEqual(expectedHour, actualHour);
        }

        [Test]
        public static void number995DividesBy3WithoutRemainder()
        {
            int expectedRemainder = 0;
            int actualRemainder = 995 % 3;

            Assert.AreEqual(expectedRemainder, actualRemainder);
        }

        [Test]
        public static void todayIsWednesday()
        {
            DayOfWeek expectedDay = DayOfWeek.Wednesday;
            DayOfWeek actualDay = DateTime.Now.DayOfWeek;

            string expectedDay2 = "Wednesday";
            string actualDay2 = DateTime.Now.DayOfWeek.ToString();

            Assert.AreEqual(expectedDay, actualDay);
            Assert.AreEqual(expectedDay2, actualDay2);
        }

        [Test]
        public static void waitFor5Seconds()
        {
            System.Threading.Thread.Sleep(5000);
        }

        [Test]
        public static void thereAre4EvenNumbersBetween1And10()
        {
            int expectedCount = 4;
            int actualCount = 0;

            for (int number = 1; number <= 10; number++)
            {
                if (number % 2 == 0)
                {
                    actualCount++;
                }
            }

            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
