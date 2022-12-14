namespace MusicOnline.CustomControls
{
    partial class Custom_Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Custom_Playlist));
            this.Panel_Information = new System.Windows.Forms.Panel();
            this.Label_NumberOfMovie = new System.Windows.Forms.Label();
            this.Label_Time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_PlaylistName = new System.Windows.Forms.Label();
            this.PictureBox_Image = new System.Windows.Forms.PictureBox();
            this.Panel_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Information
            // 
            this.Panel_Information.BackColor = System.Drawing.Color.Black;
            this.Panel_Information.Controls.Add(this.Label_NumberOfMovie);
            this.Panel_Information.Controls.Add(this.Label_Time);
            this.Panel_Information.Controls.Add(this.label3);
            this.Panel_Information.Controls.Add(this.Label_PlaylistName);
            this.Panel_Information.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Information.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Information.Location = new System.Drawing.Point(0, 170);
            this.Panel_Information.Name = "Panel_Information";
            this.Panel_Information.Size = new System.Drawing.Size(454, 103);
            this.Panel_Information.TabIndex = 1;
            this.Panel_Information.Click += new System.EventHandler(this.PictureBox_Image_Click);
            this.Panel_Information.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.Panel_Information.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            // 
            // Label_NumberOfMovie
            // 
            this.Label_NumberOfMovie.AutoSize = true;
            this.Label_NumberOfMovie.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NumberOfMovie.ForeColor = System.Drawing.Color.White;
            this.Label_NumberOfMovie.Location = new System.Drawing.Point(131, 63);
            this.Label_NumberOfMovie.Name = "Label_NumberOfMovie";
            this.Label_NumberOfMovie.Size = new System.Drawing.Size(22, 22);
            this.Label_NumberOfMovie.TabIndex = 48;
            this.Label_NumberOfMovie.Text = "12";
            this.Label_NumberOfMovie.Click += new System.EventHandler(this.PictureBox_Image_Click);
            this.Label_NumberOfMovie.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.Label_NumberOfMovie.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            // 
            // Label_Time
            // 
            this.Label_Time.AutoSize = true;
            this.Label_Time.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Time.ForeColor = System.Drawing.Color.White;
            this.Label_Time.Location = new System.Drawing.Point(288, 63);
            this.Label_Time.Name = "Label_Time";
            this.Label_Time.Size = new System.Drawing.Size(58, 21);
            this.Label_Time.TabIndex = 47;
            this.Label_Time.Text = "00:00:00";
            this.Label_Time.Click += new System.EventHandler(this.PictureBox_Image_Click);
            this.Label_Time.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.Label_Time.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "SỐ LƯỢNG PHIM:";
            this.label3.Click += new System.EventHandler(this.PictureBox_Image_Click);
            this.label3.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            // 
            // Label_PlaylistName
            // 
            this.Label_PlaylistName.AutoSize = true;
            this.Label_PlaylistName.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PlaylistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_PlaylistName.Location = new System.Drawing.Point(17, 14);
            this.Label_PlaylistName.Name = "Label_PlaylistName";
            this.Label_PlaylistName.Size = new System.Drawing.Size(135, 34);
            this.Label_PlaylistName.TabIndex = 31;
            this.Label_PlaylistName.Text = "TÊN PLAYLIST";
            this.Label_PlaylistName.Click += new System.EventHandler(this.PictureBox_Image_Click);
            this.Label_PlaylistName.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.Label_PlaylistName.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            // 
            // PictureBox_Image
            // 
            this.PictureBox_Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_Image.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Image.Image")));
            this.PictureBox_Image.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_Image.Name = "PictureBox_Image";
            this.PictureBox_Image.Size = new System.Drawing.Size(454, 273);
            this.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Image.TabIndex = 0;
            this.PictureBox_Image.TabStop = false;
            this.PictureBox_Image.Click += new System.EventHandler(this.PictureBox_Image_Click);
            this.PictureBox_Image.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.PictureBox_Image.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            // 
            // Custom_Playlist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Panel_Information);
            this.Controls.Add(this.PictureBox_Image);
            this.Name = "Custom_Playlist";
            this.Size = new System.Drawing.Size(454, 273);
            this.Panel_Information.ResumeLayout(false);
            this.Panel_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Image;
        private System.Windows.Forms.Panel Panel_Information;
        private System.Windows.Forms.Label Label_PlaylistName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_Time;
        private System.Windows.Forms.Label Label_NumberOfMovie;
    }
}
