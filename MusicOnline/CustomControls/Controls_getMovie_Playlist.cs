using MusicOnline.Database.DAO;
using MusicOnline.Forms;
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

namespace MusicOnline.CustomControls
{
    public partial class Controls_getMovie_Playlist : UserControl
    {
        public Controls_getMovie_Playlist()
        {
            //InitializeComponent();
        }

        public Controls_getMovie_Playlist(Bitmap image, DataRow dr, int num) : this()
        {
            InitializeComponent();
            Name = dr["PLAYLIST_ID"].ToString();
            PictureBox_Image.Name = dr["MOVIE_ID"].ToString();
            Label_Ranking.ForeColor = Assets.Variables.Colors.DavyGrey;
            if (num % 2 == 0) BackColor = Assets.Variables.Colors.ChineseBlack; else BackColor = Assets.Variables.Colors.BlackOlive;
            PictureBox_Image.Image = image;
            Label_MovieName.Text = dr["MOVIE_NAME"].ToString();
            Label_Time.Text = dr["MOVIE_TIME"].ToString();
            if (num < 10)
                Label_Ranking.Text = "0" + num.ToString();
            else
                Label_Ranking.Text = num.ToString();
        }

        private void Button_RemoveMovie_Click(object sender, EventArgs e)
        {
            string query = $"delete from PLAYLIST_DETAIL where PLAYLIST_ID = '{Name}' and MOVIE_ID = '{PictureBox_Image.Name}'";
            DataProvider provider = new DataProvider();

            provider.ExecuteNonQuery(query);
            Load_MyPlayList();
            Load_MovieInPlaylist(Name);
        }

        private void Load_MovieInPlaylist(string id)
        {
            Assets.Variables.ListFormPanel.ListFormsPanel[1].Controls.Clear();
            string query = $"select [PLAYLIST_ID], PLAYLIST_DETAIL.MOVIE_ID, PLAYLIST_DETAIL.MOVIE_TIME, [MOVIE_NAME] from PLAYLIST_DETAIL inner join MOVIE on PLAYLIST_DETAIL.MOVIE_ID = MOVIE.MOVIE_ID where PLAYLIST_ID = '{id}'";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyList = provider.ExecuteQuery(query);
            ResourceManager rm;
            if (dtShowMyList.Rows.Count > 0)
            {
                int i = 1;
                foreach (DataRow row in dtShowMyList.Rows)
                {
                    rm = Assets.Variables.ResourcesManager.rm_movies;
                    Bitmap myImage = (Bitmap)rm.GetObject(row["MOVIE_ID"].ToString());

                    Controls_getMovie_Playlist item = new Controls_getMovie_Playlist(
                        myImage,
                        row,
                        i++
                    );
                    Assets.Variables.ListFormPanel.ListFormsPanel[1].Controls.Add(item);
                }
            }
            else
            {
                //rm = CreateResources.Variables.rm_logo;
                //FlowLayoutPanel_OrderProduct.BackgroundImage = (Bitmap)rm.GetObject("No_product");
            }
        }

        private void Load_MyPlayList()
        {
            Assets.Variables.ListFormPanel.ListFormsPanel[2].Controls.Clear();
            string query = "select * from PLAYLIST";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyList = provider.ExecuteQuery(query);


            ResourceManager rm;
            if (dtShowMyList.Rows.Count > 0)
            {
                foreach (DataRow row in dtShowMyList.Rows)
                {
                    rm = Assets.Variables.ResourcesManager.rm_logo;
                    Bitmap myImage = (Bitmap)rm.GetObject(row["PLAYLIST_LOGO"].ToString());

                    Custom_Playlist item = new Custom_Playlist(
                        myImage,
                        row
                    );
                    Assets.Variables.ListFormPanel.ListFormsPanel[2].Controls.Add(item);
                }
            }
            else
            {
                //rm = CreateResources.Variables.rm_logo;
                //FlowLayoutPanel_OrderProduct.BackgroundImage = (Bitmap)rm.GetObject("No_product");
            }
        }
    }
}
