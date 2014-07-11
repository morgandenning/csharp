using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes.Hero.Race
{
    public class Gnome : IRace
    {
        public string Title
        {
            get { return "Gnome"; }
        }

        public string Image
        {
            get { return "/Engine;component/Assets/Images/Icons/Portraits/gnome_m_64.png"; }
        }

        public Gnome()
        {
            //
        }
    }
}
