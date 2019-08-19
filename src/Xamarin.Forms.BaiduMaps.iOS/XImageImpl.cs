using Foundation;
using UIKit;

namespace Xamarin.Forms.BaiduMaps.iOS
{
    public static class XImageImpl
    {
        public static UIImage ToNative(this XImage image)
        {
            switch (image.Source)
            {
                default:
                    return null;

                case ImageSource.File:
                    return UIImage.FromFile(image.FileName);

                case ImageSource.Bundle:
                    return UIImage.FromBundle(image.BundleName);

                //case ImageSource.Resource:
                //    throw new NotImplementedException();

                case ImageSource.Stream:
                    return UIImage.LoadFromData(NSData.FromStream(image.Stream));
            }
        }
    }
}

