using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simmetry
{
    public partial class Form1 : Form
    {
        private int brushSize = 2;
        private System.Drawing.Graphics graphics;
        private System.Drawing.SolidBrush myBrush;

        public Form1()
        {
            InitializeComponent();
            this.graphics = this.panel1.CreateGraphics();
            this.myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        }


        private Rectangle getRect(int x, int y)
        {
            return new System.Drawing.Rectangle(x - (brushSize / 2), y - (brushSize / 2), brushSize, brushSize);
        }

        private void draw(int x, int y)
        {
            this.graphics.FillEllipse(myBrush, getRect(x, y));
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            int w = this.panel1.Width;
            int h = this.panel1.Height;



            if (e.Button == MouseButtons.Left)
            {

                //System.Drawing.Graphics graphics = this.panel1.CreateGraphics();
                //System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                //System.Drawing.Rectangle rectangle1 = new System.Drawing.Rectangle(e.X - (brushSize / 2), e.Y - (brushSize / 2), brushSize, brushSize);
                
                //this.graphics.FillEllipse(myBrush, getRect(e.X, e.Y));
                draw(e.X, e.Y);
               



            }







        }
    }
}
