namespace Library_Management_System
{
    partial class issue_books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_book_name = new System.Windows.Forms.TextBox();
            this.txt_student_email = new System.Windows.Forms.TextBox();
            this.txt_student_contact = new System.Windows.Forms.TextBox();
            this.txt_student_semester = new System.Windows.Forms.TextBox();
            this.txt_student_department = new System.Windows.Forms.TextBox();
            this.txt_student_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_student_enrollment_number = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_book_name);
            this.panel1.Controls.Add(this.txt_student_email);
            this.panel1.Controls.Add(this.txt_student_contact);
            this.panel1.Controls.Add(this.txt_student_semester);
            this.panel1.Controls.Add(this.txt_student_department);
            this.panel1.Controls.Add(this.txt_student_name);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_student_enrollment_number);
            this.panel1.Location = new System.Drawing.Point(50, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 492);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(465, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Issue Book";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(547, 294);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Book Issue Date";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Enter Enrollment No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Book Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Student Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Student Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student Name";
            // 
            // txt_book_name
            // 
            this.txt_book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_book_name.Location = new System.Drawing.Point(547, 342);
            this.txt_book_name.Name = "txt_book_name";
            this.txt_book_name.Size = new System.Drawing.Size(254, 23);
            this.txt_book_name.TabIndex = 7;
            this.txt_book_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_book_name_KeyDown);
            this.txt_book_name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_book_name_KeyUp);
            // 
            // txt_student_email
            // 
            this.txt_student_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_student_email.Location = new System.Drawing.Point(547, 256);
            this.txt_student_email.Name = "txt_student_email";
            this.txt_student_email.Size = new System.Drawing.Size(254, 23);
            this.txt_student_email.TabIndex = 6;
            // 
            // txt_student_contact
            // 
            this.txt_student_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_student_contact.Location = new System.Drawing.Point(547, 203);
            this.txt_student_contact.Name = "txt_student_contact";
            this.txt_student_contact.Size = new System.Drawing.Size(254, 23);
            this.txt_student_contact.TabIndex = 5;
            // 
            // txt_student_semester
            // 
            this.txt_student_semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_student_semester.Location = new System.Drawing.Point(547, 148);
            this.txt_student_semester.Name = "txt_student_semester";
            this.txt_student_semester.Size = new System.Drawing.Size(254, 23);
            this.txt_student_semester.TabIndex = 4;
            // 
            // txt_student_department
            // 
            this.txt_student_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_student_department.Location = new System.Drawing.Point(547, 99);
            this.txt_student_department.Name = "txt_student_department";
            this.txt_student_department.Size = new System.Drawing.Size(254, 23);
            this.txt_student_department.TabIndex = 3;
            // 
            // txt_student_name
            // 
            this.txt_student_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_student_name.Location = new System.Drawing.Point(547, 51);
            this.txt_student_name.Name = "txt_student_name";
            this.txt_student_name.Size = new System.Drawing.Size(254, 23);
            this.txt_student_name.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_student_enrollment_number
            // 
            this.txt_student_enrollment_number.Location = new System.Drawing.Point(93, 60);
            this.txt_student_enrollment_number.Name = "txt_student_enrollment_number";
            this.txt_student_enrollment_number.Size = new System.Drawing.Size(193, 20);
            this.txt_student_enrollment_number.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(547, 362);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 82);
            this.listBox1.TabIndex = 18;
            this.listBox1.Visible = false;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // issue_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 527);
            this.Controls.Add(this.panel1);
            this.Name = "issue_books";
            this.Text = "issue_books";
            this.Load += new System.EventHandler(this.issue_books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_book_name;
        private System.Windows.Forms.TextBox txt_student_email;
        private System.Windows.Forms.TextBox txt_student_contact;
        private System.Windows.Forms.TextBox txt_student_semester;
        private System.Windows.Forms.TextBox txt_student_department;
        private System.Windows.Forms.TextBox txt_student_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_student_enrollment_number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
    }
}