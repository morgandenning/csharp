using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Engine.Classes.Hero.Class
{
    public class Rogue : IClass
    {
        public string Title
        {
            get { return "Rogue"; }
            set { }
        }

        public int Health
        {
            get { return 100; }
            set { }
        }

        public int Stamina
        {
            get { return 120; }
            set { }
        }

        public Brush StaminaColor
        {
            get { return System.Windows.Media.Brushes.Yellow; }
        }

    }
}
