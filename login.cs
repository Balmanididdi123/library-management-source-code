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
    public partial class login : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=library_management_system;Integrated Security=True");
        //int count = 0;
        //SqlDataReader dr;
        SqlCommand cmd;
        //SqlDataAdapter da;

        public login()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources._2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
           // con.Open();
            string str = "select *from library_person where username='"+textBox1.Text+"' and password='"+textBox2.Text+"'";
             cmd = new SqlCommand(str,con);
            SqlDataReader dr= cmd.ExecuteReader();
           // DataTable dt = new DataTable();
           // SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
           // count = Convert.ToInt32(dt.Rows.Count.ToString());
             if (dr.Read())
            {
                this.Hide();
                mdi_user md = new mdi_user();
                md.Show();
                dr.Close();
              }
            else
            {
                MessageBox.Show("Username and password does not match");
          

            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        
        
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
