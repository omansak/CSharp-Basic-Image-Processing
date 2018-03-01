using System.Drawing;

namespace Photo_Editor.Helpers
{
    public class InvertNegative
    {
        public Bitmap Invert(Image image)
        {
            Bitmap bitmap = new Bitmap(image);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color i = bitmap.GetPixel(x, y);
                    if (i.R == 0 && i.G == 0 && i.A == 0 && i.B == 0)
                        continue;
                    Color myColor = Color.FromArgb(255 - i.R, 255 - i.G, 255 - i.B); // tümleme işlemi
                    bitmap.SetPixel(x, y, myColor);
                }
            }
            return bitmap;
        }
    }
}
