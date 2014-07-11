using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes
{
    public class Quest
    {
        public int ID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public int RewardExp
        {
            get;
            set;
        }
        public int RewardGold
        {
            get;
            set;
        }

        //public List<Quests.QuestCompletionItem> QuestCompletionItems
        //{
        //    get;
        //    set;
        //}

        public Item RewardItem
        {
            get;
            set;
        }

        public Quest(int id, string name, string desc, int rewardExp, int rewardGold)
        {
            this.ID = id;
            this.Name = name;
            this.Description = desc;
            this.RewardExp = rewardExp;
            this.RewardGold = rewardGold;

            //this.QuestCompletionItems = new List<Quests.QuestCompletionItem>();
        }
    }
}
