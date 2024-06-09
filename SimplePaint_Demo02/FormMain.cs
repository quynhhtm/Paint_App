using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint_Demo02
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        ToolStripMenuItem btnWindows = new ToolStripMenuItem();
        private Form1 graphics;
        private int counter = 1;
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnWindows.Name = "btnWindows";
            btnWindows.Text = "Windows";
            btnWindows.Size = new Size(120, 28);

            var item = mainmenu.Items.IndexOf(btnWindows);

            if (item == -1)
            {
                mainmenu.Items.Add(btnWindows);
                mainmenu.MdiWindowListItem = btnWindows;
            }
            graphics = new Form1();
            graphics.Name = string.Concat("Graphics", counter.ToString());
            graphics.Text = graphics.Name;
            graphics.MdiParent = this;
            graphics.Show();
            graphics.WindowState = FormWindowState.Maximized;

            counter++;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
