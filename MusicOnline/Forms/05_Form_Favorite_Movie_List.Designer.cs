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
            this.SuspendLayout();
            // 
            // Panel_Tools
            // 
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
            // _05_Form_Favorite_Movie_List
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1566, 847);
            this.Controls.Add(this.FlowLayoutPanel_ShowListMovie);
            this.Controls.Add(this.Panel_Tools);
            this.Name = "_05_Form_Favorite_Movie_List";
            this.Text = "_05_Form_Favorite_Movie_List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Tools;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_ShowListMovie;
    }
}