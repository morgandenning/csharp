using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel;
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

namespace SimpleRPGGame
{
    /// <summary>
    /// Interaction logic for NewGame.xaml
    /// </summary>
    public partial class NewGameWindow : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        private string _newGameRace;
        public string NewGameRace
        {
            get {
                return _newGameRace;
            }
            set
            {
                _newGameRace = value;
                RaisePropertyChanged();
            }
        }

        private string _newGameClass;
        public string NewGameClass
        {
            get {
                return _newGameClass;
            }
            set
            {
                _newGameClass = value;
                RaisePropertyChanged();
            }
        }

        public MainWindow MainWindow;

        public NewGameWindow(MainWindow mainWindow)
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("NEWGAMEWINDOWDIAG");
                System.Diagnostics.Debug.WriteLine(e);
            }
            this.MainWindow = mainWindow;
            this.DataContext = this;
        }

        private BitmapImage GetPortraitImage(string sImageName)
        {
            var humanPortraitBitmap = new BitmapImage();
            humanPortraitBitmap.BeginInit();
            humanPortraitBitmap.CacheOption = BitmapCacheOption.OnLoad;
            humanPortraitBitmap.UriSource = new Uri(sImageName, UriKind.RelativeOrAbsolute);
            humanPortraitBitmap.EndInit();

            return humanPortraitBitmap;
        }

        private void Click_RaceSelect(object sender, MouseButtonEventArgs e)
        {
            this.NewGameRace = (((Image)sender).Tag).ToString();
        }

        private void Click_ClassSelect(object sender, MouseButtonEventArgs e)
        {
            this.NewGameClass = (((Image)sender).Tag).ToString();
        }

        private void NewGame_StartNewGame(object sender, RoutedEventArgs e)
        {
            var gameWindow = new GameWindow();
            gameWindow.heroObject = new Engine.Classes.Hero.Hero(NewGameHeroName.Text, this.NewGameRace, this.NewGameClass);

            this.MainWindow.ucGameWindow = gameWindow;
            this.MainWindow.SetPage(this.MainWindow.ucGameWindow);

        }

    }
}
