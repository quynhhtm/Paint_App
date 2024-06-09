using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint_Demo02
{
    public class CFillPolygon: CObject
    {
        public override void Draw(Graphics g)
        {
            Point[] points = this.GetPentagonPoints();

            // Vẽ đa giác Pentagon
            g.FillPolygon(this.st as Brush, points);
        }

        public override bool CheckPoint(Graphics g, Point p3)
        {
            Point[] points = this.GetPentagonPoints();

            Point v1 = new Point();
            Point v2 = new Point();
            double sum = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                v1 = setVector(points[i], p3);
                v2 = setVector(points[i + 1], p3);
                sum = sum + calculateAngle(v1, v2);
            }
            v1 = setVector(points[points.Length - 1], p3);
            v2 = setVector(points[0], p3);
            sum = sum + calculateAngle(v1, v2);
            if (Math.Abs(sum - 2 * Math.PI) <= 0.01)
                return true;
            return false;
        }
        public Point setVector(Point a, Point b)
        {
            Point c = new Point();
            c.X = b.X - a.X;
            c.Y = b.Y - a.Y;
            return c;
        }
        public double calculateAngle(Point v1, Point v2)
        {
            double t = (v1.X * v2.X + v1.Y * v2.Y);
            double m = Math.Sqrt(Math.Pow(v1.X, 2) + Math.Pow(v1.Y, 2)) * Math.Sqrt(Math.Pow(v2.X, 2) + Math.Pow(v2.Y, 2));
            return Math.Acos(t / m);
        }

        public override void DrawSurround(Graphics g)
        {
            base.DrawSurround(g);
        }
        public Point[] GetPentagonPoints()
        {
            // Tạo hình chữ nhật từ hai điểm đã cho
            CRectangle cr = new CRectangle();
            Rectangle r = cr.rRectangle(this.p1, this.p2);

            // Tính toán 5 điểm nằm trên các cạnh của hình chữ nhật
            Point[] points = new Point[5];
            points[0] = new Point(r.X + r.Width / 2, r.Y);
            points[1] = new Point(r.X, r.Y + r.Height / 3);
            points[2] = new Point(r.X + r.Width / 5, r.Y + r.Height);
            points[3] = new Point(r.X + r.Width - r.Width / 5, r.Y + r.Height);
            points[4] = new Point(r.X + r.Width, r.Y + r.Height / 3);

            return points;
        }
    }
}
