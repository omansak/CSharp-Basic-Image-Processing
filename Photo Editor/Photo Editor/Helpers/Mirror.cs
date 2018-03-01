using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Editor.Helpers
{
    public class Mirror
    {
        private Bitmap MakeImage(Image image) // resmi aynalar tek yönden
        {
            Bitmap bitmap = new Bitmap(image);
            Bitmap temp = new Bitmap(bitmap.Width, bitmap.Height);
            int tempX = bitmap.Width - 1;
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    temp.SetPixel(tempX, y, bitmap.GetPixel(x, y));
                    tempX--;
                }
                tempX = bitmap.Width - 1;
            }
            return temp;
        }
        public Bitmap SetMirror(Image image, Direction direction)
        {
            Bitmap bitmap = new Bitmap(image); // orj resim
            Bitmap mirroredBitmap = MakeImage(image); // aynalanan resim
            Bitmap temp = new Bitmap(bitmap.Width * 2, bitmap.Height);//orj resmin 2 katı genişliğinde yer oluştur
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {

                    if (direction == Direction.Left)
                    {
                        /*
                         2 katı olaran boş resmin başına ve ortasından yazmaya başla
                         
                         */
                        temp.SetPixel(x, y, mirroredBitmap.GetPixel(x, y)); 
                        temp.SetPixel(x + bitmap.Width - 1, y, bitmap.GetPixel(x, y));
                    }
                    else
                    {
                        temp.SetPixel(x + bitmap.Width - 1, y, mirroredBitmap.GetPixel(x, y));
                        temp.SetPixel(x, y, bitmap.GetPixel(x, y));

                    }
                }
            }
            return temp;
        }
        public enum Direction
        {
            Right, Left
        }
    }
}
