using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class add_books : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=library_management_system;Integrated Security=True");
      
        SqlCommand cmd;
       
        string time;

        public add_books()
        {
            InitializeComponent();
        }

        private void add_books_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
           }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            //time = dateTimePicker1.Text.ToString();

            string str = "insert into books_info values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.Date + "'," + textBox5.Text + "," + textBox6.Text + "," + textBox6.Text +") ";
            cmd=new SqlCommand(str,con);
            int success = cmd.ExecuteNonQuery();
                
            con.Close();

            if (success != 0)
            {
                MessageBox.Show("Record Inserted Successfully!!!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                //textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            else
            {
                MessageBox.Show("Error: Record can't be Inserted!!!");
            
            }
        }
    }
}
