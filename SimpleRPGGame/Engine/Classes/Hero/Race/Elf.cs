using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes.Hero.Race
{
    public class Elf : IRace
    {
        public string Title
        {
            get { return "Elf"; }
        }

        public string Image
        {
            get { return "/Engine;component/Assets/Images/Icons/Portraits/elf_m_64.png"; }
        }

        public Elf()
        {
            //
        }
    }
}
