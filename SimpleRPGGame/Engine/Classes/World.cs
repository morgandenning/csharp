using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes
{
    public class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        public const int ITEM_ID_RUSTY_SWORD = 0;
        public const int ITEM_ID_RAT_TAIL = 1;
        public const int ITEM_ID_PIECE_OF_FUR = 2;
        public const int ITEM_ID_SNAKE_FANG = 3;
        public const int ITEM_ID_SNAKESKIN = 4;
        public const int ITEM_ID_CLUB = 5;
        public const int ITEM_ID_HEALING_POTION = 6;
        public const int ITEM_ID_SPIDER_FANG = 7;
        public const int ITEM_ID_SPIDER_SILK = 8;

        public const int MONSTER_ID_SKELETON = 0;
        public const int MONSTER_ID_ORC = 1;
        public const int MONSTER_ID_THIEF = 2;
        public const int MONSTER_ID_SPIDER = 3;

        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 0;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 1;

        public const int LOCATION_ID_HOME = 0;
        public const int LOCATION_ID_TOWN_SQUARE = 1;
        public const int LOCATION_ID_GUARD_POST = 2;
        public const int LOCATION_ID_ALCHEMIST_HUT = 3;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 4;
        public const int LOCATION_ID_FARMHOUSE = 5;
        public const int LOCATION_ID_FARM_FIELD = 6;
        public const int LOCATION_ID_BRIDGE = 7;
        public const int LOCATION_ID_SPIDER_FIELD = 8;

        static World()
        {
            PopulateItems();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            //
        }

        private static void PopulateQuests()
        {
            Quest clearAlchemistGarden = new Quest(QUEST_ID_CLEAR_ALCHEMIST_GARDEN, "{ag quest filler}", "{ag quest desc filler}", 20, 10);


            Quests.Add(clearAlchemistGarden);

            //clearAlchemistGarden.QuestCompletionItems.Add(new Quests.QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));
            //clearAlchemistGarden.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);
        }

        private static void PopulateLocations()
        {
            Location home = new Location(LOCATION_ID_HOME, "Home", "{home text filler}");

            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town Square", "{TS text filler}");
            //townSquare.MonsterExistsHere = MonsterByID(MONSTER_ID_ORC);

            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's Hut", "{ah text filler}");
            alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's Garden", "{ag text filler}");
            //alchemistsGarden.MonsterExistsHere = MonsterByID(MONSTER_ID_SKELETON);

            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "{farm text filler}");
            //farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's Field", "{field text filler}");
            //farmersField.MonsterExistsHere = MonsterByID(MONSTER_ID_THIEF);

            Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard Post", "{gp text filler}");

            Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "{bridge text filler}");

            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "{forest text filler}");
            //spiderField.MonsterExistsHere = MonsterByID(MONSTER_ID_SPIDER);

            home.LocationToNorth = townSquare;

            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToSouth = home;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToWest = farmhouse;

            farmhouse.LocationToEast = townSquare;
            farmhouse.LocationToWest = farmersField;

            farmersField.LocationToEast = farmhouse;

            alchemistHut.LocationToSouth = townSquare;
            alchemistHut.LocationToNorth = alchemistsGarden;

            alchemistsGarden.LocationToSouth = alchemistHut;

            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;

            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = spiderField;

            spiderField.LocationToWest = bridge;

            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistsGarden);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(spiderField);
        }

        public static Location LocationByID(int id)
        {
            return Locations[id];
        }

        public static Item ItemByID(int id)
        {
            return Items[id];
        }

        public static Quest QuestByID(int id)
        {
            return Quests[id];
        }

        public static Monster MonsterByID(int id)
        {
            return Monsters[id];
        }
    }
}
