namespace MusicOnline.Forms
{
    partial class _04_Form_Watching_Movie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_04_Form_Watching_Movie));
            this.Panel_WatchMovie = new System.Windows.Forms.Panel();
            this.FlowLayoutPanel_MovieInvolve = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.Label_MovieNameEng = new System.Windows.Forms.Label();
            this.Label_MovieName = new System.Windows.Forms.Label();
            this.WMP_MovieVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.Panel_WatchMovie.SuspendLayout();
            this.Panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP_MovieVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_WatchMovie
            // 
            this.Panel_WatchMovie.Controls.Add(this.FlowLayoutPanel_MovieInvolve);
            this.Panel_WatchMovie.Controls.Add(this.Panel_Body);
            this.Panel_WatchMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_WatchMovie.Location = new System.Drawing.Point(0, 0);
            this.Panel_WatchMovie.Name = "Panel_WatchMovie";
            this.Panel_WatchMovie.Size = new System.Drawing.Size(1566, 847);
            this.Panel_WatchMovie.TabIndex = 0;
            // 
            // FlowLayoutPanel_MovieInvolve
            // 
            this.FlowLayoutPanel_MovieInvolve.AutoScroll = true;
            this.FlowLayoutPanel_MovieInvolve.Location = new System.Drawing.Point(1130, 23);
            this.FlowLayoutPanel_MovieInvolve.Name = "FlowLayoutPanel_MovieInvolve";
            this.FlowLayoutPanel_MovieInvolve.Size = new System.Drawing.Size(410, 795);
            this.FlowLayoutPanel_MovieInvolve.TabIndex = 1;
            // 
            // Panel_Body
            // 
            this.Panel_Body.Controls.Add(this.Label_MovieNameEng);
            this.Panel_Body.Controls.Add(this.Label_MovieName);
            this.Panel_Body.Controls.Add(this.WMP_MovieVideo);
            this.Panel_Body.Location = new System.Drawing.Point(32, 23);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(1074, 795);
            this.Panel_Body.TabIndex = 0;
            // 
            // Label_MovieNameEng
            // 
            this.Label_MovieNameEng.AutoSize = true;
            this.Label_MovieNameEng.BackColor = System.Drawing.Color.Transparent;
            this.Label_MovieNameEng.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MovieNameEng.ForeColor = System.Drawing.Color.White;
            this.Label_MovieNameEng.Location = new System.Drawing.Point(21, 745);
            this.Label_MovieNameEng.Name = "Label_MovieNameEng";
            this.Label_MovieNameEng.Size = new System.Drawing.Size(358, 19);
            this.Label_MovieNameEng.TabIndex = 31;
            this.Label_MovieNameEng.Text = "The Hobbit: The Battle of the Five Armies (2014)";
            // 
            // Label_MovieName
            // 
            this.Label_MovieName.AutoSize = true;
            this.Label_MovieName.BackColor = System.Drawing.Color.Transparent;
            this.Label_MovieName.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MovieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_MovieName.Location = new System.Drawing.Point(16, 679);
            this.Label_MovieName.Name = "Label_MovieName";
            this.Label_MovieName.Size = new System.Drawing.Size(485, 52);
            this.Label_MovieName.TabIndex = 30;
            this.Label_MovieName.Text = "CHIẾC BẬT LỬA VÀ VÁY CÔNG CHÚA";
            // 
            // WMP_MovieVideo
            // 
            this.WMP_MovieVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.WMP_MovieVideo.Enabled = true;
            this.WMP_MovieVideo.Location = new System.Drawing.Point(0, 0);
            this.WMP_MovieVideo.Name = "WMP_MovieVideo";
            this.WMP_MovieVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP_MovieVideo.OcxState")));
            this.WMP_MovieVideo.Size = new System.Drawing.Size(1074, 659);
            this.WMP_MovieVideo.TabIndex = 0;
            this.WMP_MovieVideo.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.WMP_MovieVideo_ClickEvent);
            // 
            // _04_Form_Watching_Movie
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1566, 847);
            this.Controls.Add(this.Panel_WatchMovie);
            this.Name = "_04_Form_Watching_Movie";
            this.Text = "_04_Form_Watching_Movie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._04_Form_Watching_Movie_FormClosing);
            this.Panel_WatchMovie.ResumeLayout(false);
            this.Panel_Body.ResumeLayout(false);
            this.Panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP_MovieVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_WatchMovie;
        private System.Windows.Forms.Panel Panel_Body;
        private AxWMPLib.AxWindowsMediaPlayer WMP_MovieVideo;
        private System.Windows.Forms.Label Label_MovieNameEng;
        private System.Windows.Forms.Label Label_MovieName;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_MovieInvolve;
    }
}