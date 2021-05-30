using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS
{
    public partial class CourseConfirmation : Form
    {
        public CourseConfirmation()
        {
            InitializeComponent();
        }
        private void CourseConfirmation_Load(object sender, EventArgs e)
        {
            string sorgu = "SELECT StudentLesson.StudentLessonId,Student.NameLastname,Student.Number,Lesson.LessonName,StudentLesson.Confirmation FROM StudentLessons AS StudentLesson INNER JOIN Lessons as Lesson on StudentLesson.LessonId = Lesson.LessonId INNER JOIN Students AS Student on StudentLesson.StudentId = Student.StudentId ";
            SqlConn sqlConn = new SqlConn();
            Komut komut = new Komut();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(komut.comm(sorgu));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConn.Close();
            
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-BRNH8DO\SQLEXPRESS;Initial Catalog=StudentInformationSystem;Integrated Security=True");
        private void Update_Button_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string update = "update StudentLessons set  Confirmation=@confirmation where LessonId=@lessonId ";
            SqlCommand updatecom = new SqlCommand(update, sqlConnection);
            updatecom.Parameters.AddWithValue("@lessonId", Convert.ToInt32(DersId_textBox.Text));
            if (True_RadioButton.Checked)
                updatecom.Parameters.AddWithValue("@confarmation","True");
            
            if (False_RadioButton.Checked)
                updatecom.Parameters.AddWithValue("@confarmation", "False");
            
            updatecom.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Ders Bilgileri Güncellendi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT StudentLesson.StudentLessonId,Student.NameLastname,Student.Number,Lesson.LessonName,StudentLesson.Confirmation FROM StudentLessons AS StudentLesson INNER JOIN Lessons as Lesson on StudentLesson.LessonId = Lesson.LessonId INNER JOIN Students AS Student on StudentLesson.StudentId = Student.StudentId ";
            SqlConn sqlConn = new SqlConn();
            Komut komut = new Komut();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(komut.comm(sorgu));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConn.Close();
        }
    }
}
