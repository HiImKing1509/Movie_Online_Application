namespace MusicOnline.CustomControls
{
    partial class Controls_List_Movie_watching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controls_List_Movie_watching));
            this.Label_Ranking = new System.Windows.Forms.Label();
            this.Label_MovieName = new System.Windows.Forms.Label();
            this.PictureBox_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Ranking
            // 
            this.Label_Ranking.AutoSize = true;
            this.Label_Ranking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Ranking.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Ranking.Location = new System.Drawing.Point(11, 35);
            this.Label_Ranking.Name = "Label_Ranking";
            this.Label_Ranking.Size = new System.Drawing.Size(40, 40);
            this.Label_Ranking.TabIndex = 50;
            this.Label_Ranking.Text = "01";
            this.Label_Ranking.Click += new System.EventHandler(this.Controls_List_Movie_watching_Click);
            this.Label_Ranking.MouseEnter += new System.EventHandler(this.Controls_List_Movie_watching_MouseEnter);
            this.Label_Ranking.MouseLeave += new System.EventHandler(this.Controls_List_Movie_watching_MouseLeave);
            // 
            // Label_MovieName
            // 
            this.Label_MovieName.AutoSize = true;
            this.Label_MovieName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_MovieName.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MovieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_MovieName.Location = new System.Drawing.Point(106, 15);
            this.Label_MovieName.MaximumSize = new System.Drawing.Size(300, 0);
            this.Label_MovieName.Name = "Label_MovieName";
            this.Label_MovieName.Size = new System.Drawing.Size(280, 56);
            this.Label_MovieName.TabIndex = 49;
            this.Label_MovieName.Text = "THẾ GIỚI KHÔNG LỐI THOÁT (PHẦN 2) rồng trỗi dậy";
            this.Label_MovieName.Click += new System.EventHandler(this.Controls_List_Movie_watching_Click);
            this.Label_MovieName.MouseEnter += new System.EventHandler(this.Controls_List_Movie_watching_MouseEnter);
            this.Label_MovieName.MouseLeave += new System.EventHandler(this.Controls_List_Movie_watching_MouseLeave);
            // 
            // PictureBox_Image
            // 
            this.PictureBox_Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_Image.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Image.Image")));
            this.PictureBox_Image.Location = new System.Drawing.Point(57, 15);
            this.PictureBox_Image.Name = "PictureBox_Image";
            this.PictureBox_Image.Size = new System.Drawing.Size(43, 80);
            this.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Image.TabIndex = 48;
            this.PictureBox_Image.TabStop = false;
            this.PictureBox_Image.Click += new System.EventHandler(this.Controls_List_Movie_watching_Click);
            this.PictureBox_Image.MouseEnter += new System.EventHandler(this.Controls_List_Movie_watching_MouseEnter);
            this.PictureBox_Image.MouseLeave += new System.EventHandler(this.Controls_List_Movie_watching_MouseLeave);
            // 
            // Controls_List_Movie_watching
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Label_Ranking);
            this.Controls.Add(this.Label_MovieName);
            this.Controls.Add(this.PictureBox_Image);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Controls_List_Movie_watching";
            this.Size = new System.Drawing.Size(410, 113);
            this.Click += new System.EventHandler(this.Controls_List_Movie_watching_Click);
            this.MouseEnter += new System.EventHandler(this.Controls_List_Movie_watching_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Controls_List_Movie_watching_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Ranking;
        private System.Windows.Forms.Label Label_MovieName;
        private System.Windows.Forms.PictureBox PictureBox_Image;
    }
}
