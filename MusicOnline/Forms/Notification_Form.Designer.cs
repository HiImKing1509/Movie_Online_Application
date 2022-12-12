namespace MusicOnline.Forms
{
    partial class Notification_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification_Form));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label_Notifications = new System.Windows.Forms.Label();
            this.Button_Close = new FontAwesome.Sharp.IconButton();
            this.PictureBox_Icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Label_Notifications
            // 
            this.Label_Notifications.AutoSize = true;
            this.Label_Notifications.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Notifications.ForeColor = System.Drawing.Color.White;
            this.Label_Notifications.Location = new System.Drawing.Point(153, 40);
            this.Label_Notifications.Name = "Label_Notifications";
            this.Label_Notifications.Size = new System.Drawing.Size(71, 26);
            this.Label_Notifications.TabIndex = 5;
            this.Label_Notifications.Text = "label1";
            // 
            // Button_Close
            // 
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.IconChar = FontAwesome.Sharp.IconChar.X;
            this.Button_Close.IconColor = System.Drawing.Color.White;
            this.Button_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Close.IconSize = 24;
            this.Button_Close.Location = new System.Drawing.Point(449, 34);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(47, 40);
            this.Button_Close.TabIndex = 6;
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // PictureBox_Icon
            // 
            this.PictureBox_Icon.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_Icon.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Icon.Image")));
            this.PictureBox_Icon.Location = new System.Drawing.Point(40, 26);
            this.PictureBox_Icon.Name = "PictureBox_Icon";
            this.PictureBox_Icon.Size = new System.Drawing.Size(56, 55);
            this.PictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Icon.TabIndex = 4;
            this.PictureBox_Icon.TabStop = false;
            // 
            // Notification_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 106);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Label_Notifications);
            this.Controls.Add(this.PictureBox_Icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification_Form";
            this.Text = "Notification_Form";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton Button_Close;
        private System.Windows.Forms.Label Label_Notifications;
        private System.Windows.Forms.PictureBox PictureBox_Icon;
    }
}