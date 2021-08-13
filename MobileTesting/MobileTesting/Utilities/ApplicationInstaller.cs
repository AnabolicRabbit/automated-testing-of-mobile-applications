using Xamarin.UITest;

namespace MobileTesting.Utilities
{
    public class ApplicationInstaller
    {
        public static IApp StartApplication(Platform platform, string pathToApplication)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.ApkFile(pathToApplication).StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}