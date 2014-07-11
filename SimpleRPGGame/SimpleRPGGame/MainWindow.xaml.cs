using System;
using System.Collections.Generic;
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

namespace SimpleRPGGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ConfigParser Config;

        public UserControl ucNewGameWindow
        {
            get;
            set;
        }
        public UserControl ucGameWindow
        {
            get;
            set;
        }

        private string _DocFolder
        {
            get { return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SimpleRPG"); }
        }
        private string _SavesFolder
        {
            get { return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SimpleRPG", "Saves");  }
        }

        public MainWindow()
        {
            try
            {
                InitializeComponent();
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("MAINWINDOWDIAG");
                System.Diagnostics.Debug.WriteLine(e);
            }

            // Setup App Directories
            Console.WriteLine(System.IO.Path.Combine(_DocFolder, "settings.ini"));

            if (!System.IO.Directory.Exists(_DocFolder))
            {
                try
                {
                    System.IO.Directory.CreateDirectory(_DocFolder);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            if (System.IO.Directory.Exists(_DocFolder) && !System.IO.Directory.Exists(_SavesFolder))
            {
                try
                {
                    System.IO.Directory.CreateDirectory(_SavesFolder);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }


            // Start Main Theme Music
            Engine.Classes.Sound.Music.InitMainTheme();

            // Load Config Files
            Config = new ConfigParser(System.IO.Path.Combine(_DocFolder, "settings.ini"), "Settings");

            if (Config.Read("SoundEnabled") == "True" || Config.Read("SoundEnabled").Length == 0)
            {
                Engine.Classes.Sound.Music.StartMainTheme();
                MenuItem_PlaySound.IsChecked = true;
            }

            this.ucNewGameWindow = new NewGameWindow(this);

            //Mapper.GenerateMap();

            //System.Windows.Shapes.Rectangle myBtn = new System.Windows.Shapes.Rectangle();
            //myBtn.Height = 16;
            //myBtn.Width = 16;
            //myBtn.Fill = System.Windows.Media.Brushes.Gray;

            //Canvas.SetLeft(myBtn, 0);
            //Canvas.SetTop(myBtn, 0);

            //CanvasMap.Children.Add(myBtn);

            //System.Windows.Shapes.Rectangle otherBtn = new System.Windows.Shapes.Rectangle();
            //otherBtn.Height = 16;
            //otherBtn.Width = 16;
            //otherBtn.Fill = System.Windows.Media.Brushes.Gold;

            //Canvas.SetLeft(otherBtn, 16);
            //Canvas.SetTop(otherBtn, 0);

            //CanvasMap.Children.Add(otherBtn);

            SetPage(this.ucNewGameWindow);
        }

        public void SetPage(UserControl ucPage)
        {
            ReplaceableWindow.Content = ucPage;
        }

        private void MenuItemClick_New(object sender, RoutedEventArgs e)
        {
            //
        }
        private void MenuItemClick_Save(object sender, RoutedEventArgs e)
        {

            //

            //Microsoft.Win32.SaveFileDialog saveFile = new Microsoft.Win32.SaveFileDialog();
            //saveFile.FileName = "Hero";
            //saveFile.DefaultExt = ".save";
            //saveFile.Filter = "Save Files (*.save)|*.save";
            //saveFile.InitialDirectory = _SavesFolder;

            //Nullable<bool> saveFileResult = saveFile.ShowDialog();

            //if (saveFile.FileName != "")
            //{
            //    try
            //    {
            //        System.IO.FileStream saveStream = (System.IO.FileStream)saveFile.OpenFile();

            //        byte[] byteData = Encoding.ASCII.GetBytes("SaveGame Test");
            //        saveStream.Write(byteData, 0, byteData.Length);
            //        saveStream.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}
        }
        private void MenuItemClick_Load(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog loadFile = new Microsoft.Win32.OpenFileDialog();
            loadFile.DefaultExt = ".save";
            loadFile.Filter = "Save Files (*.save)|*.save";
            loadFile.InitialDirectory = _SavesFolder;

            Nullable<bool> loadFileResult = loadFile.ShowDialog();

            if (loadFileResult == true)
            {
                (this.ucGameWindow as GameWindow).InitializeHero(loadFile.FileName);
            }

        }

        private void MenuItemClick_ExitGame(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItemClick_PlaySound(object sender, RoutedEventArgs e)
        {
            var menuItem = e.OriginalSource as MenuItem;
            if (menuItem.IsChecked)
            {
                Engine.Classes.Sound.Music.StartMainTheme();
                Config.Write("SoundEnabled", "True");
            }
            else
            {
                Engine.Classes.Sound.Music.StopMainTheme();
                Config.Write("SoundEnabled", "False");
            }
        }

        private void MenuItemClick_CheckForUpdates(object sender, RoutedEventArgs e)
        {
            System.Deployment.Application.UpdateCheckInfo updateInfo = null;

            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                System.Deployment.Application.ApplicationDeployment appDeployment = System.Deployment.Application.ApplicationDeployment.CurrentDeployment;

                try
                {
                    updateInfo = appDeployment.CheckForDetailedUpdate();
                }
                catch (System.Deployment.Application.DeploymentDownloadException dde)
                {
                    MessageBox.Show("The New Version Cannot be Downloaded");
                    return;
                }
                catch (System.Deployment.Application.InvalidDeploymentException ide)
                {
                    MessageBox.Show("Cannot Check for a New Version");
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("This Application Cannot be Updaetd");
                    return;
                }

                if (updateInfo.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (doUpdate)
                    {
                        try
                        {
                            MessageBox.Show("Updating App");
                            appDeployment.Update();
                        }
                        catch (System.Deployment.Application.DeploymentDownloadException dde)
                        {
                            MessageBox.Show("Cannot Install Update");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("DoUpdate False");
                    }
                }
                else
                {
                    MessageBox.Show("No Update Available");
                }
            }
            else
            {
                MessageBox.Show("Not Network Enabled");
            }
        }
    }
}
