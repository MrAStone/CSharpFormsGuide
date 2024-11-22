namespace CSharpFormsGuide
{
    public partial class Form1 : Form
    {
        Form2 f2;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            f2 = new Form2(textBox1.Text); // load Form2 with the parameter
            f2.Show();
            f2.FormClosing += F2_FormClosing;
            this.Visible = false;
        }

        // Event for when form 2 is closed.
        // Makes form 1 visible again
        private void F2_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Visible = true;
        }
               


    }
}
