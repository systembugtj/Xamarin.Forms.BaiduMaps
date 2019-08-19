using System;
using Xamarin.Forms.Platform.iOS;
using Foundation;
using UIKit;

namespace Xamarin.Forms.BaiduMaps.Sample.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            Forms.Init();
            FormsBaiduMaps.Init("B3iCnaZ9pv6UDbenWBEHdfY36dsVLUnM");

            LoadApplication(new App());

            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}

