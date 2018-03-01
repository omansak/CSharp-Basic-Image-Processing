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
    public partial class ChannelsForm : Form
    {
        private readonly Image _image;
        public ChannelsForm(Image image)
        {
            _image = image;
            InitializeComponent();
        }

        private void ChannelsForm_Load(object sender, EventArgs e)
        {
            channelBox.Image = _image;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            channelBox.Image = new Channels().GetChannels(_image, checkBox1.Checked, checkBox3.Checked, checkBox2.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            channelBox.Image = new Channels().GetChannels(_image, checkBox1.Checked, checkBox3.Checked, checkBox2.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            channelBox.Image = new Channels().GetChannels(_image, checkBox1.Checked, checkBox3.Checked, checkBox2.Checked);
        }
    }
}
