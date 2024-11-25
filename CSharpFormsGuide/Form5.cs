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
        int count;
        Random rng;
        public Form5(List<int> data)
        {
           

            InitializeComponent();
            rng = new Random();
            panel1.Width = this.Width - 75;
            panel1.Height = this.Height - 75;
            x =panel1.Location.X+ 10;
            y = panel1.Location.Y+panel1.Height- 10;
            
            myData = data;
            g = CreateGraphics();
            w = this.Width;
            h = this.Height;
            panel1.Paint += new PaintEventHandler(Panel1_Paint);
            this.SizeChanged += Form5_SizeChanged;
            count = data.Count;
            
        }

        private void Form5_SizeChanged(object? sender, EventArgs e)
        {
            //if (this.Width < w || this.Height < h)
            //{
            //    scale -= 1;
            //    w = this.Width;
            //    h = this.Height;
            //}
            //else { scale += 1; }
            panel1.Width = this.Width-75;
            panel1.Height = this.Height-75;
            panel1.Location = new Point(10,10);
            y = panel1.Location.Y + panel1.Height - 10;
            label1.Text = panel1.Height.ToString();
            label2.Text = myData.Max().ToString();


            panel1.Invalidate();
           
            
        }

        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {
            Panel pp = sender as Panel;
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red, 3);
            Pen p2 = new Pen(Color.Green, 3);
            int t = y;
            int s = y;
            x = panel1.Location.X + 10;
            g.FillRectangle(new SolidBrush(Color.White), pp.DisplayRectangle);
            for (int i = 0; i < myData.Count; i++)
            {
                                int d = myData[i];
                //  MessageBox.Show(y.ToString());
                d = (pp.Height / myData.Max()) * d;
                g.DrawLine(p, x, t, x + pp.Width/count, y - (d));
                //int r = rng.Next(1, pp.Height);
                //g.DrawLine(p2, x, s, x + pp.Width / count, y - r);
               // s = y - r;
                x = x + pp.Width/count;
                t = y - d;
            }

        }

       

      
    }
}
