using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint_Demo02
{
    public class CLine : CObject
    {
        public override void Draw(Graphics g)
        {
            g.DrawLine(this.st as Pen, this.p1, this.p2);
        }
        public override bool CheckPoint(Graphics g, Point p3)
        {
            double b = (double)(p2.Y * p1.X - p2.X * p1.Y) / (p1.X - p2.X);
            double a = (double)(p1.Y - b) / p1.X;
            double y = a * p3.X + b;
            double d = Math.Abs(y - p3.Y);

            return d >= 0 && d < 2? true : false;
        }
        public override void DrawSurround(Graphics g)
        {
            CPoint cp = new CPoint(p1, p2);
            cp.DrawTwoPoint(g);
        }
    }
}
