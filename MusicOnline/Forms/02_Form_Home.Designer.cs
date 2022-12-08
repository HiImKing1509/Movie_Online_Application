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
            this.components = new System.ComponentModel.Container();
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Button_History = new FontAwesome.Sharp.IconButton();
            this.Button_FavoritesList = new FontAwesome.Sharp.IconButton();
            this.Button_Playlist = new FontAwesome.Sharp.IconButton();
            this.Button_Home = new FontAwesome.Sharp.IconButton();
            this.Panel_Logo = new System.Windows.Forms.Panel();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Button_MovieCountry = new FontAwesome.Sharp.IconButton();
            this.Button_MovieCategory = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_MovieSearch = new FontAwesome.Sharp.IconButton();
            this.TextBox_MovieSearch = new System.Windows.Forms.TextBox();
            this.Panel_Footer = new System.Windows.Forms.Panel();
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.DropdownMenu_ShowMovieCategory = new MusicOnline.Assets.Controls.CustomDropdownMenu(this.components);
            this.cổTrangThầnThoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.võThuậtKiếmHiệpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d = new MusicOnline.Assets.Controls.CustomDropdownMenu(this.components);
            this.DropdownMenu_ShowMovieCountry = new MusicOnline.Assets.Controls.CustomDropdownMenu(this.components);
            this.việtNamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.âuMỹToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_Menu.SuspendLayout();
            this.Panel_Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DropdownMenu_ShowMovieCategory.SuspendLayout();
            this.DropdownMenu_ShowMovieCountry.SuspendLayout();
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
            this.Panel_Header.Controls.Add(this.Button_MovieCountry);
            this.Panel_Header.Controls.Add(this.Button_MovieCategory);
            this.Panel_Header.Controls.Add(this.label1);
            this.Panel_Header.Controls.Add(this.panel1);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(336, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(1566, 199);
            this.Panel_Header.TabIndex = 1;
            // 
            // Button_MovieCountry
            // 
            this.Button_MovieCountry.FlatAppearance.BorderSize = 0;
            this.Button_MovieCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_MovieCountry.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_MovieCountry.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_MovieCountry.IconColor = System.Drawing.Color.Black;
            this.Button_MovieCountry.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_MovieCountry.Location = new System.Drawing.Point(250, 134);
            this.Button_MovieCountry.Name = "Button_MovieCountry";
            this.Button_MovieCountry.Size = new System.Drawing.Size(241, 65);
            this.Button_MovieCountry.TabIndex = 3;
            this.Button_MovieCountry.Text = "Quốc gia";
            this.Button_MovieCountry.UseVisualStyleBackColor = true;
            this.Button_MovieCountry.Click += new System.EventHandler(this.Button_MovieCountry_Click);
            // 
            // Button_MovieCategory
            // 
            this.Button_MovieCategory.FlatAppearance.BorderSize = 0;
            this.Button_MovieCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_MovieCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_MovieCategory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_MovieCategory.IconColor = System.Drawing.Color.Black;
            this.Button_MovieCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_MovieCategory.Location = new System.Drawing.Point(3, 134);
            this.Button_MovieCategory.Name = "Button_MovieCategory";
            this.Button_MovieCategory.Size = new System.Drawing.Size(238, 65);
            this.Button_MovieCategory.TabIndex = 2;
            this.Button_MovieCategory.Text = "Thể loại";
            this.Button_MovieCategory.UseVisualStyleBackColor = true;
            this.Button_MovieCategory.Click += new System.EventHandler(this.Button_MovieCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Công cụ tìm kiếm phim";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Button_MovieSearch);
            this.panel1.Controls.Add(this.TextBox_MovieSearch);
            this.panel1.Location = new System.Drawing.Point(40, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 54);
            this.panel1.TabIndex = 0;
            // 
            // Button_MovieSearch
            // 
            this.Button_MovieSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_MovieSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_MovieSearch.FlatAppearance.BorderSize = 0;
            this.Button_MovieSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_MovieSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Button_MovieSearch.IconColor = System.Drawing.Color.Black;
            this.Button_MovieSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_MovieSearch.IconSize = 28;
            this.Button_MovieSearch.Location = new System.Drawing.Point(890, 0);
            this.Button_MovieSearch.Name = "Button_MovieSearch";
            this.Button_MovieSearch.Size = new System.Drawing.Size(68, 54);
            this.Button_MovieSearch.TabIndex = 0;
            this.Button_MovieSearch.UseVisualStyleBackColor = true;
            this.Button_MovieSearch.MouseLeave += new System.EventHandler(this.Button_MovieSearch_MouseLeave);
            // 
            // TextBox_MovieSearch
            // 
            this.TextBox_MovieSearch.BackColor = System.Drawing.Color.White;
            this.TextBox_MovieSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_MovieSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_MovieSearch.ForeColor = System.Drawing.Color.Gray;
            this.TextBox_MovieSearch.Location = new System.Drawing.Point(14, 16);
            this.TextBox_MovieSearch.Name = "TextBox_MovieSearch";
            this.TextBox_MovieSearch.Size = new System.Drawing.Size(850, 25);
            this.TextBox_MovieSearch.TabIndex = 0;
            this.TextBox_MovieSearch.Text = "Tên phim, tên diễn viên ...";
            this.TextBox_MovieSearch.Enter += new System.EventHandler(this.TextBox_MovieSearch_Enter);
            this.TextBox_MovieSearch.Leave += new System.EventHandler(this.TextBox_MovieSearch_Leave);
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
            // DropdownMenu_ShowMovieCategory
            // 
            this.DropdownMenu_ShowMovieCategory.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DropdownMenu_ShowMovieCategory.IsMainMenu = false;
            this.DropdownMenu_ShowMovieCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cổTrangThầnThoạiToolStripMenuItem,
            this.võThuậtKiếmHiệpToolStripMenuItem});
            this.DropdownMenu_ShowMovieCategory.MenuItemHeight = 25;
            this.DropdownMenu_ShowMovieCategory.MenuItemTextColor = System.Drawing.Color.Empty;
            this.DropdownMenu_ShowMovieCategory.Name = "customDropdownMenu1";
            this.DropdownMenu_ShowMovieCategory.PrimaryColor = System.Drawing.Color.Empty;
            this.DropdownMenu_ShowMovieCategory.Size = new System.Drawing.Size(220, 52);
            // 
            // cổTrangThầnThoạiToolStripMenuItem
            // 
            this.cổTrangThầnThoạiToolStripMenuItem.Name = "cổTrangThầnThoạiToolStripMenuItem";
            this.cổTrangThầnThoạiToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.cổTrangThầnThoạiToolStripMenuItem.Text = "Cổ trang - Thần thoại";
            // 
            // võThuậtKiếmHiệpToolStripMenuItem
            // 
            this.võThuậtKiếmHiệpToolStripMenuItem.Name = "võThuậtKiếmHiệpToolStripMenuItem";
            this.võThuậtKiếmHiệpToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.võThuậtKiếmHiệpToolStripMenuItem.Text = "Võ Thuật - Kiếm hiệp";
            // 
            // d
            // 
            this.d.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.d.IsMainMenu = false;
            this.d.MenuItemHeight = 25;
            this.d.MenuItemTextColor = System.Drawing.Color.Empty;
            this.d.Name = "customDropdownMenu2";
            this.d.PrimaryColor = System.Drawing.Color.Empty;
            this.d.Size = new System.Drawing.Size(61, 4);
            // 
            // DropdownMenu_ShowMovieCountry
            // 
            this.DropdownMenu_ShowMovieCountry.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DropdownMenu_ShowMovieCountry.IsMainMenu = false;
            this.DropdownMenu_ShowMovieCountry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.việtNamToolStripMenuItem,
            this.âuMỹToolStripMenuItem});
            this.DropdownMenu_ShowMovieCountry.MenuItemHeight = 25;
            this.DropdownMenu_ShowMovieCountry.MenuItemTextColor = System.Drawing.Color.Empty;
            this.DropdownMenu_ShowMovieCountry.Name = "DropdownMenu_ShowMovieCountry";
            this.DropdownMenu_ShowMovieCountry.PrimaryColor = System.Drawing.Color.Empty;
            this.DropdownMenu_ShowMovieCountry.Size = new System.Drawing.Size(141, 52);
            // 
            // việtNamToolStripMenuItem
            // 
            this.việtNamToolStripMenuItem.Name = "việtNamToolStripMenuItem";
            this.việtNamToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.việtNamToolStripMenuItem.Text = "Việt Nam";
            // 
            // âuMỹToolStripMenuItem
            // 
            this.âuMỹToolStripMenuItem.Name = "âuMỹToolStripMenuItem";
            this.âuMỹToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.âuMỹToolStripMenuItem.Text = "Âu - Mỹ";
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
            this.Load += new System.EventHandler(this._02_Form_Home_Load);
            this.Panel_Menu.ResumeLayout(false);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DropdownMenu_ShowMovieCategory.ResumeLayout(false);
            this.DropdownMenu_ShowMovieCountry.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Button_MovieSearch;
        private System.Windows.Forms.TextBox TextBox_MovieSearch;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Button_MovieCategory;
        private FontAwesome.Sharp.IconButton Button_MovieCountry;
        private Assets.Controls.CustomDropdownMenu DropdownMenu_ShowMovieCategory;
        private Assets.Controls.CustomDropdownMenu d;
        private System.Windows.Forms.ToolStripMenuItem cổTrangThầnThoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem võThuậtKiếmHiệpToolStripMenuItem;
        private Assets.Controls.CustomDropdownMenu DropdownMenu_ShowMovieCountry;
        private System.Windows.Forms.ToolStripMenuItem việtNamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem âuMỹToolStripMenuItem;
    }
}