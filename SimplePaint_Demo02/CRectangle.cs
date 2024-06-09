using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint_Demo02
{
    public class CRectangle : CObject
    {
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(this.st as Pen, rRectangle(this.p1, this.p2));
        }

        public override bool CheckPoint(Graphics g, Point p3)
        {
            Rectangle r = rRectangle(this.p1, this.p2);
            Rectangle rs = new Rectangle(r.X - 2, r.Y - 2, r.Width + 4, r.Height + 4);
            return rs.Contains(p3) == true? true: false;
        }

        public Rectangle rRectangle(Point rp1, Point rp2)
        {
            int x = Math.Min(rp1.X, rp2.X);
            int y = Math.Min(rp1.Y, rp2.Y);
            int width = Math.Abs(rp2.X - rp1.X);
            int height = Math.Abs(rp2.Y - rp1.Y);
            return new Rectangle(x, y, width, height);
        }

        public override void DrawSurround(Graphics g)
        {
            base.DrawSurround(g);
        }
    }
}
