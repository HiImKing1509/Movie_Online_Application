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

namespace MusicOnline.Forms
{
    public partial class _03_Form_Movie_Detail : Form
    {
        public _03_Form_Movie_Detail()
        {
            //InitializeComponent();
        }

        public _03_Form_Movie_Detail(ResourceManager rm, DataTable dt) : this()
        {
            InitializeComponent();
            Panel_Details.BackColor = Assets.Variables.Colors.ChineseBlack;
            Panel_MovieInformation.BackColor = Assets.Variables.Colors.BlackOlive;
            Panel_MovieContent.BackColor = Assets.Variables.Colors.BlackOlive;
            Panel_MovieEvaluation.BackColor = Assets.Variables.Colors.BlackOlive;
            Panel_MovieName.BackColor = Assets.Variables.Colors.ChineseBlack;

            Label_MovieName.ForeColor = Assets.Variables.Colors.VividGamboge;

            // Clone data
            DataRow dr = dt.Rows[0];
            PictureBox_MovieImage.Image = (Bitmap)rm.GetObject(dr["MOVIE_ID"].ToString());
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
            //
        }
    }
}
