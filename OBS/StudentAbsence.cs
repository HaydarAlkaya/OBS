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
    public partial class StudentAbsence : Form
    {
        public StudentAbsence()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "Select Student.NameLastname,Student.Number,Lesson.LessonName,Absence.Absence,Absence.Date FROM Students AS Student INNER JOIN StudentLessons as StudentLesson ON Student.StudentId = StudentLesson.StudentLessonId INNER JOIN Absences as Absence on StudentLesson.StudentLessonId = Absence.StudentLessonsId INNER JOIN Lessons as Lesson on StudentLesson.LessonId = Lesson.LessonId  WHERE Number LIKE '%" + Number_textBox.Text + "%'";

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
