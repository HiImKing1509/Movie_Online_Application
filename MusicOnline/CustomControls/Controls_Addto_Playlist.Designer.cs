namespace MusicOnline.CustomControls
{
    partial class Controls_Addto_Playlist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_Time = new System.Windows.Forms.Label();
            this.Label_PlaylistName = new System.Windows.Forms.Label();
            this.Button_AddToPlaylist = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // Label_Time
            // 
            this.Label_Time.AutoSize = true;
            this.Label_Time.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Time.ForeColor = System.Drawing.Color.White;
            this.Label_Time.Location = new System.Drawing.Point(35, 76);
            this.Label_Time.Name = "Label_Time";
            this.Label_Time.Size = new System.Drawing.Size(58, 21);
            this.Label_Time.TabIndex = 51;
            this.Label_Time.Text = "00:00:00";
            // 
            // Label_PlaylistName
            // 
            this.Label_PlaylistName.AutoSize = true;
            this.Label_PlaylistName.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PlaylistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_PlaylistName.Location = new System.Drawing.Point(33, 21);
            this.Label_PlaylistName.Name = "Label_PlaylistName";
            this.Label_PlaylistName.Size = new System.Drawing.Size(135, 34);
            this.Label_PlaylistName.TabIndex = 49;
            this.Label_PlaylistName.Text = "TÊN PLAYLIST";
            // 
            // Button_AddToPlaylist
            // 
            this.Button_AddToPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AddToPlaylist.FlatAppearance.BorderSize = 0;
            this.Button_AddToPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddToPlaylist.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Button_AddToPlaylist.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.Button_AddToPlaylist.IconColor = System.Drawing.Color.Black;
            this.Button_AddToPlaylist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_AddToPlaylist.IconSize = 28;
            this.Button_AddToPlaylist.Location = new System.Drawing.Point(781, 34);
            this.Button_AddToPlaylist.Name = "Button_AddToPlaylist";
            this.Button_AddToPlaylist.Size = new System.Drawing.Size(50, 50);
            this.Button_AddToPlaylist.TabIndex = 53;
            this.Button_AddToPlaylist.UseVisualStyleBackColor = true;
            this.Button_AddToPlaylist.Click += new System.EventHandler(this.Button_AddToPlaylist_Click);
            // 
            // Controls_Addto_Playlist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Button_AddToPlaylist);
            this.Controls.Add(this.Label_Time);
            this.Controls.Add(this.Label_PlaylistName);
            this.Name = "Controls_Addto_Playlist";
            this.Size = new System.Drawing.Size(876, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_Time;
        private System.Windows.Forms.Label Label_PlaylistName;
        private FontAwesome.Sharp.IconButton Button_AddToPlaylist;
    }
}
