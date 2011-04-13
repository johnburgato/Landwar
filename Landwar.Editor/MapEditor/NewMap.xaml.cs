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

using Landwar.Engine;

namespace Landwar.Editor.MapEditor
{
    /// <summary>
    /// Interaction logic for NewMap.xaml
    /// </summary>
    public partial class NewMap : Page
    {
        private MainWindow ParentWindow { get; set; }
        private Map newMap;

        public NewMap(MainWindow parentWindow)
        {
            InitializeComponent();

            this.newMap = new Map();
            this.DataContext = newMap;
            this.ParentWindow = parentWindow;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Name: " + this.newMap.Name + ", Desc: " + this.newMap.Description + ", H/W: " + this.newMap.Height + "," + this.newMap.Width);

            newMap.Hexes = new Hex[newMap.Height, newMap.Width];

            for (int y = 0; y < newMap.Height; ++y)
            {
                for (int x = 0; x < newMap.Width; ++x)
                {
                    Hex h = new Hex(x, y);
                    newMap.Hexes[y, x] = h;
                }   
            }


            ParentWindow.Frame1.Navigate(new EditorControl(newMap, ParentWindow));
        }
    }
}
