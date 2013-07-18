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
using System.Windows.Shapes;

using RPCharacter.Properties;

namespace RPCharacter
{
    /// <summary>
    /// Interaction logic for CharacterCreation.xaml
    /// </summary>
    public partial class CharacterCreation : Window
    {
        public CharacterCreation()
        {
            InitializeComponent();
			classComboBox.ItemsSource = Enum.GetValues(typeof(Hero.ClassType));
			raceComboBox.ItemsSource = Enum.GetValues(typeof(Hero.RaceType));
        }

        // taken from http://stackoverflow.com/questions/974598/find-all-controls-in-wpf-window-by-type
        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        public void checkAllocatable()
        {
            foreach (UserControl uc in FindVisualChildren<UserControl>(this))
            {
                if (Settings.Default.allocatable >= 10)
                {
                    ((StatsChooser)uc).subtractButton.IsEnabled = false;
                }
                else
                {
                    ((StatsChooser)uc).subtractButton.IsEnabled = true;
                }

                if (Settings.Default.allocatable <= 0)
                {
                    ((StatsChooser)uc).addButton.IsEnabled = false;
                }
                else
                {
                    ((StatsChooser)uc).addButton.IsEnabled = true;
                }

                if (((StatsChooser)uc).statPoints == 18)
                {
                    ((StatsChooser)uc).addButton.IsEnabled = false;
                }
                if (((StatsChooser)uc).statPoints == 3)
                {
                    ((StatsChooser)uc).subtractButton.IsEnabled = false;
                }
            }
        }

		private void statChooser_Loaded(object sender, RoutedEventArgs e)
		{
			checkAllocatable();
		}

		private void createHeroButton_Click(object sender, RoutedEventArgs e)
		{
			if (Settings.Default.allocatable == 0)
			{
				Random rand = new Random();
				HeroBuilder start = new HeroBuilder();
				Hero hero = new Hero();


				start.Create("Hero")
					.As((Hero.ClassType)classComboBox.SelectedValue)
					.From((Hero.RaceType)raceComboBox.SelectedValue)
					.Lvl(1)
					.Str(getLabelAsInt(strengthStat))
					.Con(getLabelAsInt(constStat))
					.Dex(getLabelAsInt(dexStat))
					.Int(getLabelAsInt(intStat))
					.Wis(getLabelAsInt(wisStat))
					.Cha(getLabelAsInt(chaStat))
					.Gold(100)
					.HP(100)
					.MP(100);

				hero = start.Born();

				charInfo.Content = hero.ToString();
			}
			else
			{
				charInfo.Content = "Allocate all available points.";
			}
		}

		private int getLabelAsInt(StatsChooser control)
		{
			int outcome;
			int.TryParse(Convert.ToString(control.statPointsLabel.Content), out outcome);
			return outcome;
		}
    }
}
