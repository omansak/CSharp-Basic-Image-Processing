using Photo_Editor.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Photo_Editor
{
    public partial class Home : Form
    {
        public class History
        {
            public Image Image { get; set; }
            public string Value { get; set; }
        }
        public static string FilePath; //FileProcess -> OpenImage() dosya yolunu kaydeder
        public static string FileName;//FileProcess -> OpenImage() dosya ismini kaydeder
        public static int HistroyValue = 0;
        public static List<History> HistoryList = new List<History>();
        public static ListBox HistoryListBox;
        private Image SourceImage;
        public Home()
        {
            InitializeComponent();
            KeyPreview = true;
            HistoryListBox = listBox1;
        }
        public static void AddHistory(Image image, string value)
        {

            int c = HistoryList.Count;
            if (c > HistroyValue)
            {
                HistoryList.RemoveRange(HistroyValue, c - HistroyValue);
            }
            HistoryList.Add(null);
            HistoryList[HistroyValue] = new History { Image = image, Value = value };
            HistroyValue++;
            HistoryListBox.Items.Clear();
            foreach (var s in HistoryList.Select(i => i.Value))
            {
                HistoryListBox.Items.Add(s);
            }

        }
        public static Image BackHistory()
        {
            if (HistroyValue <= 0)
            {
                HistroyValue = 0;
                return null;
            }
            HistroyValue--;
            return HistoryList[HistroyValue].Image;
        }
        public Image BackHistory(int i)
        {
            if (i + 1 != HistroyValue)
            {
                HistroyValue = i;
            }

            return HistoryList[i].Image;
        }
        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image image = new FileProcess().OpenImage(); // Dosya yolunu ve dosya ismini Home.FileName ve Home.FilePath ve seçilen image return ledi
            if (image != null)
            {
                imageBox.Image = image;//pictureboxa kaydeter
                AddHistory(image, "Aç"); // history i kayıt eder
                SourceImage = imageBox.Image; //her resim değiştiğinde bir değişkene en son hali kayıt ediliyor
                SetInfos(); //bilgileri ekrana gönder
            }
            else
            {
                MessageBox.Show("Resim açılamadı");
            }
        }
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox.SizeMode = PictureBoxSizeMode.Normal;
        }
        private void strecthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void autoSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }
        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }
        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null) // eğer resim var ise işlemi yap , seçilmemişse hata ver
            {
                Form form = new HistogramGray(imageBox.Image);
                form.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }

        }
        private void griTonlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {

                imageBox.Image = new GrayScaling().Scale(imageBox.Image);
                AddHistory(imageBox.Image, "Gri Tonlama");
                SourceImage = imageBox.Image;
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }

        }
        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {
                new FileProcess().SaveImage(FilePath, imageBox.Image);
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }

        }
        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void terslemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {

                imageBox.Image = new InvertNegative().Invert(imageBox.Image);
                AddHistory(imageBox.Image, "Tersleme");
                SourceImage = imageBox.Image;
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }
        private void solaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {

                imageBox.Image = new Rotate().RotateLeft(imageBox.Image);
                AddHistory(imageBox.Image, "Sola Döndür");
                SourceImage = imageBox.Image;
                SetInfos();
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }
        private void sağaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {

                imageBox.Image = new Rotate().RotateRight(imageBox.Image);
                AddHistory(imageBox.Image, "Sağa Döndür");
                SourceImage = imageBox.Image;
                SetInfos();
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }
        private void yenidenAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {

                imageBox.Image = new FileProcess().ReOpenImage();
                AddHistory(imageBox.Image, "Yeniden Aç");
                SourceImage = imageBox.Image;
                SetInfos();
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }
        private void sağdanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {

                imageBox.Image = new Mirror().SetMirror(imageBox.Image, Mirror.Direction.Right);
                AddHistory(imageBox.Image, "Sağa Aynala");
                SourceImage = imageBox.Image;
                SetInfos();
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }

        }
        private void soldanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {

                imageBox.Image = new Mirror().SetMirror(imageBox.Image, Mirror.Direction.Left);
                AddHistory(imageBox.Image, "Soldan Aynala");
                SourceImage = imageBox.Image;
                SetInfos();
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }
        private void rGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {
                Form form = new HistogramColor(imageBox.Image);
                form.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }
        private void boyutlandırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {
                Form form = new ReSizeForm(imageBox, this);
                form.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }
        private void renkKanallerıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {
                Form form = new ChannelsForm(imageBox.Image);
                form.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }
        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image image = BackHistory();
            if (image != null)
            {
                imageBox.Image = image;
                SetInfos();
            }



        }

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && (e.Control))
            {
                Image image = BackHistory();
                if (image != null)
                {
                    imageBox.Image = image;
                    SetInfos();
                }
            }
        }

        public void SetInfos() // Ana Formda ki  Bilgiler Kısmı
        {
            if (imageBox.Image != null)
            {
                int w = imageBox.Image.Width;
                int h = imageBox.Image.Height;
                string f = Path.GetExtension(FilePath); // Dosya uzantısı xxx.PNG
                string r = w.ToString() + "x" + h.ToString();
                label3.Text = w.ToString();
                label4.Text = h.ToString();
                label7.Text = f;
                label8.Text = r;
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }

        }
        private void jPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {
                string path = new FileProcess().AsSaveImage(FileName, imageBox.Image, ImageFormat.Jpeg);
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }

        private void jPEGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {
                string path = new FileProcess().AsSaveImage(FileName, imageBox.Image, ImageFormat.Jpeg);
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }

        private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {
                string path = new FileProcess().AsSaveImage(FileName, imageBox.Image, ImageFormat.Png);
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }

        private void bMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {
                string path = new FileProcess().AsSaveImage(FileName, imageBox.Image, ImageFormat.Bmp);
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }

        private void ıCOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {
                string path = new FileProcess().AsSaveImage(FileName, imageBox.Image, ImageFormat.Icon);
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }

        private void tIFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {
                string path = new FileProcess().AsSaveImage(FileName, imageBox.Image, ImageFormat.Tiff);
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {
                imageBox.Image = BackHistory(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {
                imageBox.Image = new Channels().GetChannels(SourceImage, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
                AddHistory(imageBox.Image, "Renk Kanalları");
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }

        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {

                imageBox.Image = new Channels().GetChannels(SourceImage, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
                AddHistory(imageBox.Image, "Renk Kanalları");
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {
                imageBox.Image = new Channels().GetChannels(SourceImage, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
                AddHistory(imageBox.Image, "Renk Kanalları");
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imageBox.Image != null)
            {
                imageBox.Image = BackHistory();
            }
            else
            {
                MessageBox.Show("Lütfen Önce Resim Seçiniz");
            }
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
