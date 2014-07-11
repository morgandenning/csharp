using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes.Hero
{
    [Serializable]
    public class HeroQuest
    {
        public Quest Details
        {
            get;
            set;
        }
        public bool Completed
        {
            get;
            set;
        }

        public HeroQuest(Quest details)
        {
            this.Details = details;
            this.Completed = false;
        }
    }
}
