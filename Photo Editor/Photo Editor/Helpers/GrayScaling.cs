using System.Drawing;

namespace Photo_Editor.Helpers
{/*
    resmi gri tonlama yapar
     1:r g b/ 3
     2: r g b çarp. 
     A(saydalık) R G B 
     */
    public class GrayScaling
    {
        public Bitmap Scale(Image image)
        {
            Bitmap bitmap = new Bitmap(image);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color bitmapColor = bitmap.GetPixel(x, y);
                    if (bitmapColor.R == 0 && bitmapColor.G == 0 && bitmapColor.A == 0 && bitmapColor.B == 0) // eğer piksel yoksa işlem yapma (transparan ise)
                        continue;
                    int grayScale = (int)((bitmapColor.R * 0.3) + (bitmapColor.G * 0.59) + (bitmapColor.B * 0.11)); // belirli bir çarpım
                    Color myColor = Color.FromArgb(grayScale, grayScale, grayScale); // renk değerlerini ver color halini bvereyim
                    bitmap.SetPixel(x, y, myColor);
                }
            }
            return bitmap;
        }
    }
}
