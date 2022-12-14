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
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Label_NumberOfMovie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_MovieNameEng = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Tools = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Button_ShowAllMovies = new FontAwesome.Sharp.IconButton();
            this.Button_RemoveAllPlaylist = new FontAwesome.Sharp.IconButton();
            this.FlowLayoutPanel_Main = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowLayoutPanel_Items = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_Header.SuspendLayout();
            this.Panel_Tools.SuspendLayout();
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
            this.Panel_Tools.Controls.Add(this.iconButton1);
            this.Panel_Tools.Controls.Add(this.Button_ShowAllMovies);
            this.Panel_Tools.Controls.Add(this.Button_RemoveAllPlaylist);
            this.Panel_Tools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Tools.Location = new System.Drawing.Point(0, 765);
            this.Panel_Tools.Name = "Panel_Tools";
            this.Panel_Tools.Size = new System.Drawing.Size(1566, 103);
            this.Panel_Tools.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(566, 29);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(238, 65);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Xóa tất cả";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // Button_ShowAllMovies
            // 
            this.Button_ShowAllMovies.BackColor = System.Drawing.Color.Transparent;
            this.Button_ShowAllMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ShowAllMovies.FlatAppearance.BorderSize = 0;
            this.Button_ShowAllMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ShowAllMovies.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ShowAllMovies.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_ShowAllMovies.IconColor = System.Drawing.Color.Black;
            this.Button_ShowAllMovies.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_ShowAllMovies.Location = new System.Drawing.Point(987, 29);
            this.Button_ShowAllMovies.Name = "Button_ShowAllMovies";
            this.Button_ShowAllMovies.Size = new System.Drawing.Size(238, 65);
            this.Button_ShowAllMovies.TabIndex = 4;
            this.Button_ShowAllMovies.Text = "Phát tất cả";
            this.Button_ShowAllMovies.UseVisualStyleBackColor = false;
            // 
            // Button_RemoveAllPlaylist
            // 
            this.Button_RemoveAllPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.Button_RemoveAllPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RemoveAllPlaylist.FlatAppearance.BorderSize = 0;
            this.Button_RemoveAllPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RemoveAllPlaylist.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_RemoveAllPlaylist.ForeColor = System.Drawing.Color.White;
            this.Button_RemoveAllPlaylist.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_RemoveAllPlaylist.IconColor = System.Drawing.Color.Black;
            this.Button_RemoveAllPlaylist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_RemoveAllPlaylist.Location = new System.Drawing.Point(1266, 29);
            this.Button_RemoveAllPlaylist.Name = "Button_RemoveAllPlaylist";
            this.Button_RemoveAllPlaylist.Size = new System.Drawing.Size(238, 65);
            this.Button_RemoveAllPlaylist.TabIndex = 3;
            this.Button_RemoveAllPlaylist.Text = "Xóa tất cả";
            this.Button_RemoveAllPlaylist.UseVisualStyleBackColor = false;
            // 
            // FlowLayoutPanel_Main
            // 
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
            // _07_Form_Playlist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1566, 868);
            this.Controls.Add(this.FlowLayoutPanel_Items);
            this.Controls.Add(this.FlowLayoutPanel_Main);
            this.Controls.Add(this.Panel_Tools);
            this.Controls.Add(this.Panel_Header);
            this.Name = "_07_Form_Playlist";
            this.Text = "_07_Form_Playlist";
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.Panel_Tools.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}