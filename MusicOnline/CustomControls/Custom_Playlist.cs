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
    public partial class Custom_Playlist : UserControl
    {
        public Custom_Playlist()
        {
            //InitializeComponent();
        }

        public Custom_Playlist(Bitmap image, DataRow dr) : this()
        {
            InitializeComponent();
            PictureBox_Image.Name = dr["PLAYLIST_ID"].ToString();
            PictureBox_Image.Image = image;
            Label_PlaylistName.Text = dr["PLAYLIST_NAME"].ToString();
            Label_Time.Text = dr["PLAYLIST_TIME"].ToString();
        }

        private void PictureBox_Image_MouseEnter(object sender, EventArgs e)
        {
            Panel_Information.BackColor = Assets.Variables.Colors.MetallicYellow;
        }

        private void PictureBox_Image_MouseLeave(object sender, EventArgs e)
        {
            Panel_Information.BackColor = Color.Black;
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

        private void PictureBox_Image_Click(object sender, EventArgs e)
        {
            Load_MovieInPlaylist(PictureBox_Image.Name);
        }
    }
}
