using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Engine.Classes.Sound
{
    public class Music
    {
        private static SoundPlayer MainThemeSP;

        public static void InitMainTheme()
        {
            MainThemeSP = new SoundPlayer("Assets/Sounds/Music/MainTheme.wav");
        }

        public static void StartMainTheme()
        {
            MainThemeSP.PlayLooping();
        }

        public static void StopMainTheme()
        {
            MainThemeSP.Stop();
        }
    }
}
