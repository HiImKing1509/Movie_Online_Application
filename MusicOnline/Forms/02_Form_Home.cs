using FontAwesome.Sharp;
using MusicOnline.CustomControls;
using MusicOnline.Database.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace MusicOnline.Forms
{
    public partial class _02_Form_Home : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public _02_Form_Home()
        {
            InitializeComponent();
            //WindowState = FormWindowState.Maximized;

            // Set color
            Panel_Logo.BackColor = Assets.Variables.Colors.SmokyBlack;
            Panel_Menu.BackColor = Assets.Variables.Colors.RaisinBlack;
            Panel_Header.BackColor = Assets.Variables.Colors.RaisinBlack;
            Panel_Body.BackColor = Assets.Variables.Colors.BlackOlive;
            Panel_Footer.BackColor = Assets.Variables.Colors.SmokyBlack;

            Button_Home.ForeColor = Assets.Variables.Colors.MetallicYellow;
            Button_Playlist.ForeColor = Assets.Variables.Colors.MetallicYellow;
            Button_FavoritesList.ForeColor = Assets.Variables.Colors.MetallicYellow;
            Button_History.ForeColor = Assets.Variables.Colors.MetallicYellow;
            Button_Home.IconColor = Assets.Variables.Colors.MetallicYellow;
            Button_Playlist.IconColor = Assets.Variables.Colors.MetallicYellow;
            Button_FavoritesList.IconColor = Assets.Variables.Colors.MetallicYellow;
            Button_History.IconColor = Assets.Variables.Colors.MetallicYellow;

            Button_MovieSearch.BackColor = Assets.Variables.Colors.MetallicYellow;
            Button_MovieSearch.IconColor = Assets.Variables.Colors.Black;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, Button_Home.Height);
            Panel_Menu.Controls.Add(leftBorderBtn);
            ActivateButton(Button_Home);
        }

        private void _02_Form_Home_Load(object sender, EventArgs e)
        {
            ActivateMovies("select * from MOVIE");
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Assets.Variables.Colors.BlackOlive;
                currentBtn.ForeColor = Assets.Variables.Colors.MetallicYellow;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Assets.Variables.Colors.MetallicYellow;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = Assets.Variables.Colors.MetallicYellow;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Assets.Variables.Colors.RaisinBlack;
                currentBtn.ForeColor = Assets.Variables.Colors.MetallicYellow;
                currentBtn.IconColor = Assets.Variables.Colors.MetallicYellow;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.Overlay;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Button_Home_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button_Playlist_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button_FavoritesList_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button_History_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void ActivateMovies(string query)
        {
            foreach (Control item in Panel_Body.Controls.OfType<FlowLayoutPanel>().ToList())
                Panel_Body.Controls.Remove(item);
            foreach (Control item in Panel_Body.Controls.OfType<Form>().ToList())
                Panel_Body.Controls.Remove(item);
            FlowLayoutPanel flpShowProduct = new FlowLayoutPanel();
            Panel_Body.Controls.Add(flpShowProduct);
            flpShowProduct.Dock = DockStyle.Fill;
            flpShowProduct.AutoScroll = true;

            DataProvider provider = new DataProvider();
            DataTable dtShowProduct = provider.ExecuteQuery(query);

            ResourceManager rm;
            foreach (DataRow row in dtShowProduct.Rows)
            {
                string str = row["MOVIE_ID"].ToString().Substring(0, 2);
                switch (str)
                {
                    case "MV":
                        rm = Assets.Variables.ResourcesManager.rm_movies;
                        break;
                    default:
                        rm = Assets.Variables.ResourcesManager.rm_movies;
                        break;
                }
                Bitmap myImage = (Bitmap)rm.GetObject(row["MOVIE_ID"].ToString());
                Controls_Movie item = new Controls_Movie(
                    myImage,
                    row["MOVIE_NAME"].ToString()
                );
                flpShowProduct.Controls.Add(item);
            }
        }

        private void TextBox_MovieSearch_Enter(object sender, EventArgs e)
        {
            if (TextBox_MovieSearch.Text == "Tên phim, tên diễn viên ..." && TextBox_MovieSearch.ForeColor == Color.Gray)
            {
                TextBox_MovieSearch.Text = "";
                TextBox_MovieSearch.ForeColor = Assets.Variables.Colors.ChineseBlack;
            }
        }

        private void TextBox_MovieSearch_Leave(object sender, EventArgs e)
        {
            if (TextBox_MovieSearch.Text == "")
            {
                TextBox_MovieSearch.Text = "Tên phim, tên diễn viên ...";
                TextBox_MovieSearch.ForeColor = Color.Gray;
            }
        }

        private void Button_MovieSearch_MouseLeave(object sender, EventArgs e)
        {
            Button_MovieSearch.BackColor = Assets.Variables.Colors.MetallicYellow;
            Button_MovieSearch.IconColor = Assets.Variables.Colors.Black;
        }

        private void Button_MovieCategory_Click(object sender, EventArgs e)
        {
            DropdownMenu_ShowMovieCategory.Show(Button_MovieCategory, 0, Button_MovieCategory.Height);
        }

        private void Button_MovieCountry_Click(object sender, EventArgs e)
        {
            DropdownMenu_ShowMovieCountry.Show(Button_MovieCountry, 0, Button_MovieCategory.Height);
        }
    }
}
