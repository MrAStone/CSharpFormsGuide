using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFormsGuide
{
    public partial class Form5 : Form
    {
        List<int> myData;
        Graphics g;
        int x, y;
        int scale = 10;
        int w, h;
        public Form5(List<int> data)
        {
           

            InitializeComponent();
            x =panel1.Location.X+ 10;
            y = panel1.Location.Y+panel1.Height- 10;
            myData = data;
            g = CreateGraphics();
            panel1.Paint += new PaintEventHandler(Panel1_Paint);
            this.SizeChanged += Form5_SizeChanged;
            w = this.Width;
            h = this.Height;
        }

        private void Form5_SizeChanged(object? sender, EventArgs e)
        {
            if (this.Width < w || this.Height < h)
            {
                scale -= 1;
            }
            else { scale += 1; }
            panel1.Width = this.Width-100;
            panel1.Height = this.Height-100;
            panel1.Invalidate();
            
        }

        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {
            Panel pp = sender as Panel;
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.RebeccaPurple, 3);
            int t = y;
            for (int i = 0; i < myData.Count; i++)
            {

                int d = myData[i];
                //  MessageBox.Show(y.ToString());
                g.DrawLine(p, x, t, x + scale, y - (d * scale / 10));
                x = x + scale;
                t = y - d;
            }
        }

        //private void panel1_Paint(object? sender, PaintEventArgs e)
        //{
        //     // set the panel to be used
        //     Panel pp = sender as Panel;
        //    Graphics g = e.Graphics;
        //    Pen p = new Pen(Color.RebeccaPurple, 3);
        //    int t = y;
        //    for (int i = 0; i < myData.Count; i++)
        //    {

        //        int d = myData[i];
        //      //  MessageBox.Show(y.ToString());
        //        g.DrawLine(p, x, t, x + scale, y- (d*scale/10));
        //        x = x + scale;
        //        t = y - d;
               

        //    }
        //}

      
    }
}
