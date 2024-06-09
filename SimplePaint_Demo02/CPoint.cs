using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint_Demo02
{
    public class CPoint
    {
        public Point p1;
        public Point p2;
        public Point p3;
        public Point p4;
        public Size s = new Size(10, 10);    

        public CPoint(Point p1, Point p2) 
        {
            this.p1 = new Point(p1.X - 5, p1.Y - 5);
            this.p2 = new Point(p2.X - 5, p2.Y - 5);
            this.p3 = new Point(p1.X - 5, p2.Y - 5);
            this.p4 = new Point(p2.X - 5, p1.Y - 5);
        }

        private void DrawPoint(Graphics g, Point p)
        {
            g.FillEllipse(new SolidBrush(Color.Yellow), p.X, p.Y, s.Width, s.Height);
            g.DrawEllipse(new Pen(Color.Black), p.X, p.Y, s.Width, s.Height);
        }
       
        public void DrawTwoPoint(Graphics g)
        {
            DrawPoint(g, p1);
            DrawPoint(g, p2);
        }
        public void DrawFourPoint(Graphics g)
        {
            DrawTwoPoint(g);
            DrawPoint(g, p3);
            DrawPoint(g, p4);
        }   
    }
}
