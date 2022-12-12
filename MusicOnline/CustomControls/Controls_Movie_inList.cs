using MusicOnline.Database.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MusicOnline.CustomControls
{
    public partial class Controls_Movie_inList : UserControl
    {
        private Form activeForm = null;
        private string status = "0";
        public Controls_Movie_inList()
        {

        }

        public Controls_Movie_inList(Bitmap image, DataRow dr) : this()
        {
            InitializeComponent();

            BackColor = Assets.Variables.Colors.ChineseBlack;
            Button_DetailMovie.BackColor = Assets.Variables.Colors.MetallicYellow;

            PictureBox_Image.Image = image;
            Label_MovieName.Name = dr["MOVIE_ID"].ToString();
            Label_MovieName.Text = dr["MOVIE_NAME"].ToString().ToUpper();
            Label_MovieNameEng.Text = dr["MOVIE_NAME_ENG"].ToString();
            Label_Year.Text = dr["MOVIE_YEAR"].ToString();
            status = dr["MOVIE_LOVE_STATUS"].ToString();
        }

        private void Button_DetailMovie_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Assets.Variables.ResourcesManager.rm_movies.GetObject(Label_MovieName.Name);
            
            DataProvider provider = new DataProvider();
            string query = $"select * from MOVIE where MOVIE_ID = '{Label_MovieName.Name}'";
            DataTable dt = provider.ExecuteQuery(query);
            openChildForm(new Forms._03_Form_Movie_Detail(myImage, dt));
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

            //string query = $"delete from FAVORITE_MOVIE_LIST where FAVORITE_MOVIE_ID = '{Label_MovieName.Name}'";
            int i;
            if (status == "1") i = 0;
            else i = 1;
            string query = $"update MOVIE set MOVIE_LOVE_STATUS = {i} where MOVIE_ID = '{Label_MovieName.Name}'";

            provider.ExecuteNonQuery(query);
            openChildForm(new Forms._05_Form_Favorite_Movie_List());
        }
    }
}
