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
    }
}
