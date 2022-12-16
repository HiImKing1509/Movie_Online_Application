using AxWMPLib;
using MusicOnline.CustomControls;
using MusicOnline.Database.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using WMPLib;

namespace MusicOnline.Forms
{
    public partial class _08_Form_Watching_list_Movie : Form
    {
        DataTable listMovie = null;
        public _08_Form_Watching_list_Movie()
        {
            //InitializeComponent();
        }

        public _08_Form_Watching_list_Movie(string id, string _id = "") : this()
        {
            InitializeComponent();
            BackColor = Assets.Variables.Colors.BlackOlive;
            Panel_Body.BackColor = Assets.Variables.Colors.ChineseBlack;
            FlowLayoutPanel_MovieInvolve.BackColor = Assets.Variables.Colors.ChineseBlack;

            string query = $"select [PLAYLIST_ID], PLAYLIST_DETAIL.MOVIE_ID, [MOVIE_NAME], [MOVIE_NAME_ENG] from PLAYLIST_DETAIL inner join MOVIE on PLAYLIST_DETAIL.MOVIE_ID = MOVIE.MOVIE_ID where PLAYLIST_ID = '{id}'";
            DataProvider provider = new DataProvider();
            listMovie = provider.ExecuteQuery(query);
            if (_id == "")
            {
                Label_MovieName.Text = listMovie.Rows[0]["MOVIE_NAME"].ToString();
                Label_MovieNameEng.Text = listMovie.Rows[0]["MOVIE_NAME_ENG"].ToString();
            }
            else
            {
                query = $"select [PLAYLIST_ID], PLAYLIST_DETAIL.MOVIE_ID, [MOVIE_NAME], [MOVIE_NAME_ENG] from PLAYLIST_DETAIL inner join MOVIE on PLAYLIST_DETAIL.MOVIE_ID = MOVIE.MOVIE_ID where PLAYLIST_ID = '{id}' and PLAYLIST_DETAIL.MOVIE_ID = '{_id}'";
                DataTable oneMovie = provider.ExecuteQuery(query);
                Label_MovieName.Text = oneMovie.Rows[0]["MOVIE_NAME"].ToString();
                Label_MovieNameEng.Text = oneMovie.Rows[0]["MOVIE_NAME_ENG"].ToString();
            }
            Load_MovieInPlaylist(listMovie);
            Load_AllVideo(_id);
        }



        private void Load_MovieInPlaylist(DataTable dtShowMyList)
        {
            FlowLayoutPanel_MovieInvolve.Controls.Clear();
            ResourceManager rm;
            if (dtShowMyList.Rows.Count > 0)
            {
                int i = 1;
                foreach (DataRow row in dtShowMyList.Rows)
                {
                    rm = Assets.Variables.ResourcesManager.rm_movies;
                    Bitmap myImage = (Bitmap)rm.GetObject(row["MOVIE_ID"].ToString());

                    Controls_List_Movie_watching item = new Controls_List_Movie_watching(
                        myImage,
                        row,
                        i++
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

        private void Load_AllVideo(string id_movie)
        {
            if (id_movie != "")
                axWindowsMediaPlayer1.URL = "movie/" + id_movie + ".mp4";
            else
                axWindowsMediaPlayer1.URL = "movie/" + listMovie.Rows[0]["MOVIE_ID"].ToString() + ".mp4";

            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
