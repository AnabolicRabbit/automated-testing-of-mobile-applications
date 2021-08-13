using MobileTesting.Test.Base;
using MobileTesting.Utilities;
using NUnit.Framework;

namespace MobileTesting
{
    [TestFixture]
    public class MobileTests : BaseTest
    {
        [Test]
        public void GetNewcomersInstrustion()
        {
            //Act
            var element = app.WaitForElement(c => c.Id("text_title"));
            string actualText = element[0].Text;

            //Assert
            Assert.AreEqual(ExpectedResults.expectedText, actualText, "The newcomer's instruction is not displayed for the run.");
        }

        [Test]
        public void GetFirstMotorcycleFromTheList()
        {
            //Act
            app.WaitForElement(c => c.Id("text_title"));
            app.Tap(c => c.Id("nextView"));
            app.Tap(c => c.Id("nextView"));
            app.Tap(c => c.Id("nextView"));
            app.Tap(c => c.Id("nextView"));
            app.Tap(c => c.Id("nextView"));
            app.WaitForElement(c => c.Id("toolbar"));
            app.Tap(c => c.Marked("Авто и мото"));
            app.ScrollDownTo(c => c.Marked("Мотоциклы"));
            app.Tap(c => c.Marked("Мотоциклы"));
            var motorcycleElement = app.WaitForElement(c => c.Id("text_name"));
            string actualFirstMotorcycleName = motorcycleElement[0].Text;

            //Assert
            Assert.AreEqual(ExpectedResults.expectedFirstMotorcycleName, actualFirstMotorcycleName, "The actual first motorcycle name differs from the expected.");
        }
    }
}