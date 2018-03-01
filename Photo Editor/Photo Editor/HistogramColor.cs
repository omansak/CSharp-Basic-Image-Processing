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
    public partial class HistogramColor : Form
    {
        private readonly Image _image;
        public HistogramColor(Image image)
        {
            _image = image;
            InitializeComponent();
        }

        private void HistogramColor_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new HistogramCustom().Colorful(_image);
        }
    }
}
