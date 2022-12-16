namespace MusicOnline.CustomControls
{
    partial class Controls_Comment
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
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Comment = new System.Windows.Forms.Label();
            this.Label_Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label_Name.Location = new System.Drawing.Point(22, 13);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(241, 24);
            this.Label_Name.TabIndex = 36;
            this.Label_Name.Text = "THẾ GIỚI KHÔNG LỐI THOÁT (PHẦN 2)";
            // 
            // Label_Comment
            // 
            this.Label_Comment.AutoSize = true;
            this.Label_Comment.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Comment.ForeColor = System.Drawing.Color.White;
            this.Label_Comment.Location = new System.Drawing.Point(22, 44);
            this.Label_Comment.Name = "Label_Comment";
            this.Label_Comment.Size = new System.Drawing.Size(79, 22);
            this.Label_Comment.TabIndex = 43;
            this.Label_Comment.Text = "Lượt xem:";
            // 
            // Label_Time
            // 
            this.Label_Time.AutoSize = true;
            this.Label_Time.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Time.ForeColor = System.Drawing.Color.White;
            this.Label_Time.Location = new System.Drawing.Point(190, 72);
            this.Label_Time.Name = "Label_Time";
            this.Label_Time.Size = new System.Drawing.Size(58, 21);
            this.Label_Time.TabIndex = 52;
            this.Label_Time.Text = "00:00:00";
            // 
            // Controls_Comment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Label_Time);
            this.Controls.Add(this.Label_Comment);
            this.Controls.Add(this.Label_Name);
            this.Name = "Controls_Comment";
            this.Size = new System.Drawing.Size(379, 102);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_Comment;
        private System.Windows.Forms.Label Label_Time;
    }
}
