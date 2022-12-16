using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.Assets.Variables
{
    public class GlobalVariables
    {
        private static string select_playlist = "";

        public static string Select_playlist { get => select_playlist; set => select_playlist=value; }
    }
}
