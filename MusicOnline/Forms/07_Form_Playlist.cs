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
    public partial class _07_Form_Playlist : Form
    {
        public _07_Form_Playlist()
        {
            InitializeComponent();
            Assets.Variables.ListFormPanel.ListFormsPanel.Add(FlowLayoutPanel_Items);
            BackColor = Assets.Variables.Colors.BlackOlive;
            Panel_Header.BackColor = Assets.Variables.Colors.ChineseBlack;
            FlowLayoutPanel_Main.BackColor = Assets.Variables.Colors.ChineseBlack;
            FlowLayoutPanel_Items.BackColor = Assets.Variables.Colors.ChineseBlack;
            Panel_Tools.BackColor = Assets.Variables.Colors.ChineseBlack;
            Load_MyPlayList();
        }

        private void Load_MyPlayList()
        {
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
                    FlowLayoutPanel_Main.Controls.Add(item);
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
