using MusicOnline.Database.DAO;
using MusicOnline.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicOnline.CustomControls
{
    public partial class Controls_Movie : UserControl
    {
        private Form activeForm = null;
        public Controls_Movie()
        {
            InitializeComponent();
        }

        public Controls_Movie(Bitmap img, string id, string name) : this()
        {
            Panel_ControlMovie.Name = id;
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

        private void PictureBox_ImageMovie_Click(object sender, EventArgs e)
        {
            EventClick_MovieDetail();
        }
        private void Label_MovieName_Click(object sender, EventArgs e)
        {
            EventClick_MovieDetail();
        }
        private void Label_Subtitle_Click(object sender, EventArgs e)
        {
            EventClick_MovieDetail();
        }
        private void Panel_MovieName_Click(object sender, EventArgs e)
        {
            EventClick_MovieDetail();
        }

        private void EventClick_MovieDetail()
        {
            ResourceManager getRM = Assets.Variables.ResourcesManager.rm_movies;
            string query = $"select * from MOVIE where MOVIE_ID like '{Panel_ControlMovie.Name}'";
            DataProvider provider = new DataProvider();
            DataTable dtShowMovieDetail = provider.ExecuteQuery(query);
            MessageBox.Show(dtShowMovieDetail.Rows.Count.ToString());
            openChildForm(new _03_Form_Movie_Detail(getRM, dtShowMovieDetail));
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

    }
}
