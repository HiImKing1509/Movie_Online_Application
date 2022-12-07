using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicOnline.CustomControls
{
    public partial class Controls_Movie : UserControl
    {
        public Controls_Movie()
        {
            InitializeComponent();
        }

        public Controls_Movie(Bitmap img, string name) : this()
        {
            Panel_ControlMovie.BackColor = Assets.Variables.Colors.BlackOlive;
            PictureBox_ImageMovie.Image = img;
            Label_MovieName.Text = name;
        }

        private void PictureBox_ImageMovie_MouseEnter(object sender, EventArgs e)
        {
            Panel_MovieName.BackColor = Assets.Variables.Colors.MetallicYellow;
            Label_MovieName.ForeColor = Assets.Variables.Colors.Black;
            Panel_MovieName.Dock = DockStyle.Bottom;
            PictureBox_ImageMovie.Dock = DockStyle.Fill;
        }

        private void PictureBox_ImageMovie_MouseLeave(object sender, EventArgs e)
        {
            Panel_MovieName.BackColor = Assets.Variables.Colors.Black;
            Label_MovieName.ForeColor = Color.White;
            Panel_MovieName.Dock = DockStyle.None;
            PictureBox_ImageMovie.Dock = DockStyle.None;
        }
    }
}
