using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Landwar.Engine
{
    public class Map
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }
        
        public Hex[,] Hexes { get; set; }

    }
}
