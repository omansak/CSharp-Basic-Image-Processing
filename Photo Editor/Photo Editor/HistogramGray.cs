using Photo_Editor.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Photo_Editor
{
    public partial class HistogramGray : Form
    {
        private readonly Image _image;
        public HistogramGray(Image image)
        {
            _image = image;
            InitializeComponent();
        }
        private void HistogramGray_Load(object sender, EventArgs e)
        {
            grayBox.Image = new HistogramCustom().Gray(_image);
        }

    }
}
