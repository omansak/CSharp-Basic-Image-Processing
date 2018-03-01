using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Editor.Helpers
{
    public class Channels
    {
        public Bitmap GetChannels(Image image, bool r, bool g, bool b)
        {

            /*
             1: piksel rengini al
             2: rengi integer değere çevir
             3: eğer  integer değeri >> 16 ile işleme sokup 0xFF ile ANDlersek o rengin kırmızı tonunu elde ederiz
                eğer  integer değeri >> 8 ile işleme sokup 0xFF ile ANDlersek o rengin yeşil tonunu elde ederiz
                eğer  integer değeri 0xFF ile ANDlersek o rengin mavi tonunu elde ederiz

             4: işlemlerden sonra istenilmeyen rengi yok etmek için 0x00 ile andleyerek o rengi yok edebiliriz

             
             
             
             */
            byte bR = 0xFF, bG = 0xFF, bB = 0xFF; // her sayıyı 1 ile andlemek kendisne eşittir
            if (!r)
            {
                bR = 0x00; // her sayıyı 0 ile andlemek 0 eşittir
            }
            if (!g)
            {
                bG = 0x00;
            }
            if (!b)
            {
                bB = 0x00;
            }
            Bitmap bitmap = new Bitmap(image);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color i = bitmap.GetPixel(x, y);
                    if (i.R == 0 && i.G == 0 && i.A == 0 && i.B == 0)
                        continue;
                    int bitmapColor = i.ToArgb();    
                    int redPixel = (bitmapColor >> 16) & bR;
                    int greenPixel = (bitmapColor >> 8) & bG;
                    int bluePixel = bitmapColor & bB;
                    Color color = Color.FromArgb(redPixel, greenPixel, bluePixel);
                    bitmap.SetPixel(x, y, color);
                }
            }
            return bitmap;
        }
    }
}
