﻿using System.IO;

namespace Xamarin.Forms.BaiduMaps
{
    public enum ImageSource
    {
        File,
        Stream,
        Bundle,
        Resource
    }

    public sealed class XImage
    {
        public ImageSource Source { get; private set; }

        public string FileName { get; private set; }
        public Stream Stream { get; private set; }
        public string BundleName { get; private set; }
        public string ResourceName { get; private set; }

        private XImage() {}

        public static XImage FromBundle(string bundleName)
        {
            return new XImage {
                Source = ImageSource.Bundle,
                BundleName = bundleName
            };
        }

        public static XImage FromFile(string fileName)
        {
            return new XImage {
                Source = ImageSource.File,
                FileName = fileName
            };
        }

        public static XImage FromResource(string resName)
        {
            return new XImage {
                Source = ImageSource.Resource,
                ResourceName = resName
            };
        }

        public static XImage FromStream(Stream stream) {
            return new XImage {
                Source = ImageSource.Stream,
                Stream = stream
            };
        }
    }
}

