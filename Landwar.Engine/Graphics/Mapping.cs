using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

using Landwar.Engine;

namespace Landwar.Engine.Graphics
{
    public class Mapping
    {
        public int hexHeight = 42;
        public int hexWidth = 50;
        private double s; // for rendering

        public Mapping(int pixHexWidth, int pixHexHeight)
        {
            this.hexWidth = pixHexWidth;
            this.hexHeight = pixHexHeight;

            s = (hexHeight / Math.Cos(30 * Math.PI / 180)) / 2;
        }

        public Hex SelectHex(ViewPortData view, Map map, int pixX, int pixY)
        {
            pixX = pixX - (view.Width / 2) + view.CentreX;
            pixY = pixY - (view.Height / 2) + view.CentreY;

            int sx = (int)(pixX / s / 1.5);
            int sy = (int)(pixY - ((sx % 2) * hexHeight) / 2) / hexHeight;

            return map.Hexes[sy, sx];
        }

        public Point GetHexTopLeftCorner(ViewPortData view, Hex hex)
        {
            double x = hex.X * s * 1.5;
            double y = hex.Y * hexHeight + (hex.X % 2) * hexHeight / 2;

            x = x + (view.Width / 2) - view.CentreX;
            y = y + (view.Height / 2) - view.CentreY;

            return new Point(x, y);
        }
    }
}
