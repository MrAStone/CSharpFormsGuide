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
        public Form5(List<int> data)
        {
           

            InitializeComponent();
            x = 10;
            y = this.Height - 10;
            myData = data;
            g = CreateGraphics();
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panel1_Paint(object? sender, PaintEventArgs e)
        {
             // set the panel to be used
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.RebeccaPurple, 3);
            for (int i = 0; i < myData.Count; i++)
            {
                int d = myData[i];
                g.DrawLine(p,x,y,x+5, this.Height - 10 - (d));
                x += 5;
                y = this.Height - 10 - (d);

            }
        }

      
    }
}
