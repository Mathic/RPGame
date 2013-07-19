using System;
using System.Collections.Generic;
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

using RPCharacter.View;
using RPCharacter.Properties;

namespace RPCharacter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		public Hero hero;

        public MainWindow()
        {
            InitializeComponent();
            CenterWindowOnScreen();
            CheckHeroExists();
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
			CharacterCreation characterCreation = new CharacterCreation();
            characterCreation.ShowDialog();
			Settings.Default.allocatable = 10;
			hero = characterCreation.hero;
			if (hero != null)
			{
				charInfo.Text = hero.ToString();
			}
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private bool CheckHeroExists()
        {
            bool isExists = false;

            if (charInfo.Text == "Create a character to show information here and enable the options.")
            {
                inventoryButton.IsEnabled = false;
                shopButton.IsEnabled = false;
                mapButton.IsEnabled = false;
                fightButton.IsEnabled = false;
            }
            else
            {
                inventoryButton.IsEnabled = true;
                shopButton.IsEnabled = true;
                mapButton.IsEnabled = true;
                fightButton.IsEnabled = true;
            }

            return isExists;
        }

        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }
    }
}
