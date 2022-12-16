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
            this.Panel_CommentInfo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBox_Comment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_CommentOK = new FontAwesome.Sharp.IconButton();
            this.Panel_WatchMovie.SuspendLayout();
            this.Panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP_MovieVideo)).BeginInit();
            this.Panel_CommentInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_WatchMovie
            // 
            this.Panel_WatchMovie.Controls.Add(this.Panel_CommentInfo);
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
            this.FlowLayoutPanel_MovieInvolve.Size = new System.Drawing.Size(410, 521);
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
            // Panel_CommentInfo
            // 
            this.Panel_CommentInfo.Controls.Add(this.Button_CommentOK);
            this.Panel_CommentInfo.Controls.Add(this.label2);
            this.Panel_CommentInfo.Controls.Add(this.label1);
            this.Panel_CommentInfo.Controls.Add(this.panel3);
            this.Panel_CommentInfo.Controls.Add(this.panel2);
            this.Panel_CommentInfo.Location = new System.Drawing.Point(1130, 563);
            this.Panel_CommentInfo.Name = "Panel_CommentInfo";
            this.Panel_CommentInfo.Size = new System.Drawing.Size(410, 255);
            this.Panel_CommentInfo.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.TextBox_Name);
            this.panel2.Location = new System.Drawing.Point(16, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 44);
            this.panel2.TabIndex = 2;
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.BackColor = System.Drawing.Color.White;
            this.TextBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Name.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Name.ForeColor = System.Drawing.Color.Gray;
            this.TextBox_Name.Location = new System.Drawing.Point(13, 13);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(242, 21);
            this.TextBox_Name.TabIndex = 0;
            this.TextBox_Name.Text = "Nhập tên";
            this.TextBox_Name.Enter += new System.EventHandler(this.TextBox_Name_Enter);
            this.TextBox_Name.Leave += new System.EventHandler(this.TextBox_Name_Leave);
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.TextBox_Comment);
            this.panel3.Location = new System.Drawing.Point(16, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 86);
            this.panel3.TabIndex = 3;
            // 
            // TextBox_Comment
            // 
            this.TextBox_Comment.BackColor = System.Drawing.Color.White;
            this.TextBox_Comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Comment.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Comment.ForeColor = System.Drawing.Color.Gray;
            this.TextBox_Comment.Location = new System.Drawing.Point(13, 14);
            this.TextBox_Comment.MaximumSize = new System.Drawing.Size(400, 0);
            this.TextBox_Comment.Multiline = true;
            this.TextBox_Comment.Name = "TextBox_Comment";
            this.TextBox_Comment.Size = new System.Drawing.Size(341, 56);
            this.TextBox_Comment.TabIndex = 0;
            this.TextBox_Comment.Text = "Nhập bình luận";
            this.TextBox_Comment.Enter += new System.EventHandler(this.TextBox_Comment_Enter);
            this.TextBox_Comment.Leave += new System.EventHandler(this.TextBox_Comment_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bình luận";
            // 
            // Button_CommentOK
            // 
            this.Button_CommentOK.BackColor = System.Drawing.Color.Green;
            this.Button_CommentOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_CommentOK.FlatAppearance.BorderSize = 0;
            this.Button_CommentOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_CommentOK.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_CommentOK.ForeColor = System.Drawing.Color.White;
            this.Button_CommentOK.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_CommentOK.IconColor = System.Drawing.Color.Black;
            this.Button_CommentOK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_CommentOK.Location = new System.Drawing.Point(273, 217);
            this.Button_CommentOK.Name = "Button_CommentOK";
            this.Button_CommentOK.Size = new System.Drawing.Size(118, 34);
            this.Button_CommentOK.TabIndex = 6;
            this.Button_CommentOK.Text = "Đánh giá";
            this.Button_CommentOK.UseVisualStyleBackColor = false;
            this.Button_CommentOK.Click += new System.EventHandler(this.Button_CommentOK_Click);
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
            this.Panel_CommentInfo.ResumeLayout(false);
            this.Panel_CommentInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_WatchMovie;
        private System.Windows.Forms.Panel Panel_Body;
        private AxWMPLib.AxWindowsMediaPlayer WMP_MovieVideo;
        private System.Windows.Forms.Label Label_MovieNameEng;
        private System.Windows.Forms.Label Label_MovieName;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_MovieInvolve;
        private System.Windows.Forms.Panel Panel_CommentInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TextBox_Comment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Button_CommentOK;
    }
}