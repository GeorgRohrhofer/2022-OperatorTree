using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorTree
{
    [Serializable]
    public abstract class Node
    {

        public int X { set; get; }
        public int Y { set; get; }
        public Color Col { get; set; }

        public const int SIZE = 10;
        public Node Parent { get; set; }

        public static readonly Font f = new Font("Arial", 12);

        public Node (int x, int y)
        {
            this.X = x;
            this.Y = y;
            Col = Color.Black;
        }

        public virtual void move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public abstract void Paint(Graphics g);
        public abstract bool InNode(int x, int y);
    }
}
