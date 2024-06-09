using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint_Demo02
{
    public class CFillEllipse : CObject
    {
        public override bool CheckPoint(Graphics g, Point p3)
        {
            CRectangle cr = new CRectangle();
            Rectangle rs = cr.rRectangle(this.p1, this.p2);
            double a = Math.Max((double)rs.Width / 2, (double)rs.Height / 2);
            double b = Math.Min((double)rs.Width / 2, (double)rs.Height / 2);
            double x0 = rs.X + (double)rs.Width / 2;
            double y0 = rs.Y + (double)rs.Height / 2;
            double d = Math.Sqrt(Math.Pow(p3.X - x0, 2) + Math.Pow(p3.Y - y0, 2));

            return d < a ? true : false;
        }

        public override void Draw(Graphics g)
        {
            g.FillEllipse(this.st as SolidBrush, this.p1.X, this.p1.Y, this.p2.X - this.p1.X, this.p2.Y - this.p1.Y);
        }
        public override void DrawSurround(Graphics g)
        {
            base.DrawSurround(g);
        }
    }
}
