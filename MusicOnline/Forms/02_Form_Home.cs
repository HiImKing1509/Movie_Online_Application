using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, Button_Home.Height);
            Panel_Menu.Controls.Add(leftBorderBtn);
            ActivateButton(Button_Home);
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
    }
}
