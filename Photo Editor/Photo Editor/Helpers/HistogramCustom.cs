using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Photo_Editor.Helpers
{
    public class HistogramCustom
    {
        public Image Gray(Image image)
        {
            Bitmap grayBitmap = new GrayScaling().Scale(image); // gri histogram çizmek için resmi önce gri tonlamaya çevir
            Dictionary<Color, int> histogram = SetDictionary(grayBitmap); // renk ve sayaç dizisini oluşturur
            Bitmap histogramBitmap = new Bitmap(histogram.Count, histogram.Max(i => i.Value) / 10); // yeni bir histogramı gööstermek için resim aç ve genişlik = renk sayısı yükseklik = max renk sayacı
            histogram = histogram.OrderBy(i => i.Key.R).ToDictionary(i => i.Key, i => i.Value);
            return DrawHistogram(histogram, histogramBitmap);
        }
        public Image Colorful(Image image)
        {
            Bitmap redBitmap = new Channels().GetChannels(image, true, false, false);
            Bitmap greenitmap = new Channels().GetChannels(image, false, true, false);
            Bitmap blueitmap = new Channels().GetChannels(image, false, false, true);
            Dictionary<Color, int> redHistogram = SetDictionary(redBitmap);
            redHistogram = redHistogram.OrderBy(i => i.Key.R).ToDictionary(i => i.Key, i => i.Value);
            Dictionary<Color, int> greenHistogram = SetDictionary(greenitmap);
            greenHistogram = greenHistogram.OrderBy(i => i.Key.G).ToDictionary(i => i.Key, i => i.Value);
            Dictionary<Color, int> blueHistogram = SetDictionary(blueitmap);
            blueHistogram = blueHistogram.OrderBy(i => i.Key.B).ToDictionary(i => i.Key, i => i.Value);
            int maxW = 0, maxH = 0;
            if (maxW < redHistogram.Count)
                maxW = redHistogram.Count;
            if (maxW < greenHistogram.Count)
                maxW = greenHistogram.Count;
            if (maxW < blueHistogram.Count)
                maxW = blueHistogram.Count;
            if (maxH < redHistogram.Max(i => i.Value))
                maxH = redHistogram.Max(i => i.Value);
            if (maxH < greenHistogram.Max(i => i.Value))
                maxH = greenHistogram.Max(i => i.Value);
            if (maxH < blueHistogram.Max(i => i.Value))
                maxH = blueHistogram.Max(i => i.Value);
            Bitmap histogramBitmap = new Bitmap(maxW, maxH / 10);
            Graphics.FromImage(histogramBitmap).Clear(Color.White);
            histogramBitmap = DrawHistogram2(redHistogram, histogramBitmap);
            histogramBitmap = DrawHistogram2(greenHistogram, histogramBitmap);
            histogramBitmap = DrawHistogram2(blueHistogram, histogramBitmap);
            return histogramBitmap;
        }
        public Color Mix(Color from, Color to, float percent) // iki farklı renkten %50 alarak yeni renk oluşturmak
        {
            float amountFrom = 1.0f - percent;

            return Color.FromArgb(
                (byte)(from.A * 0.5f + to.A * 0.5f),
                (byte)(from.R * 0.5f + to.R * 0.5f),
                (byte)(from.G * 0.5f + to.G * 0.5f),
                (byte)(from.B * 0.5f + to.B * 0.5f));
        }
        public Dictionary<Color, int> SetDictionary(Bitmap bitmap)
        {
            Dictionary<Color, int> histogram = new Dictionary<Color, int>();
            for (int x = 0; x < bitmap.Width; x++) // satur stun okuma
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color i = bitmap.GetPixel(x, y); // Pikselin rengini al
                    if (histogram.ContainsKey(i)) // eğer dizi(dictionary) de varsa
                    {
                        histogram[i] = histogram[i] + 1; // kaç kere kullanıdıgını bir artır
                    }
                    else
                    {
                        histogram.Add(i, 1); // yoksa yeni ekle
                    }

                }
            }
            return histogram;
        }
        public Bitmap DrawHistogram(Dictionary<Color, int> histogram, Bitmap bitmap)
        {
            Pen pen;
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);
                for (int i = 0; i < histogram.Count; i++)
                {
                    pen = new Pen(histogram.ElementAt(i).Key, 1);
                    graphics.DrawLine(pen, i, bitmap.Height, i, histogram.ElementAt(i).Value / 10);//histograma altan yukarıya doğru çizme
                }
            }
            return bitmap;
        }//histogram çiz
        public Bitmap DrawHistogram2(Dictionary<Color, int> histogram, Bitmap bitmap)
        {
            int i = 0;
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    if (color.R == 255 && color.A == 255 && color.G == 255 && color.B == 255) // eğer pikselin rengi beyaz ise direk çiz 
                    {
                        color = histogram.ElementAt(i).Key;
                    }
                    else // ama arakda başka renk varsa iki rengi gbirleştir.
                    {
                        color = Mix(color, histogram.ElementAt(i).Key, 0.5f);
                    }
                    if (y >= histogram.ElementAt(i).Value)
                    {
                        bitmap.SetPixel(x, y, color);
                    }
                }
                i++;

            }
            return bitmap;
        }

    }
}
