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
    public partial class Controls_Movie_Freq : UserControl
    {
        public Controls_Movie_Freq()
        {
            InitializeComponent();
        }

        public Controls_Movie_Freq(Bitmap image, DataRow dr, int num) : this()
        {
            if (num <= 3) Label_Ranking.ForeColor = Assets.Variables.Colors.MetallicYellow; else Label_Ranking.ForeColor = Assets.Variables.Colors.DavyGrey;
            if (num % 2 == 0) BackColor = Assets.Variables.Colors.ChineseBlack; else BackColor = Assets.Variables.Colors.BlackOlive;
            Label_MovieName.Text = dr["MOVIE_NAME"].ToString().ToUpper();
            PictureBox_Image.Image = image;
            Label_NumberAccess.Text = dr["MOVIE_NUMBER_ACCESS"].ToString();
            if (num < 10)
                Label_Ranking.Text = "0" + num.ToString();
            else
                Label_Ranking.Text = num.ToString();
        }
    }
}
