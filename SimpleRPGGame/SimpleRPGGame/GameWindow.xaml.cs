using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Engine;
using Engine.Classes;
using Engine.Classes.Sound;
using Engine.Classes.Hero;

namespace SimpleRPGGame
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class GameWindow : UserControl
    {
        private ConfigParser Autosave;

        public Hero heroObject
        {
            get;
            set;
        }

        public GameWindow()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("GAMEWINDOWDIAG");
                System.Diagnostics.Debug.WriteLine(e);
            }

            this.DataContext = this;

            this.heroObject = new Hero();

            try
            {
                Autosave = new ConfigParser("autosave.save", "Hero", true);
                //InitializeHero(Autosave);
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }

            try
            {
                new Engine.Classes.World();
                this.RedrawDirectionals();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void RedrawDirectionals()
        {
            MoveNorth.Visibility = (this.heroObject.CurrentLocation.LocationToNorth != null ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden);
            MoveSouth.Visibility = (this.heroObject.CurrentLocation.LocationToSouth != null ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden);
            MoveEast.Visibility = (this.heroObject.CurrentLocation.LocationToEast != null ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden);
            MoveWest.Visibility = (this.heroObject.CurrentLocation.LocationToWest != null ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden);
        }

        public void Click_HeroGoNorth(object sender, RoutedEventArgs e)
        {
            this.heroObject.MoveHero(this.heroObject.CurrentLocation.LocationToNorth);
            this.RedrawDirectionals();
        }
        public void Click_HeroGoSouth(object sender, RoutedEventArgs e)
        {
            this.heroObject.MoveHero(this.heroObject.CurrentLocation.LocationToSouth);
            this.RedrawDirectionals();
        }
        public void Click_HeroGoEast(object sender, RoutedEventArgs e)
        {
            this.heroObject.MoveHero(this.heroObject.CurrentLocation.LocationToEast);
            this.RedrawDirectionals();
        }
        public void Click_HeroGoWest(object sender, RoutedEventArgs e)
        {
            this.heroObject.MoveHero(this.heroObject.CurrentLocation.LocationToWest);
            this.RedrawDirectionals();
        }

        public void InitializeHero(Hero heroObject)
        {
            this.heroObject = heroObject;
        }

        public void InitializeHero(ConfigParser saveObject)
        {
            if (this.heroObject != null)
            {
                this.heroObject.sName = saveObject.Read("Name") ?? "Saved Hero";
                this.heroObject.iLevel = Convert.ToInt32(saveObject.Read("Level") ?? "1");
                this.heroObject.iGold = Convert.ToInt32(saveObject.Read("Gold") ?? "0");
                this.heroObject.iExp = Convert.ToInt32(saveObject.Read("XP") ?? "0");

                this.heroObject.SetRace(saveObject.Read("Race") ?? "Human");
                this.heroObject.SetClass(saveObject.Read("Class") ?? "Warrior");
            }
        }
        public void InitializeHero(string savePath)
        {
            var saveObject = new ConfigParser(savePath, "Hero", true);
            InitializeHero(saveObject);
        }

        public void LoadSave(string sFilePath)
        {
            var heroSave = new ConfigParser(sFilePath, "Hero");
            InitializeHero(heroSave);
        }
    }
}
