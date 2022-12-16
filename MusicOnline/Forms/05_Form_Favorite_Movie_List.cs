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
        private Form activeForm = null;

        public _05_Form_Favorite_Movie_List()
        {
            InitializeComponent();
            FlowLayoutPanel_ShowListMovie.BackColor = Assets.Variables.Colors.BlackOlive;
            Panel_Tools.BackColor = Assets.Variables.Colors.ChineseBlack;
            Button_ShowAllMovie.BackColor = Assets.Variables.Colors.MetallicYellow;
            Button_RemoveAllMovie.BackColor = Assets.Variables.Colors.UERed;

            Load_MyFavoriteList();
        }

        private void Load_MyFavoriteList()
        {
            string query = "select * from MOVIE where MOVIE_LOVE_STATUS = 1";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyList = provider.ExecuteQuery(query);

            Label_NumberOfMovie.Text = dtShowMyList.Rows.Count.ToString();

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

        private void Button_ShowAllMovie_Click(object sender, EventArgs e)
        {
            openChildForm(new _08_Form_Watching_list_Movie());
        }

        private void Button_RemoveAllMovie_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query = $"update MOVIE set MOVIE_LOVE_STATUS = 0 where MOVIE_LOVE_STATUS = 1";

            provider.ExecuteNonQuery(query);
            openChildForm(new _05_Form_Favorite_Movie_List());
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
