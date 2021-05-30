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
    public partial class StudentLesson : Form
    {
        public StudentLesson()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "SELECT Note.NoteId,StudentLesson.StudentLessonId,TeacherChapter.TeacherChapterId,Student.NameLastname,Student.Number,Teacher.Name,Teacher.Lastname,Lesson.LessonName,Lesson.LessonCode,Note.Visa, Note.Final, Note.LastExam FROM Notes AS Note INNER JOIN Teachers AS Teacher ON Note.TeacherChapterId= Teacher.TeacherId INNER JOIN Students AS Student ON Note.StudentLessonId = Student.StudentId INNER JOIN Lessons AS Lesson on Note.StudentLessonId = Lesson.LessonId Inner Join TeacherChapters as TeacherChapter on Note.TeacherChapterId = TeacherChapter.TeacherChapterId INNER JOIN StudentLessons as StudentLesson on Note.StudentLessonId = StudentLesson.StudentLessonId WHERE Number LIKE '%"+textBox1.Text+"%'";

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
