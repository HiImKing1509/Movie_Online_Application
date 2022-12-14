using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.Assets.Variables
{
    public class ResourcesManager
    {
        public static ResourceManager rm_logo = new ResourceManager("MusicOnline.Assets.Images.Logo", Assembly.GetExecutingAssembly());
        public static ResourceManager rm_movies = new ResourceManager("MusicOnline.Assets.Images.Images_Movie", Assembly.GetExecutingAssembly());
        public static ResourceManager rm_icon = new ResourceManager("MusicOnline.Assets.Images.Icon", Assembly.GetExecutingAssembly());
    }
}
