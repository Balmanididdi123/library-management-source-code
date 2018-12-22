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
using System.IO;
namespace Library_Management_System
{
    public partial class view_student_info : Form
    {

        string wanted_path;
        string pwd = Class1.GetRandomPassword(20);
        DialogResult result;
        
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=library_management_system;Integrated Security=True");

        public view_student_info()
        {
            InitializeComponent();
        }

        private void view_student_info_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            display();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                int i = 0;
                string str = "select *from student_info where student_name like('%" + textBox1.Text + "%')";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                Bitmap img;
                DataGridViewImageColumn imagecol = new DataGridViewImageColumn();

                imagecol.HeaderText = "Student Image";
                imagecol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imagecol.Width = 100;
                dataGridView1.Columns.Add(imagecol);

                foreach (DataRow dr in dt.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                    dataGridView1.Rows[i].Cells[8].Value = img;
                    dataGridView1.Rows[i].Height = 100;
                    i = i + 1;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());


            string str = "select *from student_info where id=" + i + "";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                name.Text = dr["student_name"].ToString();
                enrollment_number.Text = dr["student_enrollment_number"].ToString();
                department.Text = dr["student_department"].ToString();
                semester.Text = dr["student_semester"].ToString();
                contact.Text = dr["student_contact"].ToString();
                email.Text = dr["student_email"].ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
             result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files(*.gif)|*.gif";
           
        }

       public void display()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
                
            int i = 0;
            string str = "select *from student_info";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            Bitmap img;
            DataGridViewImageColumn imagecol = new DataGridViewImageColumn();

            imagecol.HeaderText = "Student Image";
            imagecol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imagecol.Width = 100;
            dataGridView1.Columns.Add(imagecol);

            foreach (DataRow dr in dt.Rows)
            {
                img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
                dataGridView1.Rows[i].Cells[8].Value = img;
                dataGridView1.Rows[i].Height = 100;
                i = i + 1;

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (result == DialogResult.OK)
            {
                int i;
                i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

                string img_path;
                File.Copy(openFileDialog1.FileName, wanted_path + "\\student_images\\" + pwd + ".jpg");
                img_path = "student_images\\" + pwd + ".jpg";

                string str = "update student_info set student_name='"+name.Text+"',student_image='"+img_path.ToString()+"',student_enrollment_number='"+enrollment_number.Text+"',student_department='"+department.Text+"',student_semester='"+semester.Text+"',student_contact='"+contact.Text+"',student_email='"+email.Text+"' where id="+i+"  ";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                display();
                MessageBox.Show("Record Updated Successfully!!!");    
            
            }
            else if (result == DialogResult.Cancel)
            {
                int i;
                i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                string str = "update student_info set student_name='" + name.Text + "',student_enrollment_number='" + enrollment_number.Text + "',student_department='" + department.Text + "',student_semester='" + semester.Text + "',student_contact='" + contact.Text + "',student_email='" + email.Text + "' where id=" + i + "  ";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                display();
                MessageBox.Show("Record Updated Successfully!!!");    
            
            
            }
        }
    }
}
