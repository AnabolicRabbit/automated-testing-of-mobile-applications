using MobileTesting.Utilities;
using NUnit.Framework;
using Xamarin.UITest;

namespace MobileTesting.Test.Base
{
    public abstract class BaseTest
    {
        private string path = @"C:\Data\Temp\test.apk";
        public IApp app;

        [SetUp]
        public virtual void InitializeTest()
        {
            app = ApplicationInstaller.StartApplication(Xamarin.UITest.Platform.Android, path);
        }
    }
}