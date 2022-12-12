using MusicOnline.Database.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MusicOnline.Forms
{
    public partial class _03_Form_Movie_Detail : Form
    {
        private Form activeForm = null;
        private DataTable movie = null;
        private string status = "0";
        public _03_Form_Movie_Detail()
        {
            //InitializeComponent();
        }

        public _03_Form_Movie_Detail(Bitmap image, DataTable dt) : this()
        {
            InitializeComponent();
            movie = dt;

            Panel_Details.BackColor = Assets.Variables.Colors.ChineseBlack;
            Panel_MovieInformation.BackColor = Assets.Variables.Colors.BlackOlive;
            Panel_MovieContent.BackColor = Assets.Variables.Colors.BlackOlive;
            Panel_MovieEvaluation.BackColor = Assets.Variables.Colors.BlackOlive;
            Panel_MovieName.BackColor = Assets.Variables.Colors.ChineseBlack;

            Label_MovieName.ForeColor = Assets.Variables.Colors.VividGamboge;
            Button_DownloadMovie.BackColor = Assets.Variables.Colors.MetallicYellow;

            // Clone data
            DataRow dr = dt.Rows[0];
            PictureBox_MovieImage.Image = image;
            Label_MovieName.Text = dr["MOVIE_NAME"].ToString().ToUpper();
            Label_MovieNameEng.Text = dr["MOVIE_NAME_ENG"].ToString();
            Label_MovieState.Text = dr["MOVIE_STATE"].ToString();
            Label_MovieDirector.Text = dr["MOVIE_DIRECTOR"].ToString();
            Label_MovieTime.Text = dr["MOVIE_TIME"].ToString();
            Label_MovieStatus.Text = dr["MOVIE_STATUS"].ToString();
            Label_MovieLanguage.Text = dr["MOVIE_LANGUAGE"].ToString();
            Label_MovieYear.Text = dr["MOVIE_YEAR"].ToString();
            Label_MovieNation.Text = dr["MOVIE_NATION"].ToString();
            Label_MovieCategory.Text = dr["MOVIE_CATEGORY"].ToString();
            Label_MovieActors.Text = dr["MOVIE_ACTORS"].ToString();
            Label_MovieContent.Text = dr["MOVIE_CONTENT"].ToString();
            Label_MovieTags.Text = dr["MOVIE_TAGS"].ToString();

            UpdateStatusLoveMovie(dr["MOVIE_ID"].ToString());
            //
        }

        private void Button_WatchingMovie_Click(object sender, EventArgs e)
        {
            openChildForm(new _04_Form_Watching_Movie(movie));
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            Assets.Variables.ListFormPanel.ListFormsPanel[0].Controls.Add(childForm);
            Assets.Variables.ListFormPanel.ListFormsPanel[0].Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Button_DownloadMovie_Click(object sender, EventArgs e)
        {
            DataRow dr = movie.Rows[0];
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Folder Selection";

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                using (var client = new WebClient())
                {
                    client.DownloadFile($"movie/{dr["MOVIE_ID"]}.mp4", folderPath + $"/{dr["MOVIE_ID"]}.mp4");
                }
                Alert("Tải phim thành công !", Notification_Form.enmType.Success);
            }
            else
                Alert("Tải phim thất bại !", Notification_Form.enmType.Error);
        }
        public void Alert(string msg, Notification_Form.enmType type)
        {
            Notification_Form frm = new Notification_Form();
            frm.showAlert(msg, type);
        }

        private void Button_LoveMovie_Click(object sender, EventArgs e)
        {
            DataRow dr = movie.Rows[0];
            DataProvider provider = new DataProvider();
            int i;
            if (status == "1") i = 0;
            else i = 1;
            string query = $"update MOVIE set MOVIE_LOVE_STATUS = {i} where MOVIE_ID = '{dr["MOVIE_ID"]}'";

            provider.ExecuteNonQuery(query);
            if (status == "1") status = "0";
            else status = "1";
            UpdateStatusLoveMovie(dr["MOVIE_ID"].ToString());
        }

        private void UpdateStatusLoveMovie(string id)
        {
            DataProvider provider = new DataProvider();
            string query = $"select * from MOVIE where MOVIE_ID = '{id}'";
            DataTable dt = provider.ExecuteQuery(query);

            DataRow dr = dt.Rows[0];
            if (dr["MOVIE_LOVE_STATUS"].ToString() == "0")
            {
                status = "0";
                Button_LoveMovie.Text = "Yêu thích";
                Button_LoveMovie.BackColor = Assets.Variables.Colors.UERed;
            }
            else
            {
                status = "1";
                Button_LoveMovie.Text = "Bỏ yêu thích";
                Button_LoveMovie.BackColor = Color.Green;
            }
        }
    }
}
