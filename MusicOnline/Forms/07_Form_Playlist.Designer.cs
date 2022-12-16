namespace MusicOnline.Forms
{
    partial class _07_Form_Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_07_Form_Playlist));
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Label_NumberOfMovie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_MovieNameEng = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Tools = new System.Windows.Forms.Panel();
            this.FlowLayoutPanel_Main = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowLayoutPanel_Items = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_CreatePlaylist = new FontAwesome.Sharp.IconButton();
            this.Button_ShowAllMovies = new FontAwesome.Sharp.IconButton();
            this.Button_RemoveAllPlaylist = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.Button_ClosePanel = new FontAwesome.Sharp.IconButton();
            this.Panel_CreatePlaylistInfomation = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_NamePlaylist = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBox_Image = new System.Windows.Forms.ComboBox();
            this.PictureBox_Image = new System.Windows.Forms.PictureBox();
            this.Button_NewCreate = new FontAwesome.Sharp.IconButton();
            this.Panel_CreatePlaylist = new System.Windows.Forms.Panel();
            this.Panel_Header.SuspendLayout();
            this.Panel_Tools.SuspendLayout();
            this.Panel_CreatePlaylistInfomation.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).BeginInit();
            this.Panel_CreatePlaylist.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Header.Controls.Add(this.Label_NumberOfMovie);
            this.Panel_Header.Controls.Add(this.label2);
            this.Panel_Header.Controls.Add(this.Label_MovieNameEng);
            this.Panel_Header.Controls.Add(this.label1);
            this.Panel_Header.Location = new System.Drawing.Point(26, 12);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(1528, 92);
            this.Panel_Header.TabIndex = 0;
            // 
            // Label_NumberOfMovie
            // 
            this.Label_NumberOfMovie.AutoSize = true;
            this.Label_NumberOfMovie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NumberOfMovie.ForeColor = System.Drawing.Color.White;
            this.Label_NumberOfMovie.Location = new System.Drawing.Point(339, 49);
            this.Label_NumberOfMovie.Name = "Label_NumberOfMovie";
            this.Label_NumberOfMovie.Size = new System.Drawing.Size(21, 23);
            this.Label_NumberOfMovie.TabIndex = 31;
            this.Label_NumberOfMovie.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(961, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = "DANH SÁCH PHIM";
            // 
            // Label_MovieNameEng
            // 
            this.Label_MovieNameEng.AutoSize = true;
            this.Label_MovieNameEng.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MovieNameEng.ForeColor = System.Drawing.Color.White;
            this.Label_MovieNameEng.Location = new System.Drawing.Point(236, 49);
            this.Label_MovieNameEng.Name = "Label_MovieNameEng";
            this.Label_MovieNameEng.Size = new System.Drawing.Size(97, 23);
            this.Label_MovieNameEng.TabIndex = 30;
            this.Label_MovieNameEng.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "PLAYLIST";
            // 
            // Panel_Tools
            // 
            this.Panel_Tools.Controls.Add(this.Button_CreatePlaylist);
            this.Panel_Tools.Controls.Add(this.Button_ShowAllMovies);
            this.Panel_Tools.Controls.Add(this.Button_RemoveAllPlaylist);
            this.Panel_Tools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Tools.Location = new System.Drawing.Point(0, 765);
            this.Panel_Tools.Name = "Panel_Tools";
            this.Panel_Tools.Size = new System.Drawing.Size(1566, 103);
            this.Panel_Tools.TabIndex = 1;
            // 
            // FlowLayoutPanel_Main
            // 
            this.FlowLayoutPanel_Main.AutoScroll = true;
            this.FlowLayoutPanel_Main.Location = new System.Drawing.Point(26, 110);
            this.FlowLayoutPanel_Main.Name = "FlowLayoutPanel_Main";
            this.FlowLayoutPanel_Main.Size = new System.Drawing.Size(953, 649);
            this.FlowLayoutPanel_Main.TabIndex = 2;
            // 
            // FlowLayoutPanel_Items
            // 
            this.FlowLayoutPanel_Items.AutoScroll = true;
            this.FlowLayoutPanel_Items.Location = new System.Drawing.Point(996, 110);
            this.FlowLayoutPanel_Items.Name = "FlowLayoutPanel_Items";
            this.FlowLayoutPanel_Items.Size = new System.Drawing.Size(558, 649);
            this.FlowLayoutPanel_Items.TabIndex = 3;
            // 
            // Button_CreatePlaylist
            // 
            this.Button_CreatePlaylist.BackColor = System.Drawing.Color.Transparent;
            this.Button_CreatePlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_CreatePlaylist.FlatAppearance.BorderSize = 0;
            this.Button_CreatePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_CreatePlaylist.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_CreatePlaylist.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_CreatePlaylist.IconColor = System.Drawing.Color.Black;
            this.Button_CreatePlaylist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_CreatePlaylist.Location = new System.Drawing.Point(26, 21);
            this.Button_CreatePlaylist.Name = "Button_CreatePlaylist";
            this.Button_CreatePlaylist.Size = new System.Drawing.Size(238, 65);
            this.Button_CreatePlaylist.TabIndex = 6;
            this.Button_CreatePlaylist.Text = "Tạo mới playlist";
            this.Button_CreatePlaylist.UseVisualStyleBackColor = false;
            this.Button_CreatePlaylist.Click += new System.EventHandler(this.Button_CreatePlaylist_Click);
            // 
            // Button_ShowAllMovies
            // 
            this.Button_ShowAllMovies.BackColor = System.Drawing.Color.Transparent;
            this.Button_ShowAllMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ShowAllMovies.FlatAppearance.BorderSize = 0;
            this.Button_ShowAllMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ShowAllMovies.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.Button_ShowAllMovies.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_ShowAllMovies.IconColor = System.Drawing.Color.Black;
            this.Button_ShowAllMovies.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_ShowAllMovies.Location = new System.Drawing.Point(1046, 21);
            this.Button_ShowAllMovies.Name = "Button_ShowAllMovies";
            this.Button_ShowAllMovies.Size = new System.Drawing.Size(238, 65);
            this.Button_ShowAllMovies.TabIndex = 4;
            this.Button_ShowAllMovies.Text = "Phát tất cả";
            this.Button_ShowAllMovies.UseVisualStyleBackColor = false;
            this.Button_ShowAllMovies.Click += new System.EventHandler(this.Button_ShowAllMovies_Click);
            // 
            // Button_RemoveAllPlaylist
            // 
            this.Button_RemoveAllPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_RemoveAllPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RemoveAllPlaylist.FlatAppearance.BorderSize = 0;
            this.Button_RemoveAllPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RemoveAllPlaylist.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.Button_RemoveAllPlaylist.ForeColor = System.Drawing.Color.White;
            this.Button_RemoveAllPlaylist.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_RemoveAllPlaylist.IconColor = System.Drawing.Color.Black;
            this.Button_RemoveAllPlaylist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_RemoveAllPlaylist.Location = new System.Drawing.Point(1316, 21);
            this.Button_RemoveAllPlaylist.Name = "Button_RemoveAllPlaylist";
            this.Button_RemoveAllPlaylist.Size = new System.Drawing.Size(238, 65);
            this.Button_RemoveAllPlaylist.TabIndex = 3;
            this.Button_RemoveAllPlaylist.Text = "Xóa playlist";
            this.Button_RemoveAllPlaylist.UseVisualStyleBackColor = false;
            this.Button_RemoveAllPlaylist.Click += new System.EventHandler(this.Button_RemoveAllPlaylist_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(28, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(246, 52);
            this.label12.TabIndex = 31;
            this.label12.Text = "Tạo mới playlist";
            // 
            // Button_ClosePanel
            // 
            this.Button_ClosePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_ClosePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ClosePanel.FlatAppearance.BorderSize = 0;
            this.Button_ClosePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ClosePanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ClosePanel.ForeColor = System.Drawing.Color.White;
            this.Button_ClosePanel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_ClosePanel.IconColor = System.Drawing.Color.Black;
            this.Button_ClosePanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_ClosePanel.Location = new System.Drawing.Point(559, 454);
            this.Button_ClosePanel.Name = "Button_ClosePanel";
            this.Button_ClosePanel.Size = new System.Drawing.Size(164, 54);
            this.Button_ClosePanel.TabIndex = 32;
            this.Button_ClosePanel.Text = "Đóng";
            this.Button_ClosePanel.UseVisualStyleBackColor = false;
            this.Button_ClosePanel.Click += new System.EventHandler(this.Button_ClosePanel_Click);
            // 
            // Panel_CreatePlaylistInfomation
            // 
            this.Panel_CreatePlaylistInfomation.Controls.Add(this.PictureBox_Image);
            this.Panel_CreatePlaylistInfomation.Controls.Add(this.ComboBox_Image);
            this.Panel_CreatePlaylistInfomation.Controls.Add(this.label4);
            this.Panel_CreatePlaylistInfomation.Controls.Add(this.label3);
            this.Panel_CreatePlaylistInfomation.Controls.Add(this.panel1);
            this.Panel_CreatePlaylistInfomation.Location = new System.Drawing.Point(37, 91);
            this.Panel_CreatePlaylistInfomation.Name = "Panel_CreatePlaylistInfomation";
            this.Panel_CreatePlaylistInfomation.Size = new System.Drawing.Size(734, 339);
            this.Panel_CreatePlaylistInfomation.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TextBox_NamePlaylist);
            this.panel1.Location = new System.Drawing.Point(40, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 54);
            this.panel1.TabIndex = 1;
            // 
            // TextBox_NamePlaylist
            // 
            this.TextBox_NamePlaylist.BackColor = System.Drawing.Color.White;
            this.TextBox_NamePlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_NamePlaylist.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_NamePlaylist.ForeColor = System.Drawing.Color.Gray;
            this.TextBox_NamePlaylist.Location = new System.Drawing.Point(14, 16);
            this.TextBox_NamePlaylist.Name = "TextBox_NamePlaylist";
            this.TextBox_NamePlaylist.Size = new System.Drawing.Size(612, 25);
            this.TextBox_NamePlaylist.TabIndex = 0;
            this.TextBox_NamePlaylist.Text = "Nhập tên playlist";
            this.TextBox_NamePlaylist.Enter += new System.EventHandler(this.TextBox_NamePlaylist_Enter);
            this.TextBox_NamePlaylist.Leave += new System.EventHandler(this.TextBox_NamePlaylist_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên playlist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Image";
            // 
            // ComboBox_Image
            // 
            this.ComboBox_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Image.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Image.FormattingEnabled = true;
            this.ComboBox_Image.ItemHeight = 24;
            this.ComboBox_Image.Items.AddRange(new object[] {
            "Warwick Dolton",
            "Jewel Lyons",
            "Sapphire Haynes",
            "Tara Howe",
            "Megan Tyler",
            "Water Tribe",
            "Air Nomad"});
            this.ComboBox_Image.Location = new System.Drawing.Point(116, 174);
            this.ComboBox_Image.Name = "ComboBox_Image";
            this.ComboBox_Image.Size = new System.Drawing.Size(225, 32);
            this.ComboBox_Image.TabIndex = 4;
            this.ComboBox_Image.Text = "Warwick Dolton";
            this.ComboBox_Image.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Image_SelectedIndexChanged);
            // 
            // PictureBox_Image
            // 
            this.PictureBox_Image.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Image.Image")));
            this.PictureBox_Image.Location = new System.Drawing.Point(413, 148);
            this.PictureBox_Image.Name = "PictureBox_Image";
            this.PictureBox_Image.Size = new System.Drawing.Size(273, 169);
            this.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Image.TabIndex = 5;
            this.PictureBox_Image.TabStop = false;
            // 
            // Button_NewCreate
            // 
            this.Button_NewCreate.BackColor = System.Drawing.Color.Green;
            this.Button_NewCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_NewCreate.FlatAppearance.BorderSize = 0;
            this.Button_NewCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_NewCreate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_NewCreate.ForeColor = System.Drawing.Color.White;
            this.Button_NewCreate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_NewCreate.IconColor = System.Drawing.Color.Black;
            this.Button_NewCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_NewCreate.Location = new System.Drawing.Point(368, 454);
            this.Button_NewCreate.Name = "Button_NewCreate";
            this.Button_NewCreate.Size = new System.Drawing.Size(158, 54);
            this.Button_NewCreate.TabIndex = 34;
            this.Button_NewCreate.Text = "Tạo mới";
            this.Button_NewCreate.UseVisualStyleBackColor = false;
            this.Button_NewCreate.Click += new System.EventHandler(this.Button_NewCreate_Click);
            // 
            // Panel_CreatePlaylist
            // 
            this.Panel_CreatePlaylist.BackColor = System.Drawing.Color.Black;
            this.Panel_CreatePlaylist.Controls.Add(this.Button_NewCreate);
            this.Panel_CreatePlaylist.Controls.Add(this.Panel_CreatePlaylistInfomation);
            this.Panel_CreatePlaylist.Controls.Add(this.Button_ClosePanel);
            this.Panel_CreatePlaylist.Controls.Add(this.label12);
            this.Panel_CreatePlaylist.Location = new System.Drawing.Point(240, 65);
            this.Panel_CreatePlaylist.Name = "Panel_CreatePlaylist";
            this.Panel_CreatePlaylist.Size = new System.Drawing.Size(808, 525);
            this.Panel_CreatePlaylist.TabIndex = 38;
            this.Panel_CreatePlaylist.Visible = false;
            // 
            // _07_Form_Playlist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1566, 868);
            this.Controls.Add(this.Panel_CreatePlaylist);
            this.Controls.Add(this.FlowLayoutPanel_Items);
            this.Controls.Add(this.FlowLayoutPanel_Main);
            this.Controls.Add(this.Panel_Tools);
            this.Controls.Add(this.Panel_Header);
            this.Name = "_07_Form_Playlist";
            this.Text = "_07_Form_Playlist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._07_Form_Playlist_FormClosing);
            this.Load += new System.EventHandler(this._07_Form_Playlist_Load);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.Panel_Tools.ResumeLayout(false);
            this.Panel_CreatePlaylistInfomation.ResumeLayout(false);
            this.Panel_CreatePlaylistInfomation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).EndInit();
            this.Panel_CreatePlaylist.ResumeLayout(false);
            this.Panel_CreatePlaylist.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_NumberOfMovie;
        private System.Windows.Forms.Label Label_MovieNameEng;
        private System.Windows.Forms.Panel Panel_Tools;
        private FontAwesome.Sharp.IconButton Button_ShowAllMovies;
        private FontAwesome.Sharp.IconButton Button_RemoveAllPlaylist;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_Main;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_Items;
        private FontAwesome.Sharp.IconButton Button_CreatePlaylist;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton Button_ClosePanel;
        private System.Windows.Forms.Panel Panel_CreatePlaylistInfomation;
        private System.Windows.Forms.PictureBox PictureBox_Image;
        private System.Windows.Forms.ComboBox ComboBox_Image;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBox_NamePlaylist;
        private FontAwesome.Sharp.IconButton Button_NewCreate;
        private System.Windows.Forms.Panel Panel_CreatePlaylist;
    }
}