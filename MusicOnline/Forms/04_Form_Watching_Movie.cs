using AxWMPLib;
using MusicOnline.CustomControls;
using MusicOnline.Database.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
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
            Panel_CommentInfo.BackColor = Assets.Variables.Colors.ChineseBlack;

            DataRow dr = movie.Rows[0];
            WMP_MovieVideo.URL = "movie/" + dr["MOVIE_ID"].ToString() + ".mp4";
            duration_time = Duration("movie/" + dr["MOVIE_ID"].ToString() + ".mp4");
            WMP_MovieVideo.Ctlcontrols.currentPosition = duration_time * start_time / 100.0;
            WMP_MovieVideo.Ctlcontrols.play();
            display_video = true;

            Label_MovieName.Name = dr["MOVIE_ID"].ToString();
            Label_MovieName.Text = dr["MOVIE_NAME"].ToString().ToUpper();
            Label_MovieNameEng.Text = dr["MOVIE_NAME_ENG"].ToString();

            Load_Comment(dr["MOVIE_ID"].ToString());
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

        private void Load_Comment(string id)
        {
            FlowLayoutPanel_MovieInvolve.Controls.Clear();
            string query = $"select * from COMMENT where COMMENT_MOVIE_ID = '{id}' order by COMMENT_TIME desc";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyList = provider.ExecuteQuery(query);

            if (dtShowMyList.Rows.Count > 0)
            {
                foreach (DataRow row in dtShowMyList.Rows)
                {
                    Controls_Comment item = new Controls_Comment(
                        row
                    );
                    FlowLayoutPanel_MovieInvolve.Controls.Add(item);
                }
            }
            else
            {
                //rm = CreateResources.Variables.rm_logo;
                //FlowLayoutPanel_OrderProduct.BackgroundImage = (Bitmap)rm.GetObject("No_product");
            }
        }

        private void Button_CommentOK_Click(object sender, EventArgs e)
        {
            if (TextBox_Name.Text == "" || TextBox_Comment.Text == "")
                Alert("Vui lòng nhập thông tin", Notification_Form.enmType.Error);
            else
            { 
                Alert("Đã đánh giá", Notification_Form.enmType.Success);
                string query = $"insert into COMMENT values('{Label_MovieName.Name}', N'{TextBox_Name.Text}', N'{TextBox_Comment.Text}', '{DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss")}')";

                DataProvider provider = new DataProvider();
                provider.ExecuteNonQuery(query);
                Load_Comment(Label_MovieName.Name);
                TextBox_Name.Text = "Nhập tên";
                TextBox_Name.ForeColor = Color.Gray;
                TextBox_Comment.Text = "Nhập bình luận";
                TextBox_Comment.ForeColor = Color.Gray;
            }
        }

        private void TextBox_Name_Enter(object sender, EventArgs e)
        {
            if (TextBox_Name.Text == "Nhập tên" && TextBox_Name.ForeColor == Color.Gray)
            {
                TextBox_Name.Text = "";
                TextBox_Name.ForeColor = Assets.Variables.Colors.ChineseBlack;
            }
        }

        private void TextBox_Name_Leave(object sender, EventArgs e)
        {
            if (TextBox_Name.Text == "")
            {
                TextBox_Name.Text = "Nhập tên";
                TextBox_Name.ForeColor = Color.Gray;
            }
        }

        private void TextBox_Comment_Enter(object sender, EventArgs e)
        {
            if (TextBox_Comment.Text == "Nhập bình luận" && TextBox_Comment.ForeColor == Color.Gray)
            {
                TextBox_Comment.Text = "";
                TextBox_Comment.ForeColor = Assets.Variables.Colors.ChineseBlack;
            }
        }

        private void TextBox_Comment_Leave(object sender, EventArgs e)
        {
            if (TextBox_Comment.Text == "")
            {
                TextBox_Comment.Text = "Nhập bình luận";
                TextBox_Comment.ForeColor = Color.Gray;
            }
        }

        public void Alert(string msg, Notification_Form.enmType type)
        {
            Notification_Form frm = new Notification_Form();
            frm.showAlert(msg, type);
        }

        //private WindowsMediaPlayer wMP_movie;

        //public WindowsMediaPlayer WMP_movie { get => (WindowsMediaPlayer)WMP_MovieVideo; set => WMP_MovieVideo=(AxWindowsMediaPlayer)value; }
    }
}
