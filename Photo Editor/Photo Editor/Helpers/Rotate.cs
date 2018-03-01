using System.Drawing;

namespace Photo_Editor.Helpers
{
    public class Rotate
    {
        public Bitmap RotateLeft(Image image)
        {
            Bitmap bitmap = new Bitmap(image);
            Bitmap temp = new Bitmap(bitmap.Height, bitmap.Width); // yeni oluşacak resim orj resmin w ve h yer değüişmişl durumda
            int tempX = 0;
            int tempY = bitmap.Width - 1;
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    temp.SetPixel(tempX, tempY, bitmap.GetPixel(x, y));
                    tempY--;
                }
                tempX++;
                tempY = bitmap.Width - 1;
            }
            return temp;
        }
        public Bitmap RotateRight(Image image)
        {
            Bitmap bitmap = new Bitmap(image);
            Bitmap temp = new Bitmap(bitmap.Height, bitmap.Width);
            int tempX = bitmap.Height - 1;
            int tempY = 0;
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    temp.SetPixel(tempX, tempY, bitmap.GetPixel(x, y));
                    tempY++;
                }
                tempX--;
                tempY = 0;
            }
            return temp;
        }
    }
}
