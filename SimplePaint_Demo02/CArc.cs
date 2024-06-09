using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint_Demo02
{
    public class CArc : CObject
    {
        public override void Draw(Graphics g)
        {
            CRectangle cr = new CRectangle();
            Rectangle r = cr.rRectangle(this.p1, this.p2);
            g.DrawArc(this.st as Pen, r.X, r.Y, r.Width, r.Height, 220, 180);
        }

        public override bool CheckPoint(Graphics g, Point p3)
        {
            CRectangle cr = new CRectangle();
            Rectangle r = cr.rRectangle(this.p1, this.p2);
            Rectangle rs = new Rectangle(r.X - 2, r.Y - 2, r.Width + 4, r.Height + 4);
            return rs.Contains(p3) == true ? true : false;
        }
        public override void DrawSurround(Graphics g)
        {
            // Ve duong vien
            CRectangle cr = new CRectangle();
            Rectangle r = cr.rRectangle(this.p1, this.p2);
            Pen p = new Pen(Color.Black, 1);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawRectangle(p, r.X - 2, r.Y - 2, r.Width + 4, r.Height + 4);

            // Ve 4 dinh
            CPoint cp = new CPoint(this.p1, this.p2);
            cp.DrawFourPoint(g);
        }
    }
}
