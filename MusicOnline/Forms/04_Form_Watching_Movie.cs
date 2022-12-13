using AxWMPLib;
using MusicOnline.Database.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicOnline.Forms
{
    public partial class _04_Form_Watching_Movie : Form
    {
        bool display_video = false;
        double duration_time = 0.0;
        public _04_Form_Watching_Movie()
        {
            InitializeComponent();
        }

        public _04_Form_Watching_Movie(DataTable movie, double start_time = 0.0) : this()
        {
            Panel_WatchMovie.BackColor = Assets.Variables.Colors.BlackOlive;
            Panel_Body.BackColor = Assets.Variables.Colors.ChineseBlack;
            FlowLayoutPanel_MovieInvolve.BackColor = Assets.Variables.Colors.ChineseBlack;

            DataRow dr = movie.Rows[0];
            WMP_MovieVideo.URL = "movie/" + dr["MOVIE_ID"].ToString() + ".mp4";
            duration_time = Duration("movie/" + dr["MOVIE_ID"].ToString() + ".mp4");
            WMP_MovieVideo.Ctlcontrols.currentPosition = duration_time * start_time / 100.0;
            WMP_MovieVideo.Ctlcontrols.play();
            display_video = true;

            Label_MovieName.Name = dr["MOVIE_ID"].ToString();
            Label_MovieName.Text = dr["MOVIE_NAME"].ToString().ToUpper();
            Label_MovieNameEng.Text = dr["MOVIE_NAME_ENG"].ToString();
        }

        public double Duration(string file)
        {
            WindowsMediaPlayer wmp = new WindowsMediaPlayerClass();
            IWMPMedia mediainfo = wmp.newMedia(file);
            return mediainfo.duration;
        }

        private void WMP_MovieVideo_ClickEvent(object sender, _WMPOCXEvents_ClickEvent e)
        {
            if (display_video)
                WMP_MovieVideo.Ctlcontrols.pause();
            else
                WMP_MovieVideo.Ctlcontrols.play();
            display_video = !display_video;
        }

        private void _04_Form_Watching_Movie_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show(Label_MovieName.Name.ToString());
            //MessageBox.Show(DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt"));
            //MessageBox.Show(Convert.ToInt32((((double)WMP_MovieVideo.Ctlcontrols.currentPosition / duration_time) * 100)).ToString());
            DataProvider provider = new DataProvider();
            string query = $"insert into HISTORY_MOVIE_LIST values('{Label_MovieName.Name}', " +
                $"'{DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt")}', " +
                $"{Convert.ToInt32((((double)WMP_MovieVideo.Ctlcontrols.currentPosition / duration_time) * 100))})";
            provider.ExecuteNonQuery(query);
        }

        //private WindowsMediaPlayer wMP_movie;

        //public WindowsMediaPlayer WMP_movie { get => (WindowsMediaPlayer)WMP_MovieVideo; set => WMP_MovieVideo=(AxWindowsMediaPlayer)value; }
    }
}
