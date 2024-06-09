namespace SimplePaint_Demo02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.drawTab = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.btnLine = new System.Windows.Forms.RibbonButton();
            this.btnRectangle = new System.Windows.Forms.RibbonButton();
            this.btnEllipse = new System.Windows.Forms.RibbonButton();
            this.btnCircle2 = new System.Windows.Forms.RibbonButton();
            this.btnArc2 = new System.Windows.Forms.RibbonButton();
            this.btnPolygon2 = new System.Windows.Forms.RibbonButton();
            this.btnFilledRectangle = new System.Windows.Forms.RibbonButton();
            this.btnFilledEllipse = new System.Windows.Forms.RibbonButton();
            this.btnFilledCircle = new System.Windows.Forms.RibbonButton();
            this.btnFilledPolygon = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.btnShapeOut = new System.Windows.Forms.RibbonColorChooser();
            this.btnShapeFill = new System.Windows.Forms.RibbonColorChooser();
            this.btnWidthLine = new System.Windows.Forms.RibbonButton();
            this.chk1 = new System.Windows.Forms.RibbonCheckBox();
            this.chk2 = new System.Windows.Forms.RibbonCheckBox();
            this.chk3 = new System.Windows.Forms.RibbonCheckBox();
            this.chk4 = new System.Windows.Forms.RibbonCheckBox();
            this.chk5 = new System.Windows.Forms.RibbonCheckBox();
            this.chk6 = new System.Windows.Forms.RibbonCheckBox();
            this.chk7 = new System.Windows.Forms.RibbonCheckBox();
            this.chk8 = new System.Windows.Forms.RibbonCheckBox();
            this.chk9 = new System.Windows.Forms.RibbonCheckBox();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.btnSelect2 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.btnGroup2 = new System.Windows.Forms.RibbonButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbColor = new System.Windows.Forms.PictureBox();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbColor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMain.Location = new System.Drawing.Point(44, 189);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1446, 566);
            this.pnMain.TabIndex = 0;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            this.pnMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseClick);
            this.pnMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseDown);
            this.pnMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseMove);
            this.pnMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 538);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "0, 0";
            // 
            // ribbon1
            // 
            this.ribbon1.BackColor = System.Drawing.SystemColors.Control;
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1539, 160);
            this.ribbon1.TabIndex = 4;
            this.ribbon1.Tabs.Add(this.drawTab);
            this.ribbon1.TabSpacing = 4;
            this.ribbon1.Text = "ribbon1";
            // 
            // drawTab
            // 
            this.drawTab.Name = "drawTab";
            this.drawTab.Panels.Add(this.ribbonPanel1);
            this.drawTab.Panels.Add(this.ribbonPanel2);
            this.drawTab.Panels.Add(this.ribbonPanel3);
            this.drawTab.Panels.Add(this.ribbonPanel4);
            this.drawTab.Text = "Home";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.btnLine);
            this.ribbonPanel1.Items.Add(this.btnRectangle);
            this.ribbonPanel1.Items.Add(this.btnEllipse);
            this.ribbonPanel1.Items.Add(this.btnCircle2);
            this.ribbonPanel1.Items.Add(this.btnArc2);
            this.ribbonPanel1.Items.Add(this.btnPolygon2);
            this.ribbonPanel1.Items.Add(this.btnFilledRectangle);
            this.ribbonPanel1.Items.Add(this.btnFilledEllipse);
            this.ribbonPanel1.Items.Add(this.btnFilledCircle);
            this.ribbonPanel1.Items.Add(this.btnFilledPolygon);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Shapes";
            // 
            // btnLine
            // 
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLine.LargeImage")));
            this.btnLine.Name = "btnLine";
            this.btnLine.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnLine.SmallImage")));
            this.btnLine.Text = "Line";
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangle.Image")));
            this.btnRectangle.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRectangle.LargeImage")));
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnRectangle.SmallImage")));
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnEllipse.Image")));
            this.btnEllipse.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEllipse.LargeImage")));
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEllipse.SmallImage")));
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnCircle2
            // 
            this.btnCircle2.Image = global::SimplePaint_Demo02.Properties.Resources.circle;
            this.btnCircle2.LargeImage = global::SimplePaint_Demo02.Properties.Resources.circle;
            this.btnCircle2.Name = "btnCircle2";
            this.btnCircle2.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCircle2.SmallImage")));
            this.btnCircle2.Text = "Circle";
            this.btnCircle2.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnArc2
            // 
            this.btnArc2.Image = global::SimplePaint_Demo02.Properties.Resources.arc;
            this.btnArc2.LargeImage = global::SimplePaint_Demo02.Properties.Resources.arc;
            this.btnArc2.Name = "btnArc2";
            this.btnArc2.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnArc2.SmallImage")));
            this.btnArc2.Text = "Arc";
            this.btnArc2.Click += new System.EventHandler(this.btnArc_Click);
            // 
            // btnPolygon2
            // 
            this.btnPolygon2.Image = global::SimplePaint_Demo02.Properties.Resources.pentagon;
            this.btnPolygon2.LargeImage = global::SimplePaint_Demo02.Properties.Resources.pentagon;
            this.btnPolygon2.Name = "btnPolygon2";
            this.btnPolygon2.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPolygon2.SmallImage")));
            this.btnPolygon2.Text = "Polygon";
            this.btnPolygon2.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btnFilledRectangle
            // 
            this.btnFilledRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnFilledRectangle.Image")));
            this.btnFilledRectangle.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFilledRectangle.LargeImage")));
            this.btnFilledRectangle.Name = "btnFilledRectangle";
            this.btnFilledRectangle.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnFilledRectangle.SmallImage")));
            this.btnFilledRectangle.Text = "Filled Retangle";
            this.btnFilledRectangle.Click += new System.EventHandler(this.btnIRectangle_Click);
            // 
            // btnFilledEllipse
            // 
            this.btnFilledEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnFilledEllipse.Image")));
            this.btnFilledEllipse.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFilledEllipse.LargeImage")));
            this.btnFilledEllipse.Name = "btnFilledEllipse";
            this.btnFilledEllipse.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnFilledEllipse.SmallImage")));
            this.btnFilledEllipse.Text = "Filled Ellipse";
            this.btnFilledEllipse.Click += new System.EventHandler(this.btnIEllipse_Click);
            // 
            // btnFilledCircle
            // 
            this.btnFilledCircle.Image = global::SimplePaint_Demo02.Properties.Resources.filled_circle;
            this.btnFilledCircle.LargeImage = global::SimplePaint_Demo02.Properties.Resources.filled_circle;
            this.btnFilledCircle.Name = "btnFilledCircle";
            this.btnFilledCircle.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnFilledCircle.SmallImage")));
            this.btnFilledCircle.Text = "Filled Circle";
            this.btnFilledCircle.Click += new System.EventHandler(this.btnICircle_Click);
            // 
            // btnFilledPolygon
            // 
            this.btnFilledPolygon.Image = global::SimplePaint_Demo02.Properties.Resources.filled_pentagon;
            this.btnFilledPolygon.LargeImage = global::SimplePaint_Demo02.Properties.Resources.filled_pentagon;
            this.btnFilledPolygon.Name = "btnFilledPolygon";
            this.btnFilledPolygon.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnFilledPolygon.SmallImage")));
            this.btnFilledPolygon.Text = "Filled Polygon";
            this.btnFilledPolygon.Click += new System.EventHandler(this.btnIPolygon_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.btnShapeOut);
            this.ribbonPanel2.Items.Add(this.btnShapeFill);
            this.ribbonPanel2.Items.Add(this.btnWidthLine);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Drawing Tools";
            // 
            // btnShapeOut
            // 
            this.btnShapeOut.Color = System.Drawing.Color.Transparent;
            this.btnShapeOut.Image = ((System.Drawing.Image)(resources.GetObject("btnShapeOut.Image")));
            this.btnShapeOut.ImageColorHeight = 4;
            this.btnShapeOut.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnShapeOut.LargeImage")));
            this.btnShapeOut.Name = "btnShapeOut";
            this.btnShapeOut.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnShapeOut.SmallImage")));
            this.btnShapeOut.Text = "Shape Outline";
            // 
            // btnShapeFill
            // 
            this.btnShapeFill.Color = System.Drawing.Color.Transparent;
            this.btnShapeFill.Image = ((System.Drawing.Image)(resources.GetObject("btnShapeFill.Image")));
            this.btnShapeFill.ImageColorHeight = 4;
            this.btnShapeFill.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnShapeFill.LargeImage")));
            this.btnShapeFill.Name = "btnShapeFill";
            this.btnShapeFill.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnShapeFill.SmallImage")));
            this.btnShapeFill.Text = "Shape Fill";
            // 
            // btnWidthLine
            // 
            this.btnWidthLine.DropDownItems.Add(this.chk1);
            this.btnWidthLine.DropDownItems.Add(this.chk2);
            this.btnWidthLine.DropDownItems.Add(this.chk3);
            this.btnWidthLine.DropDownItems.Add(this.chk4);
            this.btnWidthLine.DropDownItems.Add(this.chk5);
            this.btnWidthLine.DropDownItems.Add(this.chk6);
            this.btnWidthLine.DropDownItems.Add(this.chk7);
            this.btnWidthLine.DropDownItems.Add(this.chk8);
            this.btnWidthLine.DropDownItems.Add(this.chk9);
            this.btnWidthLine.Image = ((System.Drawing.Image)(resources.GetObject("btnWidthLine.Image")));
            this.btnWidthLine.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnWidthLine.LargeImage")));
            this.btnWidthLine.Name = "btnWidthLine";
            this.btnWidthLine.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnWidthLine.SmallImage")));
            this.btnWidthLine.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.btnWidthLine.Text = "Line Width";
            // 
            // chk1
            // 
            this.chk1.Name = "chk1";
            this.chk1.Text = "1.0";
            // 
            // chk2
            // 
            this.chk2.Name = "chk2";
            this.chk2.Text = "2.0";
            // 
            // chk3
            // 
            this.chk3.Checked = true;
            this.chk3.Name = "chk3";
            this.chk3.Text = "3.0";
            // 
            // chk4
            // 
            this.chk4.Name = "chk4";
            this.chk4.Text = "4.0";
            // 
            // chk5
            // 
            this.chk5.Name = "chk5";
            this.chk5.Text = "5.0";
            // 
            // chk6
            // 
            this.chk6.Name = "chk6";
            this.chk6.Text = "6.0";
            // 
            // chk7
            // 
            this.chk7.Name = "chk7";
            this.chk7.Text = "7.0";
            // 
            // chk8
            // 
            this.chk8.Name = "chk8";
            this.chk8.Text = "8.0";
            // 
            // chk9
            // 
            this.chk9.Name = "chk9";
            this.chk9.Text = "9.0";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.btnSelect2);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "Select - Drag";
            // 
            // btnSelect2
            // 
            this.btnSelect2.Image = global::SimplePaint_Demo02.Properties.Resources.click;
            this.btnSelect2.LargeImage = global::SimplePaint_Demo02.Properties.Resources.click;
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSelect2.SmallImage")));
            this.btnSelect2.Text = "";
            this.btnSelect2.Click += new System.EventHandler(this.btnMouse_Click);
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.btnGroup2);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Text = "Group";
            // 
            // btnGroup2
            // 
            this.btnGroup2.Image = global::SimplePaint_Demo02.Properties.Resources.selection;
            this.btnGroup2.LargeImage = global::SimplePaint_Demo02.Properties.Resources.selection;
            this.btnGroup2.Name = "btnGroup2";
            this.btnGroup2.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnGroup2.SmallImage")));
            this.btnGroup2.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1072, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 106);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(1007, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Color";
            // 
            // pcbColor
            // 
            this.pcbColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbColor.Location = new System.Drawing.Point(999, 72);
            this.pcbColor.Name = "pcbColor";
            this.pcbColor.Size = new System.Drawing.Size(57, 41);
            this.pcbColor.TabIndex = 6;
            this.pcbColor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 833);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcbColor);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.pnMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab drawTab;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton btnLine;
        private System.Windows.Forms.RibbonButton btnRectangle;
        private System.Windows.Forms.RibbonButton btnEllipse;
        private System.Windows.Forms.RibbonButton btnFilledRectangle;
        private System.Windows.Forms.RibbonButton btnFilledEllipse;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonColorChooser btnShapeOut;
        private System.Windows.Forms.RibbonColorChooser btnShapeFill;
        private System.Windows.Forms.RibbonButton btnWidthLine;
        private System.Windows.Forms.RibbonCheckBox chk1;
        private System.Windows.Forms.RibbonCheckBox chk2;
        private System.Windows.Forms.RibbonCheckBox chk3;
        private System.Windows.Forms.RibbonCheckBox chk4;
        private System.Windows.Forms.RibbonCheckBox chk5;
        private System.Windows.Forms.RibbonCheckBox chk6;
        private System.Windows.Forms.RibbonCheckBox chk7;
        private System.Windows.Forms.RibbonCheckBox chk8;
        private System.Windows.Forms.RibbonCheckBox chk9;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton btnCircle2;
        private System.Windows.Forms.RibbonButton btnFilledCircle;
        private System.Windows.Forms.RibbonButton btnPolygon2;
        private System.Windows.Forms.RibbonButton btnFilledPolygon;
        private System.Windows.Forms.RibbonButton btnArc2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pcbColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RibbonButton btnSelect2;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton btnGroup2;
    }
}

