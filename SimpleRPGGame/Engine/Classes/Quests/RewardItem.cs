using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes.Quests
{
    public class RewardItem
    {
        public Item Details
        {
            get;
            set;
        }

        public RewardItem(Item details)
        {
            this.Details = details;
        }
    }
}
