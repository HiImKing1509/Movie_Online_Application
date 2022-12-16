using MusicOnline.Forms;
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
    public partial class Controls_List_Movie_watching : UserControl
    {
        private Form activeForm = null;
        private int num_color = 0;
        public Controls_List_Movie_watching()
        {
            //InitializeComponent();
        }

        public Controls_List_Movie_watching(Bitmap image, DataRow dr, int num) : this()
        {
            InitializeComponent();
            num_color = num;
            Name = dr["PLAYLIST_ID"].ToString();
            PictureBox_Image.Name = dr["MOVIE_ID"].ToString();
            Label_Ranking.ForeColor = Assets.Variables.Colors.DavyGrey;
            if (num % 2 == 0) BackColor = Assets.Variables.Colors.ChineseBlack; else BackColor = Assets.Variables.Colors.BlackOlive;
            PictureBox_Image.Image = image;
            Label_MovieName.Text = dr["MOVIE_NAME"].ToString().ToUpper();
            if (num < 10)
                Label_Ranking.Text = "0" + num.ToString();
            else
                Label_Ranking.Text = num.ToString();
        }

        private void Controls_List_Movie_watching_Click(object sender, EventArgs e)
        {
            openChildForm(new _08_Form_Watching_list_Movie(Name, PictureBox_Image.Name));
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

        private void Controls_List_Movie_watching_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Assets.Variables.Colors.MetallicYellow;
        }

        private void Controls_List_Movie_watching_MouseLeave(object sender, EventArgs e)
        {
            if (num_color % 2 == 0) 
                BackColor = Assets.Variables.Colors.ChineseBlack;
            else 
                BackColor = Assets.Variables.Colors.BlackOlive;
        }
    }
}
