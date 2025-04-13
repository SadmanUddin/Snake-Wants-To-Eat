using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class sadman
    {
        private int x;
        private int y;

        public int X { get { return x; } }
        public int Y { get { return y; } }


        public sadman(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null)||!GetType().Equals(obj.GetType()))
            {
                return false;
            }

            sadman other = (sadman)obj;
            return x == other.x && y== other.y;
        }

        public void Applydir(lessgo BB)
        {
            switch (BB)
            {
                case lessgo.left:
                    x--;
                    break;

                case lessgo.right:
                    x++;
                    break;

                case lessgo.up:
                    y--;
                    break;

                case lessgo.down:
                    y++;
                    break;
            }
        }
    }
}
