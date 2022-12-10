using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicOnline.Assets.Variables
{
    public class ListFormPanel
    {
        private static List<Panel> listFormsPanel = new List<Panel>();

        public static List<Panel> ListFormsPanel { get => listFormsPanel; set => listFormsPanel=value; }
    }
}
