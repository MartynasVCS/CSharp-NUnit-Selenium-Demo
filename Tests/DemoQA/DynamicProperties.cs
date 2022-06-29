using Framework.Pages.DemoQA;
using NUnit.Framework;
using Tests.BaseClasses;

namespace Tests.DemoQA
{
    public class DynamicProperties : BaseTest
    {
        [SetUp]
        public static void openPage()
        {
            DynamicPropertiesPage.open();
        }

        [Test]
        public static void clickButtonWhichEnablesAfterDelay()
        {
            DynamicPropertiesPage.clickButtonEnabledAfter5Seconds();
        }

        [Test]
        public static void clickButtonWhichChangesTextColorAfterDelay()
        {
            DynamicPropertiesPage.clickButtonThatChangesTextColor();
        }
    }
}
