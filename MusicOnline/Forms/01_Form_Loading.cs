using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicOnline.Forms
{
    public partial class _01_Form_Loading : Form
    {
        public _01_Form_Loading()
        {
            InitializeComponent();

            // Initialization
            WaitLoadingForm();
        }

        public async void WaitLoadingForm()
        {
            await Task.Delay(3000);
            Form LoginForm = new _02_Form_Home();
            this.Hide();
            LoginForm.Show();
        }
    }
}
