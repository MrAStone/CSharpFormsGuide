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
        int x, y,w,h;
        int count;
        double scalerValue;
        Random rng;
        public Form5(List<int> data)
        {


            InitializeComponent();
            rng = new Random(); // create a random number generator
            panel1.Size = new Size(this.Width - 75, this.Height - 75); // set the panel to scale with the form
            y = panel1.Location.Y + panel1.Height - 10; // set the y value to the bottom of the panel
            myData = data; // set the data from the database
            w = this.Width; // get the width of the form
            h = this.Height; // get the height of the form
            panel1.Paint += new PaintEventHandler(Panel1_Paint); // add the paint event to the panel
            this.SizeChanged += Form5_SizeChanged; // add the size changed event to the form
            scalerValue = myData.Max(); // get the maximum value of the data to be used in scaling hieght calculation (height/max value) * data value will scale the data to the panel height
            count = data.Count; // get the number of data items to scale the width of the panel

        }

        private void Form5_SizeChanged(object? sender, EventArgs e)
        {

            panel1.Size = new Size(this.Width - 75, this.Height - 75); // set the panel to scale with the form
            panel1.Location = new Point(10, 10); // set the panel to a fixed location
            y = panel1.Location.Y + panel1.Height - 10; // set the y value to the bottom of the panel
            panel1.Invalidate(); // redraw the panel


        }

        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {

            Panel pp = panel1; // give panel a shorter name 
            Graphics g = e.Graphics; // load graphics
            Pen p1 = new Pen(Color.Red, 3); // pen for database data
            Pen p2 = new Pen(Color.Green, 3); // pen for random data
            int t = y;// start y value for the database data
            int s = y; // start y value for the random data
            x = 0; // start x value (0 is the left of the panel
            g.FillRectangle(new SolidBrush(Color.Black), pp.DisplayRectangle); // fill the panel with white
            for (int i = 0; i < myData.Count; i++) // loop through the demo data from the database
            {
                double d = Convert.ToDouble(myData[i]); // get the value of data item
                d = pp.Height / scalerValue * d; // set the scaling of the data (uses scaling calculation)
                g.DrawLine(p1, x, t, x + pp.Width / count, Convert.ToInt32(y - (d))); // draw a line from x,y to the data point
                int r = rng.Next(1, pp.Height); // generate a random number 
                g.DrawLine(p2, x, s, x + pp.Width / count, y - r); // draw line for random number data
                x = x + pp.Width / count; // set the next x point
                t = Convert.ToInt32(y - d); // set the start y point for the next database item
                s = y - r; // set the start y point for the next random data item
            }

        }




    }
}
