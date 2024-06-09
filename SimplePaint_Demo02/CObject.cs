using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint_Demo02
{
    public abstract class CObject
    {
        public Point p1;
        public Point p2;
        public System.Object st;
        
        public abstract void Draw(Graphics g);
        public abstract bool CheckPoint(Graphics g, Point p3);
        public virtual void DrawSurround(Graphics g)
        {
            // Ve duong vien
            CRectangle cr = new CRectangle();
            Rectangle r = cr.rRectangle(this.p1, this.p2);
            Pen p = new Pen(Color.Black, 1);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawRectangle(p, r.X - 2, r.Y - 2, r.Width +  4, r.Height + 4);

            // Ve 4 dinh
            CPoint cp = new CPoint(this.p1, this.p2);
            cp.DrawFourPoint(g); 
        }
    }
}
