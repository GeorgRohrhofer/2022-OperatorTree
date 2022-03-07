using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorTree
{
    [Serializable]
    public class Operator : Node
    {
        public string OP { get; set; }
        public Node Left { set; get; }
        public Node Right { set; get; }

        public Operator(int x, int y, string op) : base(x, y)
        {
            OP = op;
        }

        public override void Paint(Graphics g)
        {
            g.FillRectangle(Brushes.White, this.X - SIZE, this.Y - SIZE, SIZE * 2, SIZE * 2);
            g.DrawRectangle(new Pen(Col, 1), this.X - SIZE, this.Y - SIZE, SIZE * 2, SIZE * 2);

            SizeF dim = g.MeasureString(OP, f);

            g.DrawString(OP, f, Brushes.Black, X - dim.Width/2, Y - dim.Height/2);
        }

        public override bool InNode(int x, int y)
        {
            if(x < X+SIZE && x > X-SIZE && y < Y+SIZE && y > Y - SIZE)
            {
                return true;
            }

            return false;
        }

        public override void move(int dx, int dy)
        {
            base.move(dx, dy);

            if(Left != null)
                this.Left.move(dx, dy);
            if(Right != null)
                this.Right.move(dx, dy);
        }
    }
}
