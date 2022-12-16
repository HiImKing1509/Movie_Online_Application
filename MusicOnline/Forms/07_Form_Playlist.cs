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
using System.Windows.Documents;
using System.Windows.Forms;

namespace MusicOnline.Forms
{
    public partial class _07_Form_Playlist : Form
    {
        private Form activeForm = null;
        public _07_Form_Playlist()
        {
            InitializeComponent();
            Assets.Variables.ListFormPanel.ListFormsPanel.Add(FlowLayoutPanel_Items);
            Assets.Variables.ListFormPanel.ListFormsPanel.Add(FlowLayoutPanel_Main);
            BackColor = Assets.Variables.Colors.BlackOlive;
            Panel_Header.BackColor = Assets.Variables.Colors.ChineseBlack;
            Assets.Variables.ListFormPanel.ListFormsPanel[1].BackColor = Assets.Variables.Colors.ChineseBlack;
            Assets.Variables.ListFormPanel.ListFormsPanel[2].BackColor = Assets.Variables.Colors.ChineseBlack;
            Panel_Tools.BackColor = Assets.Variables.Colors.ChineseBlack;
            Button_CreatePlaylist.BackColor = Assets.Variables.Colors.MetallicYellow;
            Panel_CreatePlaylistInfomation.BackColor = Assets.Variables.Colors.BlackOlive;
            Button_ShowAllMovies.BackColor = Assets.Variables.Colors.MetallicYellow;
            Load_MyPlayList();
        }


        private void _07_Form_Playlist_Load(object sender, EventArgs e)
        {

        }

        private void Load_MyPlayList()
        {
            Assets.Variables.ListFormPanel.ListFormsPanel[2].Controls.Clear();
            Assets.Variables.ListFormPanel.ListFormsPanel[1].Controls.Clear();

            string query = "select * from PLAYLIST";

            DataProvider provider = new DataProvider();
            DataTable dtShowMyList = provider.ExecuteQuery(query);

            Label_NumberOfMovie.Text = dtShowMyList.Rows.Count.ToString();
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

        private void _07_Form_Playlist_FormClosing(object sender, FormClosingEventArgs e)
        {
            Assets.Variables.ListFormPanel.ListFormsPanel.RemoveRange(Assets.Variables.ListFormPanel.ListFormsPanel.Count - 2, Assets.Variables.ListFormPanel.ListFormsPanel.Count - 1);
            Assets.Variables.GlobalVariables.Select_playlist = "";
        }

        private void Button_CreatePlaylist_Click(object sender, EventArgs e)
        {
            Panel_CreatePlaylist.Visible = true;
        }

        private void Button_ClosePanel_Click(object sender, EventArgs e)
        {
            Panel_CreatePlaylist.Visible = false;
        }

        private void TextBox_NamePlaylist_Enter(object sender, EventArgs e)
        {
            if (TextBox_NamePlaylist.Text == "Nhập tên playlist" && TextBox_NamePlaylist.ForeColor == Color.Gray)
            {
                TextBox_NamePlaylist.Text = "";
                TextBox_NamePlaylist.ForeColor = Assets.Variables.Colors.ChineseBlack;
            }
        }

        private void TextBox_NamePlaylist_Leave(object sender, EventArgs e)
        {
            if (TextBox_NamePlaylist.Text == "")
            {
                TextBox_NamePlaylist.Text = "Nhập tên playlist";
                TextBox_NamePlaylist.ForeColor = Color.Gray;
            }
        }

        private void ComboBox_Image_SelectedIndexChanged(object sender, EventArgs e)
        {
            string image;
            switch (ComboBox_Image.Text)
            {
                case "Warwick Dolton":
                    image = "LG07";
                    break;
                case "Jewel Lyons":
                    image = "LG08";
                    break;
                case "Sapphire Haynes":
                    image = "LG09";
                    break;
                case "Tara Howe":
                    image = "LG10";
                    break;
                case "Megan Tyler":
                    image = "LG11";
                    break;
                case "Water Tribe":
                    image = "LG12";
                    break;
                case "Air Nomad":
                    image = "LG13";
                    break;
                default:
                    image = "LG07";
                    break;
            }
            Bitmap myImage = (Bitmap)Assets.Variables.ResourcesManager.rm_logo.GetObject(image);
            PictureBox_Image.Image = myImage;
        }

        private void Button_NewCreate_Click(object sender, EventArgs e)
        {
            string query;
            DataProvider provider = new DataProvider();
            query = "select * from PLAYLIST";
            DataTable dt = provider.ExecuteQuery(query);

            int number_of_playlist = Convert.ToInt16(dt.AsEnumerable().Last()["PLAYLIST_ID"].ToString().Substring(2));

            query = $"select * from PLAYLIST where PLAYLIST_NAME = N'{TextBox_NamePlaylist.Text}'";
            dt = provider.ExecuteQuery(query);
            if (dt.Rows.Count != 0)
                Alert($"Playlist đã tồn tại!", Notification_Form.enmType.Error);
            else
            {
                string a;
                number_of_playlist++;
                if (number_of_playlist < 10)
                    a = "0" + number_of_playlist.ToString();
                else
                    a = number_of_playlist.ToString();

                string image;
                switch (ComboBox_Image.Text)
                {
                    case "Warwick Dolton":
                        image = "LG07";
                        break;
                    case "Jewel Lyons":
                        image = "LG08";
                        break;
                    case "Sapphire Haynes":
                        image = "LG09";
                        break;
                    case "Tara Howe":
                        image = "LG10";
                        break;
                    case "Megan Tyler":
                        image = "LG11";
                        break;
                    case "Water Tribe":
                        image = "LG12";
                        break;
                    case "Air Nomad":
                        image = "LG13";
                        break;
                    default:
                        image = "LG07";
                        break;
                }
                query = $"insert into PLAYLIST values('PL{a}', N'{TextBox_NamePlaylist.Text}', '{DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt")}', '{image}')";
                provider.ExecuteNonQuery(query);
                if (Application.OpenForms.OfType<_07_Form_Playlist>().Count() == 1)
                    Application.OpenForms.OfType<_07_Form_Playlist>().First().Close();
                Alert($"Tạo playlist thành công!", Notification_Form.enmType.Success);
                openChildForm(new _07_Form_Playlist());
            }
        }

        public void Alert(string msg, Notification_Form.enmType type)
        {
            Notification_Form frm = new Notification_Form();
            frm.showAlert(msg, type);
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

        private void Button_ShowAllMovies_Click(object sender, EventArgs e)
        {
            if (Assets.Variables.GlobalVariables.Select_playlist == "")
                Alert($"Chọn playlist", Notification_Form.enmType.Error);
            else
                openChildForm(new _08_Form_Watching_list_Movie(Assets.Variables.GlobalVariables.Select_playlist));
        }

        private void Button_RemoveAllPlaylist_Click(object sender, EventArgs e)
        {
            if (Assets.Variables.GlobalVariables.Select_playlist == "")
                Alert($"Chọn playlist", Notification_Form.enmType.Error);
            else
            {
                DataProvider provider = new DataProvider();
                string query = $"delete from PLAYLIST where PLAYLIST_ID = '{Assets.Variables.GlobalVariables.Select_playlist}'";
                provider.ExecuteNonQuery(query);
                query = $"delete from PLAYLIST_DETAIL where PLAYLIST_ID = '{Assets.Variables.GlobalVariables.Select_playlist}'";
                provider.ExecuteNonQuery(query);
                Load_MyPlayList();
            }
        }
    }
}
