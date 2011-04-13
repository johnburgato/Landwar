using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Landwar.Editor.MapEditor;

namespace Landwar.Editor
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        private MainWindow ParentWindow { get; set; }

        public MainMenu(MainWindow parentWindow)
        {
            InitializeComponent();
            ParentWindow = parentWindow;
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            ParentWindow.Close();
        }

        private void btnNewMap_Click(object sender, RoutedEventArgs e)
        {
            ParentWindow.Frame1.Navigate(new NewMap(this.ParentWindow));
        }

        private void btnEditUnits_Click(object sender, RoutedEventArgs e)
        {
            ParentWindow.Frame1.Navigate(new Page1());
        }
    }
}
