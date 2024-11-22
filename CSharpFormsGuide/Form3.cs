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
        Random rng = new Random();
        Graphics g;
        public Form3()
        {
            InitializeComponent();
           g = CreateGraphics();
            this.SizeChanged += Form3_SizeChanged;
        }

        private void Form3_SizeChanged(object? sender, EventArgs e)
        {
            ClearColor();
        }

        private void doThing()
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // this is a comment
            int x, y;
            x = this.Width;
            y = this.Height;
            Pen p = new Pen(Color.Black, 10);
            g.DrawLine(p,0,0,x-20,y-20);
           // g.DrawEllipse(p, 100, 100, 100, 100);

        }
        private void ClearColor()
        {
            g.Clear(Color.White);
        }
        private void drawGraph()
        {
            // this is a comment
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.LemonChiffon, 10);
            g.DrawLine(p, 100, 100, 100, 500);
            g.DrawEllipse(p, 100, 100, 100, 100);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawGraph();
        }
    }
}
