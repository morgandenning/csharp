using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Engine.Classes.Hero.Class
{
    public interface IClass
    {
        string Title
        {
            get;
            set;
        }
        int Health
        {
            get;
            set;
        }

        int Stamina
        {
            get;
            set;
        }

        Brush StaminaColor
        {
            get;
        }
    }
}
