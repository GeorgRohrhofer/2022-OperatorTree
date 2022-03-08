using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorTree
{
    [Serializable]
    public class Operand : Node
    {
        public int Value { set; get; }


        public Operand(int x, int y, int value) : base(x, y)
        {
            Value = value;
        }

        public override void Paint(Graphics g)
        {
            SizeF dim = g.MeasureString(Value + "", f);

            this.SIZE = (int)Math.Round(dim.Width / 2);

            if (SIZE < 15)
                SIZE = 15;

            g.FillEllipse(Brushes.White, this.X - SIZE, this.Y - SIZE, SIZE * 2, SIZE * 2);
            g.DrawEllipse(new Pen(Col, 1), this.X - SIZE, this.Y - SIZE, SIZE * 2, SIZE * 2);

            g.DrawString(Value+"", f, Brushes.Black, X - dim.Width/2, Y - dim.Height/2);
        }

        public override bool InNode(int x, int y)
        {
            return ((int)Math.Sqrt((this.X - x) * (this.X - x) + (this.Y - y) * (this.Y - y))) < SIZE;
        }
    }
}
