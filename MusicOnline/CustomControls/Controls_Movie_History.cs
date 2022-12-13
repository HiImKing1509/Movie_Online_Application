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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MusicOnline.CustomControls
{
    public partial class Controls_Movie_History : UserControl
    {
        private Form activeForm = null;

        public Controls_Movie_History()
        {
            //InitializeComponent();
        }

        public Controls_Movie_History(Bitmap image, DataRow dr) : this()
        {
            InitializeComponent();

            BackColor = Assets.Variables.Colors.ChineseBlack;
            Button_DetailMovie.BackColor = Assets.Variables.Colors.MetallicYellow;
            Label_Time.ForeColor = Assets.Variables.Colors.MetallicYellow;
            Label_Duration.ForeColor = Assets.Variables.Colors.MetallicYellow;

            PictureBox_Image.Image = image;
            Label_MovieName.Name = dr["HISTORY_MOVIE_ID"].ToString();
            Label_MovieName.Text = dr["MOVIE_NAME"].ToString().ToUpper();
            Label_MovieNameEng.Text = dr["MOVIE_NAME_ENG"].ToString();
            Label_Time.Text = dr["HISTORY_MOVIE_TIME"].ToString();
            Label_Duration.Text = dr["HISTORY_MOVIE_DURATION"].ToString() + "%";
        }

        private void Button_DetailMovie_Click(object sender, EventArgs e)
        {
            UpdateNumberOfAccess(Label_MovieName.Name);
            DataProvider provider = new DataProvider();
            string query = $"select * from HISTORY_MOVIE_LIST inner join MOVIE on HISTORY_MOVIE_ID = MOVIE_ID and MOVIE_ID = '{Label_MovieName.Name}' and HISTORY_MOVIE_TIME = '{Label_Time.Text}'";
            DataTable dt = provider.ExecuteQuery(query);
            openChildForm(new Forms._04_Form_Watching_Movie(dt, Convert.ToDouble(Label_Duration.Text.ToString().Substring(0, Label_Duration.Text.ToString().Length -1))));
            query = $"delete from HISTORY_MOVIE_LIST where HISTORY_MOVIE_ID = '{Label_MovieName.Name}' and HISTORY_MOVIE_TIME = '{Label_Time.Text}'";
            provider.ExecuteNonQuery(query);
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

        private void Button_RemoveMovie_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query = $"delete from HISTORY_MOVIE_LIST where HISTORY_MOVIE_ID = '{Label_MovieName.Name}' and HISTORY_MOVIE_TIME = '{Label_Time.Text}'";

            provider.ExecuteNonQuery(query);
            openChildForm(new Forms._06_Form_History());
        }
        private void UpdateNumberOfAccess(string id)
        {
            DataProvider provider = new DataProvider();
            string query = $"update MOVIE set MOVIE_NUMBER_ACCESS = MOVIE_NUMBER_ACCESS + 1 where MOVIE_ID = '{id}'";
            provider.ExecuteNonQuery(query);
        }
    }
}
