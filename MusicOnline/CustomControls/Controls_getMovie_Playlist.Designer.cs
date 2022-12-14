namespace MusicOnline.CustomControls
{
    partial class Controls_getMovie_Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controls_getMovie_Playlist));
            this.Label_Ranking = new System.Windows.Forms.Label();
            this.Label_MovieName = new System.Windows.Forms.Label();
            this.PictureBox_Image = new System.Windows.Forms.PictureBox();
            this.Label_Time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_RemoveMovie = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Ranking
            // 
            this.Label_Ranking.AutoSize = true;
            this.Label_Ranking.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Ranking.Location = new System.Drawing.Point(10, 47);
            this.Label_Ranking.Name = "Label_Ranking";
            this.Label_Ranking.Size = new System.Drawing.Size(40, 40);
            this.Label_Ranking.TabIndex = 47;
            this.Label_Ranking.Text = "01";
            // 
            // Label_MovieName
            // 
            this.Label_MovieName.AutoSize = true;
            this.Label_MovieName.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MovieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_MovieName.Location = new System.Drawing.Point(144, 15);
            this.Label_MovieName.Name = "Label_MovieName";
            this.Label_MovieName.Size = new System.Drawing.Size(335, 34);
            this.Label_MovieName.TabIndex = 46;
            this.Label_MovieName.Text = "THẾ GIỚI KHÔNG LỐI THOÁT (PHẦN 2)";
            // 
            // PictureBox_Image
            // 
            this.PictureBox_Image.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Image.Image")));
            this.PictureBox_Image.Location = new System.Drawing.Point(60, 15);
            this.PictureBox_Image.Name = "PictureBox_Image";
            this.PictureBox_Image.Size = new System.Drawing.Size(78, 104);
            this.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Image.TabIndex = 45;
            this.PictureBox_Image.TabStop = false;
            // 
            // Label_Time
            // 
            this.Label_Time.AutoSize = true;
            this.Label_Time.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Time.ForeColor = System.Drawing.Color.White;
            this.Label_Time.Location = new System.Drawing.Point(264, 60);
            this.Label_Time.Name = "Label_Time";
            this.Label_Time.Size = new System.Drawing.Size(58, 21);
            this.Label_Time.TabIndex = 49;
            this.Label_Time.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(146, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ngày thêm vào:";
            // 
            // Button_RemoveMovie
            // 
            this.Button_RemoveMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_RemoveMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RemoveMovie.FlatAppearance.BorderSize = 0;
            this.Button_RemoveMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RemoveMovie.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Button_RemoveMovie.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.Button_RemoveMovie.IconColor = System.Drawing.Color.White;
            this.Button_RemoveMovie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_RemoveMovie.IconSize = 20;
            this.Button_RemoveMovie.Location = new System.Drawing.Point(466, 79);
            this.Button_RemoveMovie.Name = "Button_RemoveMovie";
            this.Button_RemoveMovie.Size = new System.Drawing.Size(60, 40);
            this.Button_RemoveMovie.TabIndex = 50;
            this.Button_RemoveMovie.UseVisualStyleBackColor = false;
            // 
            // Controls_getMovie_Playlist
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Button_RemoveMovie);
            this.Controls.Add(this.Label_Time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label_Ranking);
            this.Controls.Add(this.Label_MovieName);
            this.Controls.Add(this.PictureBox_Image);
            this.Name = "Controls_getMovie_Playlist";
            this.Size = new System.Drawing.Size(542, 135);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Ranking;
        private System.Windows.Forms.Label Label_MovieName;
        private System.Windows.Forms.PictureBox PictureBox_Image;
        private System.Windows.Forms.Label Label_Time;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton Button_RemoveMovie;
    }
}
