using MusicOnline.CustomControls;
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

namespace MusicOnline.Forms
{
    public partial class _05_Form_Favorite_Movie_List : Form
    {
        public _05_Form_Favorite_Movie_List()
        {
            InitializeComponent();
            FlowLayoutPanel_ShowListMovie.BackColor = Assets.Variables.Colors.BlackOlive;
            Panel_Tools.BackColor = Assets.Variables.Colors.ChineseBlack;

            Load_MyFavoriteList();
        }

        private void Load_MyFavoriteList()
        {
            string query = "select * from MOVIE where MOVIE_LOVE_STATUS = 1";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyList = provider.ExecuteQuery(query);
            ResourceManager rm;
            if (dtShowMyList.Rows.Count > 0)
            {
                foreach (DataRow row in dtShowMyList.Rows)
                {
                    rm = Assets.Variables.ResourcesManager.rm_movies;
                    Bitmap myImage = (Bitmap)rm.GetObject(row["MOVIE_ID"].ToString());

                    Controls_Movie_inList item = new Controls_Movie_inList(
                        myImage,
                        row
                    );
                    FlowLayoutPanel_ShowListMovie.Controls.Add(item);
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
