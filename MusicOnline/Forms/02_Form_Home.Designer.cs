namespace MusicOnline.Forms
{
    partial class _02_Form_Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Button_History = new FontAwesome.Sharp.IconButton();
            this.Button_FavoritesList = new FontAwesome.Sharp.IconButton();
            this.Button_Playlist = new FontAwesome.Sharp.IconButton();
            this.Button_Home = new FontAwesome.Sharp.IconButton();
            this.Panel_Logo = new System.Windows.Forms.Panel();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Panel_Footer = new System.Windows.Forms.Panel();
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.Panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_Menu.Controls.Add(this.Button_History);
            this.Panel_Menu.Controls.Add(this.Button_FavoritesList);
            this.Panel_Menu.Controls.Add(this.Button_Playlist);
            this.Panel_Menu.Controls.Add(this.Button_Home);
            this.Panel_Menu.Controls.Add(this.Panel_Logo);
            this.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(336, 1033);
            this.Panel_Menu.TabIndex = 0;
            // 
            // Button_History
            // 
            this.Button_History.BackColor = System.Drawing.Color.Transparent;
            this.Button_History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_History.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_History.FlatAppearance.BorderSize = 0;
            this.Button_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_History.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_History.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.Button_History.IconColor = System.Drawing.Color.Black;
            this.Button_History.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_History.IconSize = 28;
            this.Button_History.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_History.Location = new System.Drawing.Point(0, 403);
            this.Button_History.Name = "Button_History";
            this.Button_History.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_History.Size = new System.Drawing.Size(336, 68);
            this.Button_History.TabIndex = 4;
            this.Button_History.Text = "Lịch sử xem phim";
            this.Button_History.UseVisualStyleBackColor = false;
            this.Button_History.Click += new System.EventHandler(this.Button_History_Click);
            // 
            // Button_FavoritesList
            // 
            this.Button_FavoritesList.BackColor = System.Drawing.Color.Transparent;
            this.Button_FavoritesList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_FavoritesList.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_FavoritesList.FlatAppearance.BorderSize = 0;
            this.Button_FavoritesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FavoritesList.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FavoritesList.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.Button_FavoritesList.IconColor = System.Drawing.Color.Black;
            this.Button_FavoritesList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_FavoritesList.IconSize = 28;
            this.Button_FavoritesList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_FavoritesList.Location = new System.Drawing.Point(0, 335);
            this.Button_FavoritesList.Name = "Button_FavoritesList";
            this.Button_FavoritesList.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_FavoritesList.Size = new System.Drawing.Size(336, 68);
            this.Button_FavoritesList.TabIndex = 3;
            this.Button_FavoritesList.Text = "Danh sách yêu thích";
            this.Button_FavoritesList.UseVisualStyleBackColor = false;
            this.Button_FavoritesList.Click += new System.EventHandler(this.Button_FavoritesList_Click);
            // 
            // Button_Playlist
            // 
            this.Button_Playlist.BackColor = System.Drawing.Color.Transparent;
            this.Button_Playlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Playlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Playlist.FlatAppearance.BorderSize = 0;
            this.Button_Playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Playlist.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Playlist.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            this.Button_Playlist.IconColor = System.Drawing.Color.Black;
            this.Button_Playlist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Playlist.IconSize = 28;
            this.Button_Playlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Playlist.Location = new System.Drawing.Point(0, 267);
            this.Button_Playlist.Name = "Button_Playlist";
            this.Button_Playlist.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_Playlist.Size = new System.Drawing.Size(336, 68);
            this.Button_Playlist.TabIndex = 2;
            this.Button_Playlist.Text = "Playlist";
            this.Button_Playlist.UseVisualStyleBackColor = false;
            this.Button_Playlist.Click += new System.EventHandler(this.Button_Playlist_Click);
            // 
            // Button_Home
            // 
            this.Button_Home.BackColor = System.Drawing.Color.Transparent;
            this.Button_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Home.FlatAppearance.BorderSize = 0;
            this.Button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Home.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Button_Home.IconColor = System.Drawing.Color.Black;
            this.Button_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Home.IconSize = 28;
            this.Button_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Home.Location = new System.Drawing.Point(0, 199);
            this.Button_Home.Name = "Button_Home";
            this.Button_Home.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_Home.Size = new System.Drawing.Size(336, 68);
            this.Button_Home.TabIndex = 1;
            this.Button_Home.Text = "Trang chủ";
            this.Button_Home.UseVisualStyleBackColor = false;
            this.Button_Home.Click += new System.EventHandler(this.Button_Home_Click);
            // 
            // Panel_Logo
            // 
            this.Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.Panel_Logo.Name = "Panel_Logo";
            this.Panel_Logo.Size = new System.Drawing.Size(336, 199);
            this.Panel_Logo.TabIndex = 0;
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(336, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(1566, 199);
            this.Panel_Header.TabIndex = 1;
            // 
            // Panel_Footer
            // 
            this.Panel_Footer.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Footer.Location = new System.Drawing.Point(336, 950);
            this.Panel_Footer.Name = "Panel_Footer";
            this.Panel_Footer.Size = new System.Drawing.Size(1566, 83);
            this.Panel_Footer.TabIndex = 3;
            // 
            // Panel_Body
            // 
            this.Panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Body.Location = new System.Drawing.Point(336, 199);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(1566, 751);
            this.Panel_Body.TabIndex = 4;
            // 
            // _02_Form_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.Panel_Body);
            this.Controls.Add(this.Panel_Footer);
            this.Controls.Add(this.Panel_Header);
            this.Controls.Add(this.Panel_Menu);
            this.Name = "_02_Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_02_Form_Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Panel Panel_Footer;
        private System.Windows.Forms.Panel Panel_Body;
        private System.Windows.Forms.Panel Panel_Logo;
        private FontAwesome.Sharp.IconButton Button_Home;
        private FontAwesome.Sharp.IconButton Button_History;
        private FontAwesome.Sharp.IconButton Button_FavoritesList;
        private FontAwesome.Sharp.IconButton Button_Playlist;
    }
}