﻿using Framework;
using Framework.Pages.DemoQA;
using NUnit.Framework;

namespace Tests.DemoQA
{
    [Parallelizable(scope: ParallelScope.Children)]
    public class Buttons
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://demoqa.com/buttons");
        }

        [Test]
        public static void leftClick()
        {
            string expectedMessage = "You have done a dynamic click";
            string actualMessage;

            ButtonsPage.leftClick();
            actualMessage = ButtonsPage.readMessageLeftClick();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public static void rightClick()
        {
            string expectedMessage = "You have done a right click";
            string actualMessage;

            ButtonsPage.rightClick();
            actualMessage = ButtonsPage.readMessageRightClick();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
