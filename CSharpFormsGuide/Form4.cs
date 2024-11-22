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

namespace CSharpFormsGuide
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            MySqlConnection con = new MySqlConnection("server = srv1475.hstgr.io;uid=u381396247_tester;pwd=:3ylKqjBAG;database=u381396247_tester") ;
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            string SQL = "SELECT testID FROM Test1";
            cmd.CommandText = SQL;
            cmd.Connection = con;
            string output = "";
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               
                listBox1.Items.Add(dr.GetInt32(0)); // listbox shows data in a list
                listView1.Items.Add(dr.GetInt32(0).ToString());//list view needs a string data
                comboBox1.Items.Add(dr.GetInt32(0));// combobox is a dropdown menu
            }
            con.Close();
            
        }
    }
}
