using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Landwar.Engine.Graphics
{
    public struct ViewPortData
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int CentreX { get; set; }
        public int CentreY { get; set; }

        public double Zoom { get; set; }
    }

    /*public struct Point
    {
        public int X;
        public int Y;
    }*/
}
