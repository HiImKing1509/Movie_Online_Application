namespace MusicOnline.CustomControls
{
    partial class Controls_Movie_inList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controls_Movie_inList));
            this.Label_MovieNameEng = new System.Windows.Forms.Label();
            this.Label_MovieName = new System.Windows.Forms.Label();
            this.Label_Year = new System.Windows.Forms.Label();
            this.Button_RemoveMovie = new FontAwesome.Sharp.IconButton();
            this.Button_DetailMovie = new FontAwesome.Sharp.IconButton();
            this.PictureBox_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_MovieNameEng
            // 
            this.Label_MovieNameEng.AutoSize = true;
            this.Label_MovieNameEng.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MovieNameEng.ForeColor = System.Drawing.Color.White;
            this.Label_MovieNameEng.Location = new System.Drawing.Point(172, 88);
            this.Label_MovieNameEng.Name = "Label_MovieNameEng";
            this.Label_MovieNameEng.Size = new System.Drawing.Size(358, 19);
            this.Label_MovieNameEng.TabIndex = 31;
            this.Label_MovieNameEng.Text = "The Hobbit: The Battle of the Five Armies (2014)";
            // 
            // Label_MovieName
            // 
            this.Label_MovieName.AutoSize = true;
            this.Label_MovieName.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MovieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_MovieName.Location = new System.Drawing.Point(167, 22);
            this.Label_MovieName.Name = "Label_MovieName";
            this.Label_MovieName.Size = new System.Drawing.Size(514, 52);
            this.Label_MovieName.TabIndex = 30;
            this.Label_MovieName.Text = "THẾ GIỚI KHÔNG LỐI THOÁT (PHẦN 2)";
            // 
            // Label_Year
            // 
            this.Label_Year.AutoSize = true;
            this.Label_Year.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Year.ForeColor = System.Drawing.Color.White;
            this.Label_Year.Location = new System.Drawing.Point(172, 131);
            this.Label_Year.Name = "Label_Year";
            this.Label_Year.Size = new System.Drawing.Size(45, 19);
            this.Label_Year.TabIndex = 35;
            this.Label_Year.Text = "2022";
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
            this.Button_RemoveMovie.IconSize = 24;
            this.Button_RemoveMovie.Location = new System.Drawing.Point(650, 154);
            this.Button_RemoveMovie.Name = "Button_RemoveMovie";
            this.Button_RemoveMovie.Size = new System.Drawing.Size(95, 47);
            this.Button_RemoveMovie.TabIndex = 33;
            this.Button_RemoveMovie.UseVisualStyleBackColor = false;
            this.Button_RemoveMovie.Click += new System.EventHandler(this.Button_RemoveMovie_Click);
            // 
            // Button_DetailMovie
            // 
            this.Button_DetailMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_DetailMovie.FlatAppearance.BorderSize = 0;
            this.Button_DetailMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DetailMovie.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Button_DetailMovie.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_DetailMovie.IconColor = System.Drawing.Color.Black;
            this.Button_DetailMovie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_DetailMovie.Location = new System.Drawing.Point(499, 154);
            this.Button_DetailMovie.Name = "Button_DetailMovie";
            this.Button_DetailMovie.Size = new System.Drawing.Size(145, 47);
            this.Button_DetailMovie.TabIndex = 32;
            this.Button_DetailMovie.Text = "Chi tiết";
            this.Button_DetailMovie.UseVisualStyleBackColor = true;
            this.Button_DetailMovie.Click += new System.EventHandler(this.Button_DetailMovie_Click);
            // 
            // PictureBox_Image
            // 
            this.PictureBox_Image.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Image.Image")));
            this.PictureBox_Image.Location = new System.Drawing.Point(28, 22);
            this.PictureBox_Image.Name = "PictureBox_Image";
            this.PictureBox_Image.Size = new System.Drawing.Size(133, 179);
            this.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Image.TabIndex = 0;
            this.PictureBox_Image.TabStop = false;
            // 
            // Controls_Movie_inList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Label_Year);
            this.Controls.Add(this.Button_RemoveMovie);
            this.Controls.Add(this.Button_DetailMovie);
            this.Controls.Add(this.Label_MovieNameEng);
            this.Controls.Add(this.Label_MovieName);
            this.Controls.Add(this.PictureBox_Image);
            this.Name = "Controls_Movie_inList";
            this.Size = new System.Drawing.Size(766, 223);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Image;
        private System.Windows.Forms.Label Label_MovieNameEng;
        private System.Windows.Forms.Label Label_MovieName;
        private FontAwesome.Sharp.IconButton Button_DetailMovie;
        private FontAwesome.Sharp.IconButton Button_RemoveMovie;
        private System.Windows.Forms.Label Label_Year;
    }
}
