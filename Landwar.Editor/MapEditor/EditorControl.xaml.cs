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
using Landwar.Engine.Graphics;

namespace Landwar.Editor.MapEditor
{
    /// <summary>
    /// Interaction logic for EditorControl.xaml
    /// </summary>
    public partial class EditorControl : UserControl
    {
        public Map Map { get; set; }
        public Mapping Mapping { get; set; }
        public MainWindow MainWnd { get; set; }

        private double? sin60 = null;
        private double Sin60
        {
            get
            {
                if (!sin60.HasValue)
                {
                    sin60 = Math.Sin((60 * Math.PI)/180);
                }
                return sin60.Value;
            }
        }

        public EditorControl(Map mapToEdit, MainWindow mainWindow)
        {
            InitializeComponent();
            Map = mapToEdit;
            MainWnd = mainWindow;
            Mapping = new Mapping(50, 42);
            this.DataContext = Map;
            ViewPortData viewPort = new ViewPortData() { CentreX = 0, CentreY = 0, Height = 500, Width = 500, Zoom = 1 };

            //var uriSource = new Uri(@"/WpfApplication1;component/Untitled.png", UriKind.Relative);
            //foo.Source = new BitmapImage(uriSource);
            BitmapImage img = new BitmapImage(new Uri("C:/Development/projects/Landwar/Shared/HexRed.png"));

            /*ImageBrush imgBrush = new ImageBrush(img);
            imgBrush.Viewbox = new Rect(0, 0, 1, 1);
            imgBrush.ViewboxUnits = BrushMappingMode.RelativeToBoundingBox;
            imgBrush.Stretch = Stretch.Uniform;*/

            SolidColorBrush redSolidColorBrush = new SolidColorBrush();
            redSolidColorBrush.Color = Color.FromArgb(255, 255, 0, 0);
            SolidColorBrush grnSolidColorBrush = new SolidColorBrush();
            grnSolidColorBrush.Color = Color.FromArgb(255, 0, 255, 0);

            for (int j = 0; j < mapToEdit.Height; ++j)
            {
                for (int i = 0; i < mapToEdit.Width; ++i)
                {
                    Point hexTopLeft = Mapping.GetHexTopLeftCorner(viewPort, mapToEdit.Hexes[j,i]);

                    Polygon pGon = GenerateHex(hexTopLeft.X, hexTopLeft.Y, Mapping.hexHeight, Mapping.hexWidth);
                    pGon.Stroke = Brushes.Purple;
                    pGon.StrokeThickness = 0;
                    pGon.ClipToBounds = true;
                    //pGon.Fill = imgBrush;
                    
                    if (((double)i) % 2 == 0)
                    {
                        pGon.Fill = redSolidColorBrush;
                    }
                    else
                    {
                        pGon.Fill = grnSolidColorBrush;
                    }

                    pGon.MouseEnter += Polygon_MouseMove;

                    this.cnvMap.Children.Add(pGon);
                }
            }
        }

        private Polygon GenerateHex(double left, double top, int height, int width)
        {
            //http://www.rdwarf.com/lerickson/hex/index.html
            double B = (double)height / 2;
            double C = B / Sin60;
            //double C = Math.Ceiling( B / Sin60 );
            double A = (width - C) / 2;

            //B = Math.Floor(B); A = Math.Floor(A); C = Math.Floor(C); left = Math.Floor(left); top = Math.Floor(top);
            //left = Math.Round(left); top = Math.Round(top);

            Polygon pGon = new Polygon();

            pGon.Points.Add(new Point(left, top + B));
            pGon.Points.Add(new Point(left + A, top));
            pGon.Points.Add(new Point(left + (A + C), top));
            //pGon.Points.Add(new Point(left + (2 * C), top + B));
            pGon.Points.Add(new Point(left + width, top + B));
            pGon.Points.Add(new Point(left + (A + C), top + (2 * B)));
            pGon.Points.Add(new Point(left + A, top + (2 * B)));
            pGon.Points.Add(new Point(left, top + B));

            pGon.Stroke = Brushes.Green;
            pGon.StrokeThickness = 0;
            pGon.ClipToBounds = true;

            return pGon;
        }

        private void Polygon_MouseMove(object sender, MouseEventArgs e)
        {
            Polygon p = (Polygon)sender;
            string fmt = "{0:0.##}";

            StringBuilder strPts = new StringBuilder();
            string prefix = "";
            foreach (Point pt in p.Points)
            { 
                strPts.Append(prefix + String.Format(fmt, pt.X) + "," + String.Format(fmt, pt.Y));
                prefix = " :: ";
            }

            MainWnd.lblGlobalOutput.Content = strPts;
        }
    }
}
