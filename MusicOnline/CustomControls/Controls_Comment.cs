using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicOnline.CustomControls
{
    public partial class Controls_Comment : UserControl
    {
        public Controls_Comment()
        {
            //InitializeComponent();
        }

        public Controls_Comment(DataRow dr) : this()
        {
            InitializeComponent();
            BackColor = Assets.Variables.Colors.BlackOlive;

            Label_Name.Text = dr["COMMENT_NAME"].ToString();
            Label_Comment.Text = dr["COMMENT_TEXT"].ToString();
            Label_Time.Text = dr["COMMENT_TIME"].ToString();
        }
    }
}
