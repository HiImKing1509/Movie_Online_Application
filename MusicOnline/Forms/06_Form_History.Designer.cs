namespace MusicOnline.Forms
{
    partial class _06_Form_History
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
            this.Panel_Tools = new System.Windows.Forms.Panel();
            this.Label_MovieName = new System.Windows.Forms.Label();
            this.FlowLayoutPanel_ShowListMovie = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowLayoutPanel_MainPage = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_RemoveAllMovie = new FontAwesome.Sharp.IconButton();
            this.Panel_Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Tools
            // 
            this.Panel_Tools.Controls.Add(this.Label_MovieName);
            this.Panel_Tools.Controls.Add(this.Button_RemoveAllMovie);
            this.Panel_Tools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Tools.Location = new System.Drawing.Point(0, 750);
            this.Panel_Tools.Name = "Panel_Tools";
            this.Panel_Tools.Size = new System.Drawing.Size(1566, 118);
            this.Panel_Tools.TabIndex = 1;
            // 
            // Label_MovieName
            // 
            this.Label_MovieName.AutoSize = true;
            this.Label_MovieName.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MovieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_MovieName.Location = new System.Drawing.Point(26, 36);
            this.Label_MovieName.Name = "Label_MovieName";
            this.Label_MovieName.Size = new System.Drawing.Size(273, 52);
            this.Label_MovieName.TabIndex = 5;
            this.Label_MovieName.Text = "LỊCH SỬ XEM PHIM";
            // 
            // FlowLayoutPanel_ShowListMovie
            // 
            this.FlowLayoutPanel_ShowListMovie.AutoScroll = true;
            this.FlowLayoutPanel_ShowListMovie.Location = new System.Drawing.Point(1089, 76);
            this.FlowLayoutPanel_ShowListMovie.Name = "FlowLayoutPanel_ShowListMovie";
            this.FlowLayoutPanel_ShowListMovie.Size = new System.Drawing.Size(465, 653);
            this.FlowLayoutPanel_ShowListMovie.TabIndex = 2;
            // 
            // FlowLayoutPanel_MainPage
            // 
            this.FlowLayoutPanel_MainPage.AutoScroll = true;
            this.FlowLayoutPanel_MainPage.Location = new System.Drawing.Point(12, 76);
            this.FlowLayoutPanel_MainPage.Name = "FlowLayoutPanel_MainPage";
            this.FlowLayoutPanel_MainPage.Size = new System.Drawing.Size(1057, 653);
            this.FlowLayoutPanel_MainPage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "DANH SÁCH LỊCH SỬ PHIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1080, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 52);
            this.label2.TabIndex = 7;
            this.label2.Text = "TẦN SUẤT XEM PHIM";
            // 
            // Button_RemoveAllMovie
            // 
            this.Button_RemoveAllMovie.BackColor = System.Drawing.Color.Transparent;
            this.Button_RemoveAllMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RemoveAllMovie.FlatAppearance.BorderSize = 0;
            this.Button_RemoveAllMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RemoveAllMovie.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_RemoveAllMovie.ForeColor = System.Drawing.Color.White;
            this.Button_RemoveAllMovie.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_RemoveAllMovie.IconColor = System.Drawing.Color.Black;
            this.Button_RemoveAllMovie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_RemoveAllMovie.Location = new System.Drawing.Point(1266, 23);
            this.Button_RemoveAllMovie.Name = "Button_RemoveAllMovie";
            this.Button_RemoveAllMovie.Size = new System.Drawing.Size(238, 65);
            this.Button_RemoveAllMovie.TabIndex = 3;
            this.Button_RemoveAllMovie.Text = "Xóa lịch sử";
            this.Button_RemoveAllMovie.UseVisualStyleBackColor = false;
            this.Button_RemoveAllMovie.Click += new System.EventHandler(this.Button_RemoveAllMovie_Click);
            // 
            // _06_Form_History
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1566, 868);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlowLayoutPanel_MainPage);
            this.Controls.Add(this.FlowLayoutPanel_ShowListMovie);
            this.Controls.Add(this.Panel_Tools);
            this.Name = "_06_Form_History";
            this.Text = "_06_Form_History";
            this.Panel_Tools.ResumeLayout(false);
            this.Panel_Tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Tools;
        private System.Windows.Forms.Label Label_MovieName;
        private FontAwesome.Sharp.IconButton Button_RemoveAllMovie;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_ShowListMovie;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_MainPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}