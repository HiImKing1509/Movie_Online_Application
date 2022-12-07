namespace MusicOnline.CustomControls
{
    partial class Controls_Movie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controls_Movie));
            this.Panel_ControlMovie = new System.Windows.Forms.Panel();
            this.Panel_MovieName = new System.Windows.Forms.Panel();
            this.Label_Subtitle = new System.Windows.Forms.Label();
            this.Label_MovieName = new System.Windows.Forms.Label();
            this.PictureBox_ImageMovie = new System.Windows.Forms.PictureBox();
            this.Panel_ControlMovie.SuspendLayout();
            this.Panel_MovieName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ImageMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_ControlMovie
            // 
            this.Panel_ControlMovie.Controls.Add(this.Panel_MovieName);
            this.Panel_ControlMovie.Controls.Add(this.PictureBox_ImageMovie);
            this.Panel_ControlMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_ControlMovie.Location = new System.Drawing.Point(0, 0);
            this.Panel_ControlMovie.Name = "Panel_ControlMovie";
            this.Panel_ControlMovie.Size = new System.Drawing.Size(306, 453);
            this.Panel_ControlMovie.TabIndex = 4;
            // 
            // Panel_MovieName
            // 
            this.Panel_MovieName.BackColor = System.Drawing.Color.Black;
            this.Panel_MovieName.Controls.Add(this.Label_Subtitle);
            this.Panel_MovieName.Controls.Add(this.Label_MovieName);
            this.Panel_MovieName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_MovieName.Location = new System.Drawing.Point(8, 345);
            this.Panel_MovieName.Name = "Panel_MovieName";
            this.Panel_MovieName.Size = new System.Drawing.Size(290, 95);
            this.Panel_MovieName.TabIndex = 2;
            this.Panel_MovieName.MouseEnter += new System.EventHandler(this.PictureBox_ImageMovie_MouseEnter);
            this.Panel_MovieName.MouseLeave += new System.EventHandler(this.PictureBox_ImageMovie_MouseLeave);
            // 
            // Label_Subtitle
            // 
            this.Label_Subtitle.AutoSize = true;
            this.Label_Subtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Subtitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Subtitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Subtitle.ForeColor = System.Drawing.Color.White;
            this.Label_Subtitle.Location = new System.Drawing.Point(18, 60);
            this.Label_Subtitle.Name = "Label_Subtitle";
            this.Label_Subtitle.Size = new System.Drawing.Size(82, 18);
            this.Label_Subtitle.TabIndex = 1;
            this.Label_Subtitle.Text = "HD/VietSub";
            this.Label_Subtitle.MouseEnter += new System.EventHandler(this.PictureBox_ImageMovie_MouseEnter);
            this.Label_Subtitle.MouseLeave += new System.EventHandler(this.PictureBox_ImageMovie_MouseLeave);
            // 
            // Label_MovieName
            // 
            this.Label_MovieName.AutoSize = true;
            this.Label_MovieName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_MovieName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MovieName.ForeColor = System.Drawing.Color.White;
            this.Label_MovieName.Location = new System.Drawing.Point(13, 12);
            this.Label_MovieName.MaximumSize = new System.Drawing.Size(250, 0);
            this.Label_MovieName.Name = "Label_MovieName";
            this.Label_MovieName.Size = new System.Drawing.Size(185, 21);
            this.Label_MovieName.TabIndex = 0;
            this.Label_MovieName.Text = "Đây là label ghi tên film";
            this.Label_MovieName.MouseEnter += new System.EventHandler(this.PictureBox_ImageMovie_MouseEnter);
            this.Label_MovieName.MouseLeave += new System.EventHandler(this.PictureBox_ImageMovie_MouseLeave);
            // 
            // PictureBox_ImageMovie
            // 
            this.PictureBox_ImageMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_ImageMovie.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_ImageMovie.Image")));
            this.PictureBox_ImageMovie.Location = new System.Drawing.Point(8, 10);
            this.PictureBox_ImageMovie.Name = "PictureBox_ImageMovie";
            this.PictureBox_ImageMovie.Size = new System.Drawing.Size(290, 335);
            this.PictureBox_ImageMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox_ImageMovie.TabIndex = 1;
            this.PictureBox_ImageMovie.TabStop = false;
            this.PictureBox_ImageMovie.MouseEnter += new System.EventHandler(this.PictureBox_ImageMovie_MouseEnter);
            this.PictureBox_ImageMovie.MouseLeave += new System.EventHandler(this.PictureBox_ImageMovie_MouseLeave);
            // 
            // Controls_Movie
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Panel_ControlMovie);
            this.Name = "Controls_Movie";
            this.Size = new System.Drawing.Size(306, 453);
            this.Panel_ControlMovie.ResumeLayout(false);
            this.Panel_MovieName.ResumeLayout(false);
            this.Panel_MovieName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ImageMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_ControlMovie;
        private System.Windows.Forms.Panel Panel_MovieName;
        private System.Windows.Forms.Label Label_Subtitle;
        private System.Windows.Forms.Label Label_MovieName;
        private System.Windows.Forms.PictureBox PictureBox_ImageMovie;
    }
}
