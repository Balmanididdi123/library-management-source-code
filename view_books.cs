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
//using System.Data;
namespace Library_Management_System
{
     
    public partial class view_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=library_management_system;Integrated Security=True");
     
        public view_books()
        {
            InitializeComponent();
        }

        private void view_books_Load(object sender, EventArgs e)
        {

            display_records(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "select *from books_info where books_name like('%"+textBox1.Text+"%')";
                SqlCommand cmd = new SqlCommand(str, con);

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                con.Open();
                string str = "select *from books_info where books_name like('%" + textBox1.Text + "%')";
                SqlCommand cmd = new SqlCommand(str, con);

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                con.Open();
                string str = "select *from books_info where books_author_name like('%" + textBox2.Text + "%')";
                SqlCommand cmd = new SqlCommand(str, con);

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
              count= Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;

                con.Close();
                if (count== 0)
                {
                    MessageBox.Show("Record Not Found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                int i;
                i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
          
                
                    int cnt = 0;
                    con.Open();
                    string str = "update books_info set books_name='" + bookname.Text + "',books_author_name='" + bookauthorname.Text + "',books_publication_name='" + bookpublicationname.Text + "',books_purchase_date='" + dateTimePicker1.Value.Date + "',books_price=" + bookprice.Text + ",books_quantity=" + bookquantity.Text + " where id="+i+" ";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cnt = cmd.ExecuteNonQuery();
                    con.Close();

                    display_records();
                    
                   if (cnt != 0)
                    {
                        MessageBox.Show("Record Updated Successfully!!!");
                    }
                    else
                    {
                        MessageBox.Show("Error:Record can't be Updated ");
                    }
                   panel3.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                con.Open();
                string str = "select *from books_info where id="+i+"";
                SqlCommand cmd = new SqlCommand(str, con);

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                    bookname.Text = dr["books_name"].ToString();
                   bookauthorname.Text = dr["books_author_name"].ToString();
                    bookpublicationname.Text = dr["books_publication_name"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dr["books_purchase_date"].ToString());
                    bookprice.Text = dr["books_price"].ToString();
                    bookquantity.Text = dr["books_quantity"].ToString();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

       public void display_records()
        {
            try
            {
                con.Open();
                string str = "select *from books_info";
                SqlCommand cmd = new SqlCommand(str, con);

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
