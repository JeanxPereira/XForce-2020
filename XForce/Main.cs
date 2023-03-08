using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using XForce.Properties;
using AAJGen;

namespace XForce
{
    public partial class XForce : Form
    {
        public Point mouseLocation;

        RandomGen rnd = new RandomGen(Option.IncludeCapital);
        public XForce()
        {
            InitializeComponent();
        }

        bool open, close;
        private void Form1_Load(object sender, EventArgs e)
        {
            open = true;
            fadeTimer.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;

            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            close  = true;
            fadeTimer.Start();
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Resources._112;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Resources._111;
        }

        private void patchButton_MouseEnter(object sender, EventArgs e)
        {
            patchButton.Image = Resources._115;
        }

        private void patchButton_MouseLeave(object sender, EventArgs e)
        {
            patchButton.Image = Resources._113;
        }

        private void generateButton_MouseEnter(object sender, EventArgs e)
        {
            generateButton.Image = Resources._108;
        }

        private void generateButton_MouseLeave(object sender, EventArgs e)
        {
            generateButton.Image = Resources._107;
        }

        private void quitButton_MouseEnter(object sender, EventArgs e)
        {
            quitButton.Image = Resources._106;
        }

        private void quitButton_MouseLeave(object sender, EventArgs e)
        {
            quitButton.Image = Resources._105;
        }

        private void patchButton_Click(object sender, EventArgs e)
        {
            var newForm = new PatchWindow();
            newForm.Show();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            close = true;
            fadeTimer.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            activationBox.Text = rnd.Gen(60);
        }

        private void activationBox_TextChanged(object sender, EventArgs e)
        {

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
