using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Photo_Editor.Helpers;

namespace Photo_Editor
{
    public partial class ReSizeForm : Form
    {
        private PictureBox _pictureBox;
        private Home _home;
        public ReSizeForm(PictureBox pictureBox, Home home)
        {
            _pictureBox = pictureBox;
            _home = home;

            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ratioBox.Visible = true;
                valueBox.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                ratioBox.Visible = false;
                valueBox.Visible = true;
            }
        }
        private void ReSizeForm_Load(object sender, EventArgs e)
        {
            widthValue.Text = _pictureBox.Image.Width.ToString();
            heightValue.Text = _pictureBox.Image.Height.ToString();
            heightBar.Maximum = 300;
            heightBar.Minimum = 0;
            widthBar.Maximum = 300;
            heightBar.Minimum = 0;

            heightBar.Value = 100;
            widthBar.Value = 100;
            textBox1.Text = widthBar.Value.ToString();
            textBox2.Text = heightBar.Value.ToString();
        }

        private void widthValue_TextChanged(object sender, EventArgs e)
        {
            if (!widthValue.Focused)
                return;

            int newWitdh;
            if (int.TryParse(widthValue.Text, out newWitdh))
            {
                if (checkBox2.Checked)
                {
                    heightValue.Text = ((int)(((double)newWitdh / (double)_pictureBox.Image.Width) * (double)_pictureBox.Image.Height)).ToString();
                }
            }
            else
            {
                MessageBox.Show("Girilen değer uyumsuz");
                widthValue.Text = _pictureBox.Image.Width.ToString();
            }
        }

        private void heightValue_TextChanged(object sender, EventArgs e)
        {
            if (!heightValue.Focused)
                return;

            int newHeight;
            if (int.TryParse(heightValue.Text, out newHeight))
            {
                if (checkBox2.Checked)
                {
                    widthValue.Text = ((int)(((double)newHeight / (double)_pictureBox.Image.Height) * (double)_pictureBox.Image.Width)).ToString();
                }
            }
            else
            {
                MessageBox.Show("Girilen değer uyumsuz");
                heightValue.Text = _pictureBox.Image.Height.ToString();
            }
        }

        private void reSizeBtn_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Home.AddHistory(_pictureBox.Image, "Yeniden Boyutlandır");
                _pictureBox.Image = new ReSize().ScaleByValue(_pictureBox.Image, int.Parse(widthValue.Text), int.Parse(heightValue.Text));
            }
            else
            {
                Home.AddHistory(_pictureBox.Image, "Yeniden Boyutlandır");
                _pictureBox.Image = new ReSize().ScaleByRatio(_pictureBox.Image, double.Parse(textBox1.Text) / 100.0F, double.Parse(textBox2.Text) / 100.0F);
            }
            _home.SetInfos();
            this.Close();
        }

        private void widthBar_Scroll(object sender, EventArgs e)
        {
            if (!widthBar.Focused)
                return;
            if (checkBox1.Checked)
                heightBar.Value = widthBar.Value;

            textBox1.Text = widthBar.Value.ToString();
            textBox2.Text = heightBar.Value.ToString();
        }

        private void heightBar_Scroll(object sender, EventArgs e)
        {
            if (!heightBar.Focused)
                return;
            if (checkBox1.Checked)
                heightBar.Value = heightBar.Value;

            textBox1.Text = widthBar.Value.ToString();
            textBox2.Text = heightBar.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!textBox1.Focused)
                return;

            int newWitdh;
            if (int.TryParse(textBox1.Text, out newWitdh))
            {
                if (checkBox1.Checked)
                {
                    textBox2.Text = textBox1.Text;
                }
            }
            else
            {
                MessageBox.Show("Girilen değer uyumsuz");
                textBox1.Text = widthBar.Value.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!textBox2.Focused)
                return;

            int newHeight;
            if (int.TryParse(textBox2.Text, out newHeight))
            {
                if (checkBox1.Checked)
                {
                    textBox1.Text = textBox2.Text;
                }
            }
            else
            {
                MessageBox.Show("Girilen değer uyumsuz");
                textBox2.Text = heightBar.Value.ToString();
            }
        }
    }
}
