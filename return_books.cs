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
    public partial class return_books : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=library_management_system;Integrated Security=True");
     
        public return_books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            fill_grid(enrollment_number.Text);
        }

        private void return_books_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        public void fill_grid(string enrollment)
        {
            DataTable dt = new DataTable();
            string str = "select *from issue_books where student_enrollment='"+enrollment.ToString()+"' and book_return_date='' ";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;

            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            DataTable dt = new DataTable();
            string str = "select *from issue_books where id="+i+"";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lbl_bookname.Text = dr["book_name"].ToString();
                lbl_issuedate.Text = Convert.ToString(dr["book_issue_date"].ToString());

            
            }        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            
            string str = "update issue_books set book_return_date='" + dateTimePicker1.Value.ToString() + "' where id=" + i + "  ";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();

            string str1 = "update books_info set available_quantity= available_quantity+1 where books_name='"+lbl_bookname.Text+"' ";
            SqlCommand cmd1 = new SqlCommand(str1, con);
           cmd1.ExecuteNonQuery();

           MessageBox.Show("Book Returned Successfully");
            //panel2.Visible=false;
            panel3.Visible = true;
            fill_grid(enrollment_number.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
