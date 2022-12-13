namespace MusicOnline.Forms
{
    partial class _05_Form_Favorite_Movie_List
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
            this.FlowLayoutPanel_ShowListMovie = new System.Windows.Forms.FlowLayoutPanel();
            this.Label_MovieName = new System.Windows.Forms.Label();
            this.Label_MovieNameEng = new System.Windows.Forms.Label();
            this.Label_NumberOfMovie = new System.Windows.Forms.Label();
            this.Button_ShowAllMovie = new FontAwesome.Sharp.IconButton();
            this.Button_RemoveAllMovie = new FontAwesome.Sharp.IconButton();
            this.Panel_Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Tools
            // 
            this.Panel_Tools.Controls.Add(this.Label_NumberOfMovie);
            this.Panel_Tools.Controls.Add(this.Label_MovieNameEng);
            this.Panel_Tools.Controls.Add(this.Label_MovieName);
            this.Panel_Tools.Controls.Add(this.Button_ShowAllMovie);
            this.Panel_Tools.Controls.Add(this.Button_RemoveAllMovie);
            this.Panel_Tools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Tools.Location = new System.Drawing.Point(0, 720);
            this.Panel_Tools.Name = "Panel_Tools";
            this.Panel_Tools.Size = new System.Drawing.Size(1566, 127);
            this.Panel_Tools.TabIndex = 0;
            // 
            // FlowLayoutPanel_ShowListMovie
            // 
            this.FlowLayoutPanel_ShowListMovie.AutoScroll = true;
            this.FlowLayoutPanel_ShowListMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel_ShowListMovie.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel_ShowListMovie.Name = "FlowLayoutPanel_ShowListMovie";
            this.FlowLayoutPanel_ShowListMovie.Size = new System.Drawing.Size(1566, 720);
            this.FlowLayoutPanel_ShowListMovie.TabIndex = 1;
            // 
            // Label_MovieName
            // 
            this.Label_MovieName.AutoSize = true;
            this.Label_MovieName.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MovieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_MovieName.Location = new System.Drawing.Point(32, 16);
            this.Label_MovieName.Name = "Label_MovieName";
            this.Label_MovieName.Size = new System.Drawing.Size(401, 52);
            this.Label_MovieName.TabIndex = 5;
            this.Label_MovieName.Text = "DANH SÁCH PHIM YÊU THÍCH";
            // 
            // Label_MovieNameEng
            // 
            this.Label_MovieNameEng.AutoSize = true;
            this.Label_MovieNameEng.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MovieNameEng.ForeColor = System.Drawing.Color.White;
            this.Label_MovieNameEng.Location = new System.Drawing.Point(37, 82);
            this.Label_MovieNameEng.Name = "Label_MovieNameEng";
            this.Label_MovieNameEng.Size = new System.Drawing.Size(97, 23);
            this.Label_MovieNameEng.TabIndex = 30;
            this.Label_MovieNameEng.Text = "Số lượng:";
            // 
            // Label_NumberOfMovie
            // 
            this.Label_NumberOfMovie.AutoSize = true;
            this.Label_NumberOfMovie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NumberOfMovie.ForeColor = System.Drawing.Color.White;
            this.Label_NumberOfMovie.Location = new System.Drawing.Point(140, 82);
            this.Label_NumberOfMovie.Name = "Label_NumberOfMovie";
            this.Label_NumberOfMovie.Size = new System.Drawing.Size(21, 23);
            this.Label_NumberOfMovie.TabIndex = 31;
            this.Label_NumberOfMovie.Text = "0";
            // 
            // Button_ShowAllMovie
            // 
            this.Button_ShowAllMovie.BackColor = System.Drawing.Color.Transparent;
            this.Button_ShowAllMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ShowAllMovie.FlatAppearance.BorderSize = 0;
            this.Button_ShowAllMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ShowAllMovie.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ShowAllMovie.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_ShowAllMovie.IconColor = System.Drawing.Color.Black;
            this.Button_ShowAllMovie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_ShowAllMovie.Location = new System.Drawing.Point(987, 29);
            this.Button_ShowAllMovie.Name = "Button_ShowAllMovie";
            this.Button_ShowAllMovie.Size = new System.Drawing.Size(238, 65);
            this.Button_ShowAllMovie.TabIndex = 4;
            this.Button_ShowAllMovie.Text = "Phát tất cả";
            this.Button_ShowAllMovie.UseVisualStyleBackColor = false;
            this.Button_ShowAllMovie.Click += new System.EventHandler(this.Button_ShowAllMovie_Click);
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
            this.Button_RemoveAllMovie.Location = new System.Drawing.Point(1266, 29);
            this.Button_RemoveAllMovie.Name = "Button_RemoveAllMovie";
            this.Button_RemoveAllMovie.Size = new System.Drawing.Size(238, 65);
            this.Button_RemoveAllMovie.TabIndex = 3;
            this.Button_RemoveAllMovie.Text = "Xóa tất cả";
            this.Button_RemoveAllMovie.UseVisualStyleBackColor = false;
            this.Button_RemoveAllMovie.Click += new System.EventHandler(this.Button_RemoveAllMovie_Click);
            // 
            // _05_Form_Favorite_Movie_List
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1566, 847);
            this.Controls.Add(this.FlowLayoutPanel_ShowListMovie);
            this.Controls.Add(this.Panel_Tools);
            this.Name = "_05_Form_Favorite_Movie_List";
            this.Text = "_05_Form_Favorite_Movie_List";
            this.Panel_Tools.ResumeLayout(false);
            this.Panel_Tools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Tools;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_ShowListMovie;
        private FontAwesome.Sharp.IconButton Button_ShowAllMovie;
        private FontAwesome.Sharp.IconButton Button_RemoveAllMovie;
        private System.Windows.Forms.Label Label_MovieName;
        private System.Windows.Forms.Label Label_NumberOfMovie;
        private System.Windows.Forms.Label Label_MovieNameEng;
    }
}