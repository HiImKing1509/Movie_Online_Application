namespace MusicOnline.CustomControls
{
    partial class Controls_Movie_Freq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controls_Movie_Freq));
            this.PictureBox_Image = new System.Windows.Forms.PictureBox();
            this.Label_MovieName = new System.Windows.Forms.Label();
            this.Label_NumberAccess = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_Ranking = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox_Image
            // 
            this.PictureBox_Image.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Image.Image")));
            this.PictureBox_Image.Location = new System.Drawing.Point(67, 10);
            this.PictureBox_Image.Name = "PictureBox_Image";
            this.PictureBox_Image.Size = new System.Drawing.Size(57, 74);
            this.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Image.TabIndex = 2;
            this.PictureBox_Image.TabStop = false;
            // 
            // Label_MovieName
            // 
            this.Label_MovieName.AutoSize = true;
            this.Label_MovieName.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MovieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_MovieName.Location = new System.Drawing.Point(130, 10);
            this.Label_MovieName.Name = "Label_MovieName";
            this.Label_MovieName.Size = new System.Drawing.Size(241, 24);
            this.Label_MovieName.TabIndex = 35;
            this.Label_MovieName.Text = "THẾ GIỚI KHÔNG LỐI THOÁT (PHẦN 2)";
            // 
            // Label_NumberAccess
            // 
            this.Label_NumberAccess.AutoSize = true;
            this.Label_NumberAccess.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NumberAccess.ForeColor = System.Drawing.Color.White;
            this.Label_NumberAccess.Location = new System.Drawing.Point(224, 44);
            this.Label_NumberAccess.Name = "Label_NumberAccess";
            this.Label_NumberAccess.Size = new System.Drawing.Size(25, 24);
            this.Label_NumberAccess.TabIndex = 43;
            this.Label_NumberAccess.Text = "12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "Lượt xem:";
            // 
            // Label_Ranking
            // 
            this.Label_Ranking.AutoSize = true;
            this.Label_Ranking.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Ranking.Location = new System.Drawing.Point(14, 31);
            this.Label_Ranking.Name = "Label_Ranking";
            this.Label_Ranking.Size = new System.Drawing.Size(41, 41);
            this.Label_Ranking.TabIndex = 44;
            this.Label_Ranking.Text = "01";
            // 
            // Controls_Movie_Freq
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Label_Ranking);
            this.Controls.Add(this.Label_NumberAccess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label_MovieName);
            this.Controls.Add(this.PictureBox_Image);
            this.Name = "Controls_Movie_Freq";
            this.Size = new System.Drawing.Size(435, 98);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Image;
        private System.Windows.Forms.Label Label_MovieName;
        private System.Windows.Forms.Label Label_NumberAccess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_Ranking;
    }
}
