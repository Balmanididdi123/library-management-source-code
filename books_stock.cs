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
using System.Net.Mail;
using System.Net;
namespace Library_Management_System
{
    public partial class books_stock : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=library_management_system;Integrated Security=True");

        public books_stock()
        {
            InitializeComponent();
        }

        private void books_stock_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            fill_books_info();
        }
        public void fill_books_info()
        {
            string str = "select books_name,books_author_name,books_quantity,available_quantity from books_info ";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Visible = true;
            string i;
            i = dataGridView1.SelectedCells[0].Value.ToString();
            string str = "select *from issue_books where book_name='"+i.ToString()+"' and book_return_date='' ";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string str = "select books_name,books_author_name,books_quantity,available_quantity from books_info where books_name like('%"+textBox1.Text+"%') ";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         }

        private void t(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string i;
            i = dataGridView2.SelectedCells[6].Value.ToString();
            txt_email.Text = i.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                //(username,passsword)
                smtp.Credentials = new NetworkCredential("balmanididdi123@gmail.com", "xxxx");
                //(from,to,subject,body)
                MailMessage mail = new MailMessage("balmanididdi123@gmail.com", txt_email.Text, "This is for book return notice", txt_content.Text);
                mail.Priority = MailPriority.High;
                smtp.Send(mail);
                MessageBox.Show("Mail sent Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
