using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicOnline.Forms
{
    public partial class _04_Form_Watching_Movie : Form
    {
        bool display_video = false;
        public _04_Form_Watching_Movie()
        {
            InitializeComponent();
        }

        public _04_Form_Watching_Movie(DataTable movie) : this()
        {
            Panel_WatchMovie.BackColor = Assets.Variables.Colors.BlackOlive;
            Panel_Body.BackColor = Assets.Variables.Colors.ChineseBlack;
            FlowLayoutPanel_MovieInvolve.BackColor = Assets.Variables.Colors.ChineseBlack;

            DataRow dr = movie.Rows[0];
            WMP_MovieVideo.URL = "movie/" + dr["MOVIE_ID"].ToString() + ".mp4";
            WMP_MovieVideo.Ctlcontrols.play();
            display_video = true;

            Label_MovieName.Text = dr["MOVIE_NAME"].ToString();
            Label_MovieNameEng.Text = dr["MOVIE_NAME_ENG"].ToString();
        }

        private void WMP_MovieVideo_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            if (display_video)
                WMP_MovieVideo.Ctlcontrols.pause();
            else
                WMP_MovieVideo.Ctlcontrols.play();
            display_video = !display_video;
        }
    }
}
