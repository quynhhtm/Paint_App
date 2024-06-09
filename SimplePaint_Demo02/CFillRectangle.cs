using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint_Demo02
{
    public class CFillRectangle : CObject
    {
        public override bool CheckPoint(Graphics g, Point p3)
        {
            CRectangle cr = new CRectangle();
            Rectangle r = cr.rRectangle(this.p1, this.p2);
            Rectangle rs = new Rectangle(r.X - 2, r.Y - 2, r.Width + 4, r.Height + 4);
            return rs.Contains(p3) == true ? true : false;
        }

        public override void Draw(Graphics g)
        {
            CRectangle cr = new CRectangle();
            Rectangle r = cr.rRectangle(this.p1, this.p2);
            g.FillRectangle(this.st as SolidBrush, r.X, r.Y, r.Width, r.Height);
        }

        public override void DrawSurround(Graphics g)
        {
            base.DrawSurround(g);
        }
    }
}
