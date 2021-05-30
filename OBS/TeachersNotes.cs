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
    public partial class TeachersNotes : Form
    {
        public TeachersNotes()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-BRNH8DO\SQLEXPRESS;Initial Catalog=StudentInformationSystem;Integrated Security=True");
        private void TeachersNotes_Load(object sender, EventArgs e)
        {
            string sorgu = "SELECT Note.NoteId,StudentLesson.StudentLessonId,TeacherChapter.TeacherChapterId,Student.NameLastname,Student.Number,Teacher.Name,Teacher.Lastname,Lesson.LessonName,Lesson.LessonCode,Note.Visa, Note.Final, Note.LastExam FROM Notes AS Note INNER JOIN Teachers AS Teacher ON Note.TeacherChapterId= Teacher.TeacherId INNER JOIN Students AS Student ON Note.StudentLessonId = Student.StudentId INNER JOIN Lessons AS Lesson on Note.StudentLessonId = Lesson.LessonId Inner Join TeacherChapters as TeacherChapter on Note.TeacherChapterId = TeacherChapter.TeacherChapterId INNER JOIN StudentLessons as StudentLesson on Note.StudentLessonId = StudentLesson.StudentLessonId";

            SqlConn sqlConn = new SqlConn();
            Komut komut = new Komut();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(komut.comm(sorgu));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConn.Close();
        }
        private void Ad_Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    string AddSorgu = "INSERT INTO Notes(StudentLessonId,TeacherChapterId,Visa,Final,LastExam) VALUES (@studentLesson,@teacherChapter,@visa,@final,@lastExam)";

                    SqlCommand com = new SqlCommand(AddSorgu, sqlConnection);
                    com.Parameters.AddWithValue("@studentLesson", Convert.ToInt32(StudentLessonId_textBox.Text));
                    com.Parameters.AddWithValue("@teacherChapter", Convert.ToInt32(TeacherChapterId_textBox.Text));
                    com.Parameters.AddWithValue("@visa", Convert.ToInt32(Visa_textBox.Text));
                    com.Parameters.AddWithValue("@final", Convert.ToInt32(Final_textBox.Text));
                    com.Parameters.AddWithValue("@lastExam", Convert.ToInt32(LastExam_textBox.Text));
                    com.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Ogrenci Not Kayıt İşlemi Gerçekleşti.");
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("Beklenmeyen bir hata olustu.\n" + error);
            }
            sqlConnection.Close();

        }

        private void Reflesh_Button_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT Note.NoteId,StudentLesson.StudentLessonId,TeacherChapter.TeacherChapterId,Student.NameLastname,Student.Number,Teacher.Name,Teacher.Lastname,Lesson.LessonName,Lesson.LessonCode,Note.Visa, Note.Final, Note.LastExam FROM Notes AS Note INNER JOIN Teachers AS Teacher ON Note.TeacherChapterId= Teacher.TeacherId INNER JOIN Students AS Student ON Note.StudentLessonId = Student.StudentId INNER JOIN Lessons AS Lesson on Note.StudentLessonId = Lesson.LessonId Inner Join TeacherChapters as TeacherChapter on Note.TeacherChapterId = TeacherChapter.TeacherChapterId INNER JOIN StudentLessons as StudentLesson on Note.StudentLessonId = StudentLesson.StudentLessonId";
            SqlConn sqlConn = new SqlConn();
            Komut komut = new Komut();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(komut.comm(sorgu));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConn.Close();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand DersSil = new SqlCommand("Delete from Notes where NoteId=@noteId", sqlConnection);
            DersSil.Parameters.AddWithValue("@noteId", Convert.ToInt32(NoteId_textBox.Text));
            DersSil.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show(NoteId_textBox.Text + "numarali ders silindi");
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string update = "update Notes set Visa=@visa,Final=@final,LastExam=@lastExam where NoteId=@noteId";
            using (SqlCommand updatecom = new SqlCommand(update, sqlConnection))
            {
                updatecom.Parameters.AddWithValue("@noteId", Convert.ToInt32(NoteId_textBox3.Text));
                updatecom.Parameters.AddWithValue("@visa", Convert.ToDouble(Visa_textBox3.Text));
                updatecom.Parameters.AddWithValue("@final", Convert.ToDouble(Final_textbox3.Text));
                updatecom.Parameters.AddWithValue("@lastExam", Convert.ToDouble(LastExam_textBox3.Text));
                updatecom.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Ogrenci Bilgileri Güncellendi.");

            }
        }
    }
}
