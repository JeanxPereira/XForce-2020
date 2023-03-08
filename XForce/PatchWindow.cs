using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XForce.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace XForce
{
    public partial class PatchWindow : Form
    {
        bool open, close;

        public Point mouseLocation;
        public PatchWindow()
        {
            InitializeComponent();
        }

        private void PatchWindow_Load(object sender, EventArgs e)
        {
            open = true;
            fadeTimer.Start();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            close = true;
            fadeTimer.Start();
        }

        private void Patched_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;

            }
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            if (open)
            {
                if (this.Opacity < 1.0)
                {
                    this.Opacity += 0.1;
                }
                else
                {
                    open = false;
                    fadeTimer.Stop();
                }
            }
            else if (close)
            {
                this.Opacity -= 0.1;

                if (this.Opacity == 0)
                    this.Dispose();
            }
        }
    }
}
