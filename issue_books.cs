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
    public partial class issue_books : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=library_management_system;Integrated Security=True");

        public issue_books()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int books_quantity=0;
            DataTable dt = new DataTable();
            string str3 = "select *from books_info where books_name='"+txt_book_name.Text+"'";
            SqlCommand cmd2 = new SqlCommand(str3, con);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.Fill(dt);
            foreach (DataRow dr2 in dt.Rows)
            {
                books_quantity = Convert.ToInt32(dr2["available_quantity"].ToString());
            }
            if (books_quantity > 0)
            {
                string str = "insert into issue_books values('" + txt_student_enrollment_number.Text + "','" + txt_student_name.Text + "','" + txt_student_department.Text + "','" + txt_student_semester.Text + "','" + txt_student_contact.Text + "','" + txt_student_email.Text + "','" + txt_book_name.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "')";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "update books_info set available_quantity=available_quantity-1 where books_name='" + txt_book_name.Text + "'";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Book issued successfully");
            }
            else
            {
                MessageBox.Show("Books not Available");
            }
         }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            DataTable dt = new DataTable();

            string str = "select *from student_info where student_enrollment_number='"+txt_student_enrollment_number.Text+"' ";
            SqlCommand cmd =new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Entered Enrollment Number does not exists");
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    txt_student_name.Text = dr["student_name"].ToString();
                    txt_student_department.Text = dr["student_department"].ToString();
                    txt_student_semester.Text = dr["student_semester"].ToString();
                    txt_student_contact.Text = dr["student_contact"].ToString();
                    txt_student_email.Text = dr["student_email"].ToString();
                }

            }
        }

        private void issue_books_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            
        }

        private void txt_book_name_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable dt = new DataTable();
            int count = 0;
            if (e.KeyCode != Keys.Enter)
            {
                listBox1.Items.Clear();

                string str = "select *from books_info where books_name like('%" + txt_book_name.Text + "%')";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                if (count > 0)
                {
                    listBox1.Visible = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        listBox1.Items.Add(dr["books_name"].ToString());
                    }
                }
            
            
            }
        }

        private void txt_book_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }

        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_book_name.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
            
            
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_book_name.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;
        }
    }
}
