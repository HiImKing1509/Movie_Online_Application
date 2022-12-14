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
    public partial class Controls_getMovie_Playlist : UserControl
    {
        public Controls_getMovie_Playlist()
        {
            //InitializeComponent();
        }

        public Controls_getMovie_Playlist(Bitmap image, DataRow dr, int num) : this()
        {
            InitializeComponent();
            Label_Ranking.ForeColor = Assets.Variables.Colors.DavyGrey;
            if (num % 2 == 0) BackColor = Assets.Variables.Colors.ChineseBlack; else BackColor = Assets.Variables.Colors.BlackOlive;
            PictureBox_Image.Image = image;
            Label_MovieName.Text = dr["MOVIE_NAME"].ToString();
            Label_Time.Text = dr["MOVIE_TIME"].ToString();
            if (num < 10)
                Label_Ranking.Text = "0" + num.ToString();
            else
                Label_Ranking.Text = num.ToString();
        }
    }
}
