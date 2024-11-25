using MySqlConnector;
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
    public partial class Form4 : Form
    {
        List<int> data = new List<int>();
        Form5 f5;
        
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("server = srv1475.hstgr.io;uid=u381396247_tester;pwd=:3ylKqjBAG;database=u381396247_tester");
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            string SQL = "SELECT TestDetails FROM Test1";
            cmd.CommandText = SQL; // set the command text
            cmd.Connection = con; // set the connection
                        MySqlDataReader dr = cmd.ExecuteReader(); // execute the SQL command
            while (dr.Read()) // read the data
            {
                int dataRead = dr.GetInt32(0); // get the data from the first column
                listBox1.Items.Add(dataRead); // listbox shows data in a list
                listView1.Items.Add(dataRead.ToString());//list view needs a string data
                comboBox1.Items.Add(dataRead);// combobox is a dropdown menu
                data.Add(dataRead); // add the data to the list

            }
            con.Close(); // close the connection

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f5 = new Form5(data);
            f5.Show();
            f5.FormClosing += F5_FormClosing;
            this.Visible = false; 
          
        }

        private void F5_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Visible = true;
        }
    }
}
