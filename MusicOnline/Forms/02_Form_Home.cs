using AxWMPLib;
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
using WMPLib;

namespace MusicOnline.Forms
{
    public partial class _02_Form_Home : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form activeForm = null;
        public _02_Form_Home()
        {

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;

            // Set color
            Panel_Logo.BackColor = Assets.Variables.Colors.SmokyBlack;
            Panel_Menu.BackColor = Assets.Variables.Colors.RaisinBlack;
            Panel_Header.BackColor = Assets.Variables.Colors.RaisinBlack;
            Panel_Body.BackColor = Assets.Variables.Colors.BlackOlive;

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

            Button_MovieCategory.ForeColor = Assets.Variables.Colors.MetallicYellow;
            Button_MovieCountry.ForeColor = Assets.Variables.Colors.MetallicYellow;
            Button_MovieTM.ForeColor = Assets.Variables.Colors.MetallicYellow;
            Button_MovieCR.ForeColor = Assets.Variables.Colors.MetallicYellow;
            Button_NewMovie.ForeColor = Assets.Variables.Colors.MetallicYellow;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, Button_Home.Height);
            Panel_Menu.Controls.Add(leftBorderBtn);


            // Add list controls
            Assets.Variables.ListFormPanel.ListFormsPanel.Add(Panel_Body);

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
            ResetHomePage("select * from MOVIE", Button_Home);
        }

        private void Button_Playlist_Click(object sender, EventArgs e)
        {
            CloseForm();
            ActivateButton(sender);
            openChildForm(new _07_Form_Playlist());
        }

        private void Button_FavoritesList_Click(object sender, EventArgs e)
        {
            CloseForm();
            ActivateButton(sender);
            openChildForm(new _05_Form_Favorite_Movie_List());
        }

        private void Button_History_Click(object sender, EventArgs e)
        {
            CloseForm();
            ActivateButton(sender);
            openChildForm(new _06_Form_History());
        }

        private void ActivateMovies(string query)
        {
            foreach (Control item in Panel_Body.Controls.OfType<FlowLayoutPanel>().ToList())
                Assets.Variables.ListFormPanel.ListFormsPanel[0].Controls.Remove(item);
            foreach (Control item in Panel_Body.Controls.OfType<Form>().ToList())
                Assets.Variables.ListFormPanel.ListFormsPanel[0].Controls.Remove(item);
            FlowLayoutPanel flpShowProduct = new FlowLayoutPanel();
            Assets.Variables.ListFormPanel.ListFormsPanel[0].Controls.Add(flpShowProduct);
            flpShowProduct.Dock = DockStyle.Fill;
            flpShowProduct.AutoScroll = true;

            DataProvider provider = new DataProvider();
            DataTable dtShowProduct = provider.ExecuteQuery(query);

            foreach (DataRow row in dtShowProduct.Rows)
            {
                Bitmap myImage = (Bitmap)Assets.Variables.ResourcesManager.rm_movies.GetObject(row["MOVIE_ID"].ToString());
                Controls_Movie item = new Controls_Movie(
                    myImage,
                    row["MOVIE_ID"].ToString(),
                    row["MOVIE_NAME"].ToString(),
                    row["MOVIE_STATE"].ToString()
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

        private void DropdownMenu_ShowMovieCategory_MouseEnter(object sender, EventArgs e)
        {
            //DropdownMenu_ShowMovieCategory.BackColor = Assets.Variables.Colors.MetallicYellow;
            //DropdownMenu_ShowMovieCategory.MenuItemTextColor = Assets.Variables.Colors.BlackOlive;
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

        private void ResetHomePage(string query, Button btn = null)
        {
            TextBox_MovieSearch.Text = "Tên phim, tên diễn viên ...";
            TextBox_MovieSearch.ForeColor = Color.Gray;
            if (btn != null)
                ActivateButton(btn);
            CloseForm();
            ActivateMovies(query);
        }

        private void CloseForm()
        {
            if (Application.OpenForms.OfType<_04_Form_Watching_Movie>().Count() == 1)
                Application.OpenForms.OfType<_04_Form_Watching_Movie>().First().Close();
            if (Application.OpenForms.OfType<_07_Form_Playlist>().Count() == 1)
                Application.OpenForms.OfType<_07_Form_Playlist>().First().Close();
        }

        private void FilterMovie()
        {
            string query = "select * from MOVIE ";
            if (TextBox_MovieSearch.Text == "Tên phim, tên diễn viên ...")
                query += "where (dbo.LanguageComprehension(MOVIE_NAME) like N'%" + "" + "%' " +
                         "or MOVIE_NAME like N'%" + "" + "%') " +
                         "or (dbo.LanguageComprehension(MOVIE_DIRECTOR) like N'%" + "" + "%' " +
                         "or MOVIE_DIRECTOR like N'%" + "" + "%') " +
                         "or (dbo.LanguageComprehension(MOVIE_ACTORS) like N'%" + "" + "%' " +
                         "or MOVIE_ACTORS like N'%" + "" + "%')";
            else
            {
                query += "where (dbo.LanguageComprehension(MOVIE_NAME) like N'%" + TextBox_MovieSearch.Text + "%' " +
                         "or MOVIE_NAME like N'%" + TextBox_MovieSearch.Text + "%') " +
                         "or (dbo.LanguageComprehension(MOVIE_DIRECTOR) like N'%" + TextBox_MovieSearch.Text + "%' " +
                         "or MOVIE_DIRECTOR like N'%" + TextBox_MovieSearch.Text + "%') " +
                         "or (dbo.LanguageComprehension(MOVIE_ACTORS) like N'%" + TextBox_MovieSearch.Text + "%' " +
                         "or MOVIE_ACTORS like N'%" + TextBox_MovieSearch.Text + "%')";
            }
            //if (CreateResources.Variables.Table != "All")
            //    query += $" and PRODUCT_ID like '{CreateResources.Variables.Table}%'";
            //if (Combobox_FilterColor.Text != "Màu")
            //{
            //    query += $" and PRODUCT_COLOR like N'%" + Combobox_FilterColor.Text + "%'";
            //}
            //if (Combobox_FilterMaterial.Text != "Chất liệu")
            //{
            //    query += $" and PRODUCT_MATERIAL like N'%" + Combobox_FilterMaterial.Text + "%'";
            //}
            //if (Combobox_FilterPrice.Text != "Giá")
            //{
            //    List<string> stringPriceList = Combobox_FilterPrice.Text.Split(" - ").ToList();
            //    query += $" and PRODUCT_PRICE between {stringPriceList[0]} and {stringPriceList[1]}";
            //}
            ActivateMovies(query);
        }

        private void ToolStripMenuItem_Category01_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsi = (ToolStripMenuItem)sender;
            ResetHomePage($"select * from MOVIE where MOVIE_CATEGORY like N'%{tsi.Text}%'", null);
            Label_Breadculum.Text = "Phim " + tsi.Text;
        }

        private void Button_MovieCategory_MouseEnter(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            btn.ForeColor = Assets.Variables.Colors.SmokyBlack;
            btn.BackColor = Assets.Variables.Colors.MetallicYellow;
            btn.IconColor = Assets.Variables.Colors.SmokyBlack;
        }

        private void Button_MovieCategory_MouseLeave(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            btn.ForeColor = Assets.Variables.Colors.MetallicYellow;
            btn.BackColor = Color.Transparent;
            btn.IconColor = Assets.Variables.Colors.MetallicYellow;
        }

        private void Button_MinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button_MaximumForm_Click(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Normal)
            //    this.WindowState = FormWindowState.Maximized;
            //else
            //    this.WindowState = FormWindowState.Normal;
        }

        private void Button_CloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_CloseForm_MouseEnter(object sender, EventArgs e)
        {
            Button_CloseForm.BackColor = Color.Red;
            Button_CloseForm.IconColor = Color.White;
        }

        private void Button_CloseForm_MouseLeave(object sender, EventArgs e)
        {
            Button_CloseForm.IconColor = Color.White;
            Button_CloseForm.BackColor = Color.Transparent;
        }

        private void Button_MovieSearch_Click(object sender, EventArgs e)
        {
            FilterMovie();
        }

        private void TextBox_MovieSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == (char)13)
                FilterMovie();
        }

        private void ToolStripMenuItem_Country01_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsi = (ToolStripMenuItem)sender;
            ResetHomePage($"select * from MOVIE where MOVIE_NATION like N'%{tsi.Text}%'", null);
            Label_Breadculum.Text = "Phim " + tsi.Text;
        }

        private void Button_MovieTM_Click(object sender, EventArgs e)
        {
            ResetHomePage($"select * from MOVIE where dbo.LanguageComprehension(MOVIE_STATE) like N'%thuyet minh%'", null);
            Label_Breadculum.Text = "Phim thuyết minh";
        }

        private void Button_MovieCR_Click(object sender, EventArgs e)
        {
            ResetHomePage($"select * from MOVIE where dbo.LanguageComprehension(MOVIE_CATEGORY) like N'%chieu rap%'", null);
            Label_Breadculum.Text = "Phim chiếu rạp";
        }

        private void Button_NewMovie_Click(object sender, EventArgs e)
        {
            DropdownMenu_ShowNewMovie.Show(Button_NewMovie, 0, Button_MovieCategory.Height);
            Label_Breadculum.Text = "Phim mới";
        }

        private void ToolStripMenuItem_Year_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsi = (ToolStripMenuItem)sender;
            ResetHomePage($"select * from MOVIE where MOVIE_YEAR like N'%{tsi.Text.Substring(5)}%'", null);
            Label_Breadculum.Text = tsi.Text;
        }
    }
}
