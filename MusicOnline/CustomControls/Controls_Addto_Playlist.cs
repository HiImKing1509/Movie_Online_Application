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

namespace MusicOnline.CustomControls
{
    public partial class Controls_Addto_Playlist : UserControl
    {

        private string _playlistID = null;
        private string _movieID = null;

        public Controls_Addto_Playlist()
        {
        }

        public Controls_Addto_Playlist(DataRow dr, string movie_id)
        {
            InitializeComponent();

            _playlistID = dr["PLAYLIST_ID"].ToString();
            _movieID = movie_id;

            bool check_exist_movie_in_playlist = CheckExist_MovieInPlaylist(_playlistID, _movieID);
            Button_AddToPlaylist.BackColor = Assets.Variables.Colors.MetallicYellow;
            if (check_exist_movie_in_playlist)
            {
                BackColor = Color.Green;
                Button_AddToPlaylist.Visible = false;
            }
            else
            {
                BackColor = Assets.Variables.Colors.ChineseBlack; 
                Button_AddToPlaylist.Visible = true;
            }
            Label_PlaylistName.Text = dr["PLAYLIST_NAME"].ToString();
            Label_Time.Text = dr["PLAYLIST_TIME"].ToString();
        }

        private void Button_AddToPlaylist_Click(object sender, EventArgs e)
        {
            string query = $"insert into PLAYLIST_DETAIL values('{_playlistID}', '{_movieID}', '{DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt")}')";
            DataProvider provider = new DataProvider();
            provider.ExecuteNonQuery(query);
            BackColor = Color.Green;
            Button_AddToPlaylist.Visible = false;
        }

        private bool CheckExist_MovieInPlaylist(string playlist_id, string movie_id)
        {
            string query = $"select [PLAYLIST_ID], PLAYLIST_DETAIL.MOVIE_ID from PLAYLIST_DETAIL inner join MOVIE on PLAYLIST_DETAIL.MOVIE_ID = MOVIE.MOVIE_ID " +
                $"where PLAYLIST_ID = '{playlist_id}' and PLAYLIST_DETAIL.MOVIE_ID = '{movie_id}'";
            DataProvider provider = new DataProvider();

            DataTable dt = provider.ExecuteQuery(query);
            if (dt.Rows.Count != 0)
                return true;
            else
                return false;
        }
    }
}
