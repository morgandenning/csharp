using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes.Hero.Race
{
    public class Human : IRace
    {
        public string Title
        {
            get { return "Human"; }
        }

        public string Image
        {
            get { return "/Engine;component/Assets/Images/Icons/Portraits/human_m_64.png"; }
        }

        public Human()
        {
            //
        }
    }
}
