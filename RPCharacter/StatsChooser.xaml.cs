﻿using System;
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
    /// Interaction logic for StatsChooser.xaml
    /// </summary>
    public partial class StatsChooser : UserControl
    {
        public int statPoints = 10;

        public StatsChooser()
        {
            InitializeComponent();
            checkAllocatable();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            statPoints += 1;
            Settings.Default.allocatable -= 1;
            
            update();
        }

        private void subtractButton_Click(object sender, RoutedEventArgs e)
        {
            statPoints -= 1;
            Settings.Default.allocatable += 1;
            
            update();
        }

        private void update()
        {
            var parent = Window.GetWindow(this) as CharacterCreation;
            statPointsLabel.Content = Convert.ToString(statPoints);
            parent.allocatableLabel.Content = Convert.ToString(Settings.Default.allocatable);
            parent.checkAllocatable();
        }

        private bool checkAllocatable()
        {
            bool isAllocatable;
            if (Settings.Default.allocatable > 10)
            {
                subtractButton.IsEnabled = false;
                isAllocatable = false;
            }
            else
            {
                subtractButton.IsEnabled = true;
                isAllocatable = true;
            }

            if (Settings.Default.allocatable < 0)
            {
                addButton.IsEnabled = false;
                return false;
            }
            else
            {
                addButton.IsEnabled = true;
                isAllocatable = true;
            }

            return isAllocatable;
        }
    }
}