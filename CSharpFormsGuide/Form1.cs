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
           
            f2 = new Form2(textBox1.Text); // load Form2 with the parameter of the textbox data
            f2.Show(); // show form 2
            f2.FormClosing += F2_FormClosing; // add event listener for closing form2
            this.Visible = false; //hide this form
        }

        // Event for when form 2 is closed.
        // Makes form 1 visible again
        private void F2_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Visible = true; // when form2 closes show this one again
        }
               


    }
}
