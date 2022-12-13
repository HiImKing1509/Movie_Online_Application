namespace MusicOnline.CustomControls
{
    partial class Controls_Movie_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controls_Movie_History));
            this.PictureBox_Image = new System.Windows.Forms.PictureBox();
            this.Button_RemoveMovie = new FontAwesome.Sharp.IconButton();
            this.Label_MovieNameEng = new System.Windows.Forms.Label();
            this.Label_MovieName = new System.Windows.Forms.Label();
            this.Button_DetailMovie = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_Duration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox_Image
            // 
            this.PictureBox_Image.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Image.Image")));
            this.PictureBox_Image.Location = new System.Drawing.Point(25, 18);
            this.PictureBox_Image.Name = "PictureBox_Image";
            this.PictureBox_Image.Size = new System.Drawing.Size(110, 153);
            this.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Image.TabIndex = 1;
            this.PictureBox_Image.TabStop = false;
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
            this.Button_RemoveMovie.Location = new System.Drawing.Point(343, 123);
            this.Button_RemoveMovie.Name = "Button_RemoveMovie";
            this.Button_RemoveMovie.Size = new System.Drawing.Size(95, 47);
            this.Button_RemoveMovie.TabIndex = 36;
            this.Button_RemoveMovie.UseVisualStyleBackColor = false;
            this.Button_RemoveMovie.Click += new System.EventHandler(this.Button_RemoveMovie_Click);
            // 
            // Label_MovieNameEng
            // 
            this.Label_MovieNameEng.AutoSize = true;
            this.Label_MovieNameEng.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MovieNameEng.ForeColor = System.Drawing.Color.White;
            this.Label_MovieNameEng.Location = new System.Drawing.Point(168, 60);
            this.Label_MovieNameEng.Name = "Label_MovieNameEng";
            this.Label_MovieNameEng.Size = new System.Drawing.Size(318, 17);
            this.Label_MovieNameEng.TabIndex = 35;
            this.Label_MovieNameEng.Text = "The Hobbit: The Battle of the Five Armies (2014)";
            // 
            // Label_MovieName
            // 
            this.Label_MovieName.AutoSize = true;
            this.Label_MovieName.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 20.8F, System.Drawing.FontStyle.Bold);
            this.Label_MovieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_MovieName.Location = new System.Drawing.Point(163, 18);
            this.Label_MovieName.Name = "Label_MovieName";
            this.Label_MovieName.Size = new System.Drawing.Size(419, 42);
            this.Label_MovieName.TabIndex = 34;
            this.Label_MovieName.Text = "THẾ GIỚI KHÔNG LỐI THOÁT (PHẦN 2)";
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
            this.Button_DetailMovie.Location = new System.Drawing.Point(170, 124);
            this.Button_DetailMovie.Name = "Button_DetailMovie";
            this.Button_DetailMovie.Size = new System.Drawing.Size(145, 47);
            this.Button_DetailMovie.TabIndex = 37;
            this.Button_DetailMovie.Text = "Tiếp tục xem";
            this.Button_DetailMovie.UseVisualStyleBackColor = true;
            this.Button_DetailMovie.Click += new System.EventHandler(this.Button_DetailMovie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(688, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Thời gian:";
            // 
            // Label_Time
            // 
            this.Label_Time.AutoSize = true;
            this.Label_Time.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Time.ForeColor = System.Drawing.Color.White;
            this.Label_Time.Location = new System.Drawing.Point(784, 60);
            this.Label_Time.Name = "Label_Time";
            this.Label_Time.Size = new System.Drawing.Size(74, 24);
            this.Label_Time.TabIndex = 39;
            this.Label_Time.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(688, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Đã xem được:";
            // 
            // Label_Duration
            // 
            this.Label_Duration.AutoSize = true;
            this.Label_Duration.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Duration.ForeColor = System.Drawing.Color.White;
            this.Label_Duration.Location = new System.Drawing.Point(815, 103);
            this.Label_Duration.Name = "Label_Duration";
            this.Label_Duration.Size = new System.Drawing.Size(43, 24);
            this.Label_Duration.TabIndex = 41;
            this.Label_Duration.Text = "50%";
            // 
            // Controls_Movie_History
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Label_Duration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label_Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_DetailMovie);
            this.Controls.Add(this.Button_RemoveMovie);
            this.Controls.Add(this.Label_MovieNameEng);
            this.Controls.Add(this.Label_MovieName);
            this.Controls.Add(this.PictureBox_Image);
            this.Name = "Controls_Movie_History";
            this.Size = new System.Drawing.Size(1028, 195);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Image;
        private FontAwesome.Sharp.IconButton Button_RemoveMovie;
        private System.Windows.Forms.Label Label_MovieNameEng;
        private System.Windows.Forms.Label Label_MovieName;
        private FontAwesome.Sharp.IconButton Button_DetailMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_Duration;
    }
}
