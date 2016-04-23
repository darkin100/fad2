﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Net;

namespace fad2.UI
{
    public static class UiSettings
    {
        public static List<string> ImageLoop;
        private static readonly Random _random = new Random();
        public static string CardVersion { get; set; }

        public static bool HasFeature(string versionToCompare)
        {
            if (string.IsNullOrEmpty(versionToCompare))
            {
                return true;
            }
            return versionToCompare.CompareTo(CardVersion) <= 0;
        }

        public static string RandomImageUrl()
        {
            if (ImageLoop == null || ImageLoop.Count == 0)
            {
                return null;
            }
            var randomImageId = _random.Next(ImageLoop.Count);
            return ImageLoop[randomImageId];
        }


        public static Bitmap ResizedImage(int maxWidth, int maxHeight, int alpha = 100)
        {
            var path = RandomImageUrl();
            return ResizedImage(path, alpha, maxWidth, maxHeight);
        }

        public static Bitmap ResizedImage(Uri url, int alpha, int maxWidth, int maxHeight)
        {
            try
            {
                var request = WebRequest.Create(url.ToString());


                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    return ResizedImage(Image.FromStream(stream), alpha, maxWidth, maxHeight);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static Bitmap ResizedImage(Image image, int alpha, int maxWidth, int maxHeight)
        {
            var destRect = new Rectangle(0, 0, maxWidth, maxHeight);
            var destImage = new Bitmap(maxWidth, maxHeight);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    if (alpha != 100)
                    {
                        var colormatrix = new ColorMatrix();
                        colormatrix.Matrix33 = alpha/100F;
                        wrapMode.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    }
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }

        public static Bitmap ResizedImage(string path, int alpha, int maxWidth, int maxHeight)
        {
            if (string.IsNullOrWhiteSpace(path)) return null;
            var bitmap = new Bitmap(path);
            return ResizedImage(new Bitmap(path), alpha, maxWidth, maxHeight);
        }
    }
}