using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharpFormsGuide
{
    public partial class Form3 : Form
    {
      
        public Form3()
        {
            InitializeComponent();
            panel1.Paint += new PaintEventHandler(panel1_Paint); //event to draw in the panel
            this.SizeChanged += Form3_SizeChanged; // event when form size is changed
        }

        private void Form3_SizeChanged(object? sender, EventArgs e) //will run when form is resized
        {
            panel1.Width = this.Width - 100; // change panel width to scale with form
            panel1.Height = this.Height - 100; // change panel height to scale with form
            panel1.Invalidate(); // remove graphics from the panel

        }
        
        private void panel1_Paint(object? sender, PaintEventArgs e) //paint event for drawing graphics
        {

            Panel p = panel1; // give panel a shorter name
            Graphics g = e.Graphics; // needed for drawing
          
            g.FillRectangle(new SolidBrush(Color.RebeccaPurple),p.DisplayRectangle); // create a rectangle for the whole panel
            g.DrawLine(new Pen(Color.Green,10),p.Left+5,p.Top+5,p.Width-5,p.Height-5); // draw a line in the panel
        }
        
       

      
    }
}
