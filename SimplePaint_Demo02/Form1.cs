using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint_Demo02
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Color color;

        private int ClickNum = 1;
        private int DrawIndex = -1;
        private bool active_drawing = false;
        private Point startPoint;
        private Point secondPoint;
        private int index = -1;
        List<CObject> lstDrawObject = new List<CObject>();
        bool isResize = false;
        bool isCircle = false;
        bool isArc = false;

        List<int> lstGroup = new List<int>();
        bool isGroup = false;
        bool moveGroup = false;

        ColorDialog colorDialog;

        public Form1()
        {
            InitializeComponent();
        }

        private void pnMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClickNum++;
                if (active_drawing)
                {
                    lstGroup.Clear();
                    startPoint = e.Location;
                    switch (DrawIndex)
                    {
                        case 0:
                            CObject line = new CLine();
                            line.p1 = startPoint;
                            line.p2 = startPoint;
                            line.st = new Pen(color, widthLine());
                            lstDrawObject.Add(line);
                            break;
                        case 1:
                            CObject rectangle = new CRectangle();
                            rectangle.p1 = startPoint;
                            rectangle.p2 = startPoint;
                            rectangle.st = new Pen(color, widthLine());
                            lstDrawObject.Add(rectangle);
                            break;
                        case 2:
                            CObject ellipse = new CEllipse();
                            ellipse.p1 = startPoint;
                            ellipse.p2 = startPoint;
                            ellipse.st = new Pen(color, widthLine());
                            lstDrawObject.Add(ellipse);
                            break;
                        case 3:
                            CObject fr = new CFillRectangle();
                            fr.p1 = startPoint;
                            fr.p2 = startPoint;
                            fr.st = new SolidBrush(color);
                            lstDrawObject.Add(fr);
                            break;
                        case 4:
                            CObject fe = new CFillEllipse();
                            fe.p1 = startPoint;
                            fe.p2 = startPoint;
                            fe.st = new SolidBrush(color);
                            lstDrawObject.Add(fe);
                            break;
                        case 5:
                            CObject sg = new CRectangle();
                            sg.p1 = startPoint;
                            sg.p2 = startPoint;
                            Pen p = new Pen(Color.Black, 1);
                            p.DashStyle = DashStyle.Dash;
                            sg.st = p;
                            lstDrawObject.Add(sg);
                            break;
                        case 6:
                            CObject circle = new CCircle();
                            circle.p1 = startPoint;
                            circle.p2 = startPoint;
                            circle.st = new Pen(color, widthLine());
                            lstDrawObject.Add(circle);
                            break;
                        case 7:
                            CObject fc = new CFillCircle();
                            fc.p1 = startPoint;
                            fc.p2 = startPoint;
                            fc.st = new SolidBrush(color);
                            lstDrawObject.Add(fc);
                            break;
                        case 8:
                            CObject arc = new CArc();
                            arc.p1 = startPoint;
                            arc.p2 = new Point(startPoint.X + 10, startPoint.Y + 10);
                            arc.st = new Pen(color, widthLine());
                            lstDrawObject.Add(arc);
                            break;
                        case 9:
                            CObject polygon = new CPolygon();
                            polygon.p1 = startPoint;
                            polygon.p2 = startPoint;
                            polygon.st = new Pen(color, widthLine());
                            lstDrawObject.Add(polygon);
                            break;
                        case 10:
                            CObject fp = new CFillPolygon();
                            fp.p1 = startPoint;
                            fp.p2 = startPoint;
                            fp.st = new SolidBrush(color);
                            lstDrawObject.Add(fp);
                            break;
                    }
                    pnMain.Refresh();
                }
                else
                {
                    startPoint = e.Location;
                    index = -1;
                    isCircle = false;
                    if(!moveGroup) this.lstGroup.Clear();
                    for (int i = 0; i < lstDrawObject.Count; i++)
                    {
                        if (lstDrawObject[i].CheckPoint(g, e.Location))
                        {
                            index = i;
                        }

                        CPoint cp = new CPoint(lstDrawObject[i].p1, lstDrawObject[i].p2);
                        List<Point> points = new List<Point>() { cp.p1, cp.p2, cp.p3, cp.p4 };
                        Dictionary<Point, Point> d = new Dictionary<Point, Point>() { 
                            { cp.p1, cp.p2 }, 
                            { cp.p2, cp.p1 }, 
                            { cp.p3, cp.p4 }, 
                            { cp.p4, cp.p3 } 
                        };

                        for (int k = 0; k < points.Count; k++)
                        {
                            if ((this.lstDrawObject[i] is CCircle || this.lstDrawObject[i] is CFillCircle) && k > 1)
                            {
                                break;
                            }

                            CObject ell = new CEllipse();
                            ell.p1 = points[k];
                            ell.p2 = new Point(points[k].X + cp.s.Width, points[k].Y + cp.s.Height);

                            if (ell.CheckPoint(g, e.Location))
                            {
                                isResize = true;
                                active_drawing = true;

                                if (this.lstDrawObject[i] is CCircle)
                                {
                                    DrawIndex = 6;
                                }
                                else if (this.lstDrawObject[i] is CFillCircle)
                                {
                                    DrawIndex = 7;
                                }
                                else if (this.lstDrawObject[i] is CArc)
                                {
                                    DrawIndex = 8;
                                }

                                startPoint = d[points[k]];
                                lstDrawObject[i].p1 = startPoint;
                                lstDrawObject[i].p2 = e.Location;

                                lstDrawObject.Add(lstDrawObject[i]);
                                lstDrawObject.RemoveAt(i);
                            }
                        }
                    }
                }
            }
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {
            foreach (CObject dObj in this.lstDrawObject)
            {
                dObj.Draw(g);
            }
            
            if (this.isGroup)
            {
                foreach (int i in this.lstGroup)
                {
                    this.lstDrawObject[i].DrawSurround(g);
                }
            }
            else
            {
                if (this.active_drawing && this.lstDrawObject.Count > 0)
                {
                    this.lstDrawObject[lstDrawObject.Count - 1].DrawSurround(g);
                }
                else
                {
                    if (this.index != -1 && this.index < this.lstDrawObject.Count)
                    {
                        this.lstDrawObject[index].DrawSurround(g);
                    }
                }
            }
        }

        private void pnMain_MouseMove(object sender, MouseEventArgs e)
        {
            // ClickNum == 1

            this.secondPoint = e.Location;

            if(active_drawing || isResize)
            {
                if (DrawIndex == 6 || DrawIndex == 7)
                {
                    int d = Math.Min(e.X - startPoint.X, e.Y - startPoint.Y);
                    secondPoint = new Point(startPoint.X + d, startPoint.Y + d);
                }
                if (DrawIndex == 8)
                {
                    int d = Math.Min(Math.Abs(e.X - startPoint.X), Math.Abs(e.Y - startPoint.Y));
                    this.secondPoint = d > 0 ? e.Location : new Point(startPoint.X + 10, startPoint.Y + 10);
                }
            }

            // ClickNum == 2
            if (this.ClickNum == 2)
            {
                if (this.active_drawing)
                {
                    this.lstDrawObject[lstDrawObject.Count - 1].p2 = this.secondPoint;
                }
                else
                {
                    if (!this.isResize)
                    {
                        int dX = this.secondPoint.X - this.startPoint.X;
                        int dY = this.secondPoint.Y - this.startPoint.Y;
                        if (this.isGroup && this.moveGroup)
                        {
                            foreach (int i in lstGroup)
                            {
                                this.lstDrawObject[i].p1.X += dX;
                                this.lstDrawObject[i].p1.Y += dY;
                                this.lstDrawObject[i].p2.X += dX;
                                this.lstDrawObject[i].p2.Y += dY;
                            }
                        }
                        else if(!this.isGroup && this.index != -1)
                        {
                            this.lstDrawObject[index].p1.X += dX;
                            this.lstDrawObject[index].p1.Y += dY;
                            this.lstDrawObject[index].p2.X += dX;
                            this.lstDrawObject[index].p2.Y += dY;
                        }
                        this.startPoint = e.Location;
                    }

                }
            }
            label1.Text = string.Format("( {0}, {1} )", e.Location.X, e.Location.Y);
            pnMain.Refresh();
        }

        private void pnMain_MouseUp(object sender, MouseEventArgs e)
        {
            this.ClickNum = 1;
            if (this.isResize)
            {
                this.active_drawing = false;
                this.isResize = false;
            }
            if (this.isGroup && this.active_drawing && this.lstDrawObject[lstDrawObject.Count - 1] is CRectangle)
            {
                this.lstGroup.Clear();
                CObject r = (CRectangle)this.lstDrawObject[lstDrawObject.Count - 1];
                for (int i = 0; i < this.lstDrawObject.Count - 1; i++)
                {
                    CPoint cp = new CPoint(this.lstDrawObject[i].p1, this.lstDrawObject[i].p2);
                    if (r.CheckPoint(g, cp.p1) && r.CheckPoint(g, cp.p2))
                    { 
                        if (this.lstDrawObject[i] is CLine)
                        {
                            this.lstGroup.Add(i);
                        }
                        else if (r.CheckPoint(g, cp.p3) && r.CheckPoint(g, cp.p4))
                        {
                            this.lstGroup.Add(i);
                        }
                    }
                }
                this.lstDrawObject.RemoveAt(this.lstDrawObject.Count - 1);
                if(this.lstGroup.Count > 0)
                {
                    this.active_drawing = false;
                    this.pnMain.Cursor = Cursors.Default;
                }
            }
           
        }
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            this.DrawIndex = 1;
            this.active_drawing = true;
            this.pnMain.Cursor = Cursors.Cross;
            this.btnShapeOut.Enabled = true;
            this.btnWidthLine.Enabled = true;
            this.btnShapeFill.Enabled = false;
            this.isGroup = false;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            this.DrawIndex = 0;
            this.active_drawing = true;
            this.pnMain.Cursor = Cursors.Cross;
            this.btnShapeOut.Enabled = true;
            this.btnWidthLine.Enabled = true;
            this.btnShapeFill.Enabled = false;
            this.isGroup = false;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            this.DrawIndex = 2;
            this.active_drawing = true;
            this.pnMain.Cursor = Cursors.Cross;
            this.btnShapeOut.Enabled = true;
            this.btnWidthLine.Enabled = true;
            this.btnShapeFill.Enabled = false;
            this.isGroup = false;
        }

        private void btnIRectangle_Click(object sender, EventArgs e)
        {
            this.DrawIndex = 3;
            this.active_drawing = true;
            this.pnMain.Cursor = Cursors.Cross;
            this.btnShapeOut.Enabled = false;
            this.btnWidthLine.Enabled = false;
            this.btnShapeFill.Enabled = true;
            this.isGroup = false;
        }

        private void btnIEllipse_Click(object sender, EventArgs e)
        {
            this.DrawIndex = 4;
            this.active_drawing = true;
            this.pnMain.Cursor = Cursors.Cross;
            this.btnShapeOut.Enabled = false;
            this.btnWidthLine.Enabled = false;
            this.btnShapeFill.Enabled = true;
            this.isGroup = false;
        }

        private void btnMouse_Click(object sender, EventArgs e)
        {
            this.active_drawing = false;
            this.pnMain.Cursor = Cursors.Default;
            this.isGroup = false;
        }

        private float widthLine()
        {
            for (int i = 0; i < this.btnWidthLine.DropDownItems.Count; i++)
                if (this.btnWidthLine.DropDownItems[i].Checked)
                    return float.Parse(this.btnWidthLine.DropDownItems[i].Text);
            return 0;
        }

        ContextMenuStrip popup;

        private void pnMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if ((!this.active_drawing && this.index != -1) || this.isGroup)
                {
                    popup = new ContextMenuStrip();

                    // Create the menu items
                    ToolStripMenuItem menuItem1 = new ToolStripMenuItem("Delete");
                    ToolStripMenuItem menuItem2 = new ToolStripMenuItem("Cancel");
                    ToolStripMenuItem menuItem3 = new ToolStripMenuItem("Move");

                    // Add the menu items to the ContextMenuStrip
                    if(this.isGroup)
                    {
                        popup.Items.Add(menuItem3);
                        menuItem3.Click += new EventHandler(btnMove_Click);
                    }
                    popup.Items.Add(menuItem1);
                    popup.Items.Add(menuItem2);

                    // Show the ContextMenuStrip at the mouse cursor location
                    popup.Show(this.pnMain, new Point(e.X, e.Y));

                    // Click
                    menuItem1.Click += new EventHandler(btnDelete_Click);
                    menuItem2.Click += new EventHandler(btnCancel_Click);
                }
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            this.moveGroup = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.moveGroup= false;
            this.lstGroup.Clear();
            this.active_drawing = true;
            this.pnMain.Cursor = Cursors.Cross;
            this.popup.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.isGroup)
            {
                List<CObject> objects = new List<CObject>();
                for(int i = 0; i < this.lstDrawObject.Count; i++)
                {
                    if(!lstGroup.Contains(i))
                        objects.Add(this.lstDrawObject[i]);
                }
                this.lstGroup.Clear();
                this.lstDrawObject.Clear();
                this.lstDrawObject.AddRange(objects);
            }
            else
            {
                if (!this.active_drawing && this.index >= 0 && this.index < this.lstDrawObject.Count)
                {
                    this.lstDrawObject.RemoveAt(index);
                }
            }

            this.pnMain.Refresh();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            this.DrawIndex = 5;
            this.active_drawing = true;
            this.pnMain.Cursor = Cursors.Cross;
            this.btnShapeOut.Enabled = false;

            this.btnWidthLine.Enabled = false;
            this.btnShapeFill.Enabled = false;
            
            this.isGroup = true;
            this.moveGroup = false;
            this.lstGroup.Clear();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            this.DrawIndex = 6;
            this.active_drawing = true;
            this.pnMain.Cursor = Cursors.Cross;
            this.btnShapeOut.Enabled = true;
            this.btnWidthLine.Enabled = true;
            this.btnShapeFill.Enabled = false;
            this.isGroup = false;
        }

        private void btnICircle_Click(object sender, EventArgs e)
        {
            this.DrawIndex = 7;
            this.active_drawing = true;
            this.pnMain.Cursor = Cursors.Cross;
            this.btnShapeOut.Enabled = false;
            this.btnWidthLine.Enabled = false;
            this.btnShapeFill.Enabled = true;
            this.isGroup = false;
        }
        private void btnArc_Click(object sender, EventArgs e)
        {
            this.DrawIndex = 8;
            this.active_drawing = true;
            this.pnMain.Cursor = Cursors.Cross;
            this.btnShapeOut.Enabled = true;
            this.btnWidthLine.Enabled = true;
            this.btnShapeFill.Enabled = false;
            this.isGroup = false;
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            this.DrawIndex = 9;
            this.active_drawing = true;
            this.pnMain.Cursor = Cursors.Cross;
            this.btnShapeOut.Enabled = true;
            this.btnWidthLine.Enabled = true;
            this.btnShapeFill.Enabled = false;
            this.isGroup = false;
        }

        private void btnIPolygon_Click(object sender, EventArgs e)
        {
            this.DrawIndex = 10;
            this.active_drawing = true;
            this.pnMain.Cursor = Cursors.Cross;
            this.btnShapeOut.Enabled = false;
            this.btnWidthLine.Enabled = false;
            this.btnShapeFill.Enabled = true;
            this.isGroup = false;
        }

        private void CreateColorTable()
        {
            // Lặp lại cho mỗi ô màu
            for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    // Tạo đối tượng Panel mới
                    Panel panel = new Panel();
                    panel.BorderStyle = BorderStyle.Fixed3D;

                    // Đặt màu nền cho Panel
                    int index = row * tableLayoutPanel1.ColumnCount + col;
                    if (index < KnownColors.Length)
                    {
                        panel.BackColor = KnownColors[index];
                    }

                    // Thêm sự kiện Click cho Panel
                    panel.Click += new EventHandler(panel_Click);

                    // Thêm Panel vào TableLayoutPanel
                    tableLayoutPanel1.Controls.Add(panel, col, row);
                }
            }
        }

        // Sự kiện Click cho Panel
        private void panel_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            color = panel.BackColor;
            this.pcbColor.BackColor = color;
            if(this.btnShapeFill.Enabled)
            {
                this.btnShapeFill.Color = color;
            }
            if (this.btnShapeOut.Enabled)
            {
                this.btnShapeOut.Color = color;
            }
        }

        private Color[] KnownColors = new Color[] {
            Color.Black, Color.White, Color.Red, Color.Yellow, Color.Green, Color.Blue, Color.Purple, Color.Orange,
            Color.Gray, Color.DarkGray, Color.LightGray, Color.Crimson, Color.Goldenrod, Color.ForestGreen, Color.DodgerBlue, Color.MediumVioletRed,
            Color.Pink, Color.DeepPink, Color.OrangeRed, Color.Tomato, Color.DarkKhaki, Color.OliveDrab, Color.Teal, Color.DarkCyan,
            Color.MediumBlue, Color.RoyalBlue, Color.MediumPurple, Color.Indigo, Color.DarkOrchid, Color.DarkSlateGray, Color.SaddleBrown, Color.Sienna
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            g = this.pnMain.CreateGraphics();
            
            CreateColorTable();
            this.color = KnownColors[5];
            this.btnShapeFill.Color = this.color;
            this.btnShapeOut.Color = this.color;
            this.pcbColor.BackColor = this.color;
        }
    }
}