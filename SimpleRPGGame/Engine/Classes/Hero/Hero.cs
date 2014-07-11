using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes.Hero
{
    [Serializable]
    public class Hero : IHumanoid, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            Console.WriteLine("PropChange {0}", caller);

            if (PropertyChanged != null)
            {
                Console.WriteLine("Trigger");
                PropertyChanged(this, new PropertyChangedEventArgs(caller));

                Console.WriteLine("_sName {0}", _sName);
                Console.WriteLine("sName {0}", sName);
            }
        }

        public string RacePortraitImage
        {
            get { return this.heroRace.Image; }
        }

        private string _sName;
        public string sName
        {
            get
            {
                return _sName;
            }
            set
            {
                _sName = value;
                Console.WriteLine("set {0}", value);
                RaisePropertyChanged();
            }
        }

        public int iCurrentHitPoints
        {
            get;
            set;
        }
        public int iMaxHitPoints
        {
            get;
            set;
        }

        public int iCurrentStaminaPoints
        {
            get;
            set;
        }
        public int iMaxStaminaPoints
        {
            get;
            set;
        }

        private int _iGold;
        public int iGold
        {
            get
            {
                return _iGold;
            }
            set
            {
                _iGold = value;
                Console.WriteLine("set {0}", value);
                RaisePropertyChanged();
            }
        }

        private int _iLevel;
        public int iLevel
        {
            get
            {
                return _iLevel;
            }
            set
            {
                _iLevel = value;
                Console.WriteLine("set {0}", value);
                RaisePropertyChanged();
            }
        }

        private int _iExp;
        public int iExp
        {
            get
            {
                return _iExp;
            }
            set
            {
                _iExp = value;
                Console.WriteLine("set {0}", value);
                RaisePropertyChanged();
            }
        }

        public Class.IClass heroClass
        {
            get;
            set;
        }
        public Race.IRace heroRace
        {
            get;
            set;
        }

        public List<Engine.Classes.Items.InventoryItem> Inventory
        {
            get;
            set;
        }
        public List<HeroQuest> Quests
        {
            get;
            set;
        }

        public Location CurrentLocation
        {
            get;
            set;
        }

        private string _feedbackMessages;
        public string FeedbackMessages
        {
            get
            {
                return _feedbackMessages;
            }
            set
            {
                _feedbackMessages += value + Environment.NewLine;
                Console.WriteLine("set feedbackmessage {0}", value);
                RaisePropertyChanged();
            }
        }

        public Hero()
        {
            this.sName = "New Hero";
            this.SetRace("Human");
            this.SetClass("Warrior");

            this.iLevel = 1;

            this.Inventory = new List<Engine.Classes.Items.InventoryItem>();
            this.Quests = new List<HeroQuest>();

            this.CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);
        }

        public Hero(string sName, string sRace, string sClass)
        {
            this.sName = sName;
            this.SetRace(sRace);
            this.SetClass(sClass);

            this.iLevel = 1;

            this.Inventory = new List<Engine.Classes.Items.InventoryItem>();
            this.Quests = new List<HeroQuest>();

            this.CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);
        }

        public void SetRace(string sRace)
        {
            this.heroRace = (Race.IRace)Activator.CreateInstance(null, "Engine.Classes.Hero.Race." + sRace).Unwrap();
            RaisePropertyChanged("RacePortraitImage");
        }

        public void SetClass(string sClass)
        {
            this.heroClass = (Class.IClass)Activator.CreateInstance(null, "Engine.Classes.Hero.Class." + sClass).Unwrap();
        }

        public void AddFeedbackMessage(string message)
        {
            this.FeedbackMessages = message;
        }

        public void MoveHero(Location location)
        {
            if (location != null)
            {
                this.CurrentLocation = location;
                RaisePropertyChanged("CurrentLocation");

                if (this.CurrentLocation.QuestAvailableHere != null)
                {
                    if (this.Quests.Exists(x => x.Details == this.CurrentLocation.QuestAvailableHere))
                    {
                        Console.WriteLine("Quest Exists");
                    }
                    else
                    {
                        this.AddFeedbackMessage(string.Format("You recieved a new quest: {0}", this.CurrentLocation.QuestAvailableHere.Name));
                        this.AddFeedbackMessage(this.CurrentLocation.QuestAvailableHere.Description);
                        this.Quests.Add(new HeroQuest(this.CurrentLocation.QuestAvailableHere));
                    }
                }
            }
            else
            {
                //
            }
        }
    }
}
