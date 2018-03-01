using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;


namespace Photo_Editor.Helpers
{
    public class FileProcess
    {
        /*
         FileProcess : Dosya Açma,Kaydetme,Yeniden Açma ve Farklı Kaydet işlemlerini gerçekleştirir.
             
        */
        public Bitmap ReOpenImage()
        {
            return new Bitmap(Home.FilePath);
        }
        public Bitmap OpenImage()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = @"Dosya Seçiniz";
            dialog.Filter = @"JPG,JPEG,PNG,BMP (*.bmp)|*.bmp; *.jpg; *.jpeg; *.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Home.FilePath = dialog.FileName; // Sadece Dosya Yolu ...C://..../.../Test.jpg
                Home.FileName = dialog.SafeFileName; // Test.jpg
                FileStream bitmapFile = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite); //OpenCV = EmguCV(C#)
                Image loaded = new Bitmap(bitmapFile);
                bitmapFile.Dispose();
                return new Bitmap(loaded);

            }
            return null;
        }
        public void SaveImage(string path, Image image)
        {
            if(File.Exists(path)) // dosya var ise
                File.Delete(path); // o dosyayı sil
            image.Save(path); // ve gelen image kaydet aynı formatta kaydeder
            MessageBox.Show("Resim kaydedildi \n" + path);
        }
        public string AsSaveImage(string name, Image image, ImageFormat format)
        {

            string path = "";
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    path = Path.ChangeExtension(dialog.SelectedPath + "\\(new)" + name, format.ToString()); // dosya uzantısını değiştirir
                    image.Save(path, format);//istenilen formatta kayıt eder
                    MessageBox.Show("Resim kaydedildi \n" + path);

                }
            }
            return path;
        }
    }
}
