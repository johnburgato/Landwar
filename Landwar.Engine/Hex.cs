using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Landwar.Engine
{
    public class Hex
    {
        public enum Facing
        {
            N, NE, SE, S, SW, NW
        }

        public int X { get; set; }
        public int Y { get; set; }

        public Terrain Terrain { get; set; }

        public Hex(int x, int y)
        {
            X = x;
            Y = y;
        }

        public List<Hex> GetSurrounding()
        {
            List<Hex> rtnList = new List<Hex>();
            int x = this.X; int y = this.Y;

            int col = x % 2;
            int col1 = (x + 1) % 2;

            //down
            int dx = x;
            int dy = y + 1;
            rtnList.Add(new Hex(dx, dy));
            //up
            int ux = x;
            int uy = y - 1;
            rtnList.Add(new Hex(ux, uy));
            //up-left
            int ulx = x - 1;
            int uly = y - col1;
            rtnList.Add(new Hex(ulx, uly));
            //down left
            int dlx = x - 1;
            int dly = y + col;
            rtnList.Add(new Hex(dlx, dly));
            //up-rigth
            int urx = x + 1;
            int ury = y - col1;
            rtnList.Add(new Hex(urx, ury));
            //down-right
            int drx = x + 1;
            int dry = y + col;
            rtnList.Add(new Hex(drx, dry));

            return rtnList;
        }
    }
}
