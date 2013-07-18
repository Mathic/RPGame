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

using RPCharacter.Properties;

namespace RPCharacter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		CharacterCreation characterCreation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
			characterCreation = new CharacterCreation();
            characterCreation.ShowDialog();
			Settings.Default.allocatable = 10;
			if (characterCreation.hero != null)
			{
				charInfo.Text = characterCreation.hero.ToString();
			}
        }
    }
}
