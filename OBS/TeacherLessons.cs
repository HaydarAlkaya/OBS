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
    public partial class TeacherLessons : Form
    {
        public TeacherLessons()
        {
            InitializeComponent();
        }

        private void TeacherNotes_Load(object sender, EventArgs e)
        {
            string sorgu = "SELECT Lesson.LessonId,Academic.AcademicUnitName,Faculty.FacultyName,Chapter.ChapterName,Lesson.LessonName,Lesson.LessonCode,Lesson.Credit,Lesson.AKTS,Lesson.Period FROM AcademicUnits AS Academic INNER JOIN Faculties AS Faculty ON Academic.AcademicUnitId = Faculty.AcademicUnitId INNER JOIN Chapters AS Chapter ON Faculty.FacultyId = Chapter.FacultyId INNER JOIN Lessons AS Lesson ON Chapter.FacultyId = Lesson.ChapterId";
            SqlConn sqlConn = new SqlConn();
            Komut komut = new Komut();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(komut.comm(sorgu));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConn.Close();
            ChapterGet();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-BRNH8DO\SQLEXPRESS;Initial Catalog=StudentInformationSystem;Integrated Security=True");


        void ChapterGet()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT *FROM Chapters", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            int counter = 2;
            while (sqlDataReader.Read())
            {
                Chapter_comboBox.Items.Add(sqlDataReader["ChapterName"].ToString());
                counter++;
            }
            sqlConnection.Close();
        }


        private void Ad_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    string AddSorgu = "INSERT INTO Lessons(ChapterId,LessonName,Credit,AKTS,LessonCode,Period) VALUES (@Chapter,@Name,@credit,@akts,@Code,@period)";

                    SqlCommand com = new SqlCommand(AddSorgu, sqlConnection);
                    int item = Convert.ToInt32(Chapter_comboBox.SelectedIndex);
                    com.Parameters.AddWithValue("@Chapter", item += 1);
                    com.Parameters.AddWithValue("@Name", LessonName_textBox.Text);
                    com.Parameters.AddWithValue("@Code", LessonCode_textBox.Text);
                    com.Parameters.AddWithValue("@credit", Convert.ToInt32(Credit_textBox.Text));
                    com.Parameters.AddWithValue("@akts", Convert.ToInt32(AKTS_textBox.Text));
                    com.Parameters.AddWithValue("@period", Convert.ToInt32(Period_textBox.Text));
                    com.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Ogrenci Devamsizlik Kayıt İşlemi Gerçekleşti.");
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("Beklenmeyen bir hata olustu.\n" + error);
            }
            sqlConnection.Close();

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {


            sqlConnection.Open();
            SqlCommand DersSil = new SqlCommand("Delete from Lessons where LessonId=@lessonId", sqlConnection);
            DersSil.Parameters.AddWithValue("@lessonId", Convert.ToInt32(LessonId_textBox.Text));
            DersSil.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show(LessonName_textBox.Text + "  adli ders silindi");
        }

        private void Reflesh_Button_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT Lesson.LessonId,Academic.AcademicUnitName,Faculty.FacultyName,Chapter.ChapterName,Lesson.LessonName,Lesson.LessonCode,Lesson.Credit,Lesson.AKTS,Lesson.Period FROM AcademicUnits AS Academic INNER JOIN Faculties AS Faculty ON Academic.AcademicUnitId = Faculty.AcademicUnitId INNER JOIN Chapters AS Chapter ON Faculty.FacultyId = Chapter.FacultyId INNER JOIN Lessons AS Lesson ON Chapter.FacultyId = Lesson.ChapterId";
            SqlConn sqlConn = new SqlConn();
            Komut komut = new Komut();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(komut.comm(sorgu));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConn.Close();

        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                string update = "update Lessons set LessonId=@lessonId,LessonName=@lessonName,Credit=@credit,AKTS=@akts,LessonCode=@lessonCode,Period=@period ";
                SqlCommand updatecom = new SqlCommand(update, sqlConnection);
                updatecom.Parameters.AddWithValue("@lessonId", Convert.ToInt32(DersId_textBox.Text));
                updatecom.Parameters.AddWithValue("@lessonName", DersAd_textBox.Text);
                updatecom.Parameters.AddWithValue("@credit", Convert.ToInt32(Credit_textBox.Text));
                updatecom.Parameters.AddWithValue("@akts", Convert.ToInt32(AKTS_textBox.Text));
                updatecom.Parameters.AddWithValue("@lessonCode", DersKod_textbox.Text);
                updatecom.Parameters.AddWithValue("@period", Convert.ToInt32(Period_textBox.Text));
                updatecom.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Ders Bilgileri Güncellendi.");


            }
            catch (Exception error)
            {

                MessageBox.Show("hata mesaji :::::::\n" + error);
            }
        }
    }
}
