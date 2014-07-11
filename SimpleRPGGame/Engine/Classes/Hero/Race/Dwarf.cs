using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes.Hero.Race
{
    public class Dwarf : IRace
    {
        public string Title
        {
            get { return "Dwarf"; }
        }

        public string Image
        {
            get { return "/Engine;component/Assets/Images/Icons/Portraits/dwarf_m_64.png"; }
        }

        public Dwarf()
        {
            //
        }
    }
}
