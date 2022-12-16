using MusicOnline.CustomControls;
using MusicOnline.Database.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicOnline.Forms
{
    public partial class _06_Form_History : Form
    {
        private Form activeForm = null;
        public _06_Form_History()
        {
            InitializeComponent();
            BackColor = Assets.Variables.Colors.ChineseBlack;
            Panel_Tools.BackColor = Assets.Variables.Colors.BlackOlive;
            FlowLayoutPanel_MainPage.BackColor = Assets.Variables.Colors.BlackOlive;
            FlowLayoutPanel_ShowListMovie.BackColor = Assets.Variables.Colors.BlackOlive;
            Button_RemoveAllMovie.BackColor = Assets.Variables.Colors.UERed;

            Load_MyHistoryList();
            Load_MyFreqList();
        }

        private void Load_MyHistoryList()
        {
            string query = "select [HISTORY_MOVIE_ID], [HISTORY_MOVIE_TIME], [HISTORY_MOVIE_DURATION], [MOVIE_NAME], [MOVIE_NAME_ENG], [MOVIE_NUMBER_ACCESS] from HISTORY_MOVIE_LIST left join MOVIE on HISTORY_MOVIE_ID = MOVIE_ID";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyList = provider.ExecuteQuery(query);

            ResourceManager rm;
            if (dtShowMyList.Rows.Count > 0)
            {
                foreach (DataRow row in dtShowMyList.Rows)
                {
                    rm = Assets.Variables.ResourcesManager.rm_movies;
                    Bitmap myImage = (Bitmap)rm.GetObject(row["HISTORY_MOVIE_ID"].ToString());

                    Controls_Movie_History item = new Controls_Movie_History(
                        myImage,
                        row
                    );
                    FlowLayoutPanel_MainPage.Controls.Add(item);
                }
            }
            else
            {
                //rm = CreateResources.Variables.rm_logo;
                //FlowLayoutPanel_OrderProduct.BackgroundImage = (Bitmap)rm.GetObject("No_product");
            }
        }

        private void Load_MyFreqList()
        {
            string query = "select [MOVIE_ID], [MOVIE_NAME], [MOVIE_NUMBER_ACCESS] from MOVIE where MOVIE_NUMBER_ACCESS > 0 order by MOVIE_NUMBER_ACCESS desc";

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

                    Controls_Movie_Freq item = new Controls_Movie_Freq(
                        myImage,
                        row,
                        i++
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

        private void Button_RemoveAllMovie_Click(object sender, EventArgs e)
        {
            string query = "delete from HISTORY_MOVIE_LIST";

            DataProvider provider = new DataProvider();
            provider.ExecuteNonQuery(query);

            openChildForm(new _06_Form_History());
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
