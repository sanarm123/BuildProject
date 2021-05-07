using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace BuildProject.UITest1
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.InstalledApp("com.companyname.buildproject").StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}