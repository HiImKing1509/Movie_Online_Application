namespace MusicOnline.Forms
{
    partial class _08_Form_Watching_list_Movie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_08_Form_Watching_list_Movie));
            this.FlowLayoutPanel_MovieInvolve = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Label_MovieNameEng = new System.Windows.Forms.Label();
            this.Label_MovieName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowLayoutPanel_MovieInvolve
            // 
            this.FlowLayoutPanel_MovieInvolve.AutoScroll = true;
            this.FlowLayoutPanel_MovieInvolve.Location = new System.Drawing.Point(1120, 109);
            this.FlowLayoutPanel_MovieInvolve.Name = "FlowLayoutPanel_MovieInvolve";
            this.FlowLayoutPanel_MovieInvolve.Size = new System.Drawing.Size(434, 723);
            this.FlowLayoutPanel_MovieInvolve.TabIndex = 3;
            // 
            // Panel_Body
            // 
            this.Panel_Body.Controls.Add(this.axWindowsMediaPlayer1);
            this.Panel_Body.Controls.Add(this.Label_MovieNameEng);
            this.Panel_Body.Controls.Add(this.Label_MovieName);
            this.Panel_Body.Location = new System.Drawing.Point(29, 37);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(1074, 795);
            this.Panel_Body.TabIndex = 2;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1074, 659);
            this.axWindowsMediaPlayer1.TabIndex = 32;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1125, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 52);
            this.label1.TabIndex = 31;
            this.label1.Text = "DANH SÁCH PHIM";
            // 
            // _08_Form_Watching_list_Movie
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1566, 868);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlowLayoutPanel_MovieInvolve);
            this.Controls.Add(this.Panel_Body);
            this.Name = "_08_Form_Watching_list_Movie";
            this.Text = "_08_Form_Watching_list_Movie";
            this.Panel_Body.ResumeLayout(false);
            this.Panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_MovieInvolve;
        private System.Windows.Forms.Panel Panel_Body;
        private System.Windows.Forms.Label Label_MovieNameEng;
        private System.Windows.Forms.Label Label_MovieName;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}