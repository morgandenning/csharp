﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes
{
    public class Location
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

        public Item ItemRequiredToEnter
        {
            get;
            set;
        }

        public Quest QuestAvailableHere
        {
            get;
            set;
        }

        public Monster MonsterExistsHere
        {
            get;
            set;
        }

        public Location LocationToNorth
        {
            get;
            set;
        }

        public Location LocationToSouth
        {
            get;
            set;
        }

        public Location LocationToEast
        {
            get;
            set;
        }

        public Location LocationToWest
        {
            get;
            set;
        }

        public Location(int id, string name, string description)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
        }
    }
}
