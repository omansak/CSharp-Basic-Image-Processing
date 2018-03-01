using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Photo_Editor.Helpers
{
    public class ReSize
    {
        public Bitmap ScaleByValue(Image image, int width, int height)
        {
            if (width <= 0)
            {
                width = image.Width;
            }
            if (height <= 0)
            {
                height = image.Height;
            }
            Rectangle destRect = new Rectangle(0, 0, width, height);
            Bitmap destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                // genel çizme birleştirme ayarları
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode); // 
                }
            }

            return destImage;
        }
        public Image ScaleByRatio(Image image, double widthPercent, double heightPercent)
        {
            if (widthPercent <= 0)
            {
                widthPercent = 1;
            }
            if (heightPercent <= 0)
            {
                heightPercent = 1;
            }
            int newWidth = (int)(image.Width * widthPercent);
            int newHeight = (int)(image.Height * heightPercent);
            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (var graphics = Graphics.FromImage(newImage))
            {
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }
    }
}
