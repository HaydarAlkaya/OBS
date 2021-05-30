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
    public partial class Devamsizlik : Form
    {
        public Devamsizlik()
        {
            InitializeComponent();
        }
        string sorgu = "Select Absence.AbsencesId,Absence.StudentLessonsId,Student.NameLastname,Student.Number,Lesson.LessonName,Absence.Absence,Absence.Date FROM Students AS Student INNER JOIN StudentLessons as StudentLesson ON Student.StudentId = StudentLesson.StudentLessonId INNER JOIN Absences as Absence on StudentLesson.StudentLessonId = Absence.StudentLessonsId INNER JOIN Lessons as Lesson on StudentLesson.LessonId = Lesson.LessonId ";

        private void Devamsizlik_Load(object sender, EventArgs e)
        {
            SqlConn sqlConn = new SqlConn();
            Komut komut = new Komut();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(komut.comm(sorgu));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConn.Close();
        }
        static string conString = @"Server=DESKTOP-BRNH8DO\SQLEXPRESS;Initial Catalog=StudentInformationSystem;Integrated Security=True;";
        SqlConnection sqlConnection = new SqlConnection(conString);
        private void Add_Button_Click(object sender, EventArgs e)
        {

            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    string AddSorgu = "Select StudentLessonId, Student.NameLastname,Student.Number,Lesson.LessonName,Absence.Absence,Absence.Date FROM Students AS Student INNER JOIN StudentLessons as StudentLesson ON Student.StudentId = StudentLesson.StudentLessonId INNER JOIN Absences as Absence on StudentLesson.StudentLessonId = Absence.StudentLessonsId INNER JOIN Lessons as Lesson on StudentLesson.LessonId = Lesson.LessonId INSERT INTO Absences (StudentLessonId,Absence) values (@studentlessonid,@absence)";
                    SqlCommand com = new SqlCommand(AddSorgu, sqlConnection);
                    foreach (DataGridViewRow dataGridViewRow in dataGridView1.SelectedRows)
                    {
                        int id = Convert.ToInt32(dataGridViewRow.Cells[0].Value);
                        com.Parameters.AddWithValue("@studentlessonid", id);
                    }
                    com.Parameters.AddWithValue("@absence", Devamsizlik_Textbox.Text);
                    com.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Ogrenci Devamsizlik Kayıt İşlemi Gerçekleşti.");
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("Beklenmeyen bir hata olustu." + error.Message);
            }

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            
            try
            {
                sqlConnection.Open();
                string delete = "SELECT *FROM Absences ";
                SqlCommand deletecom = new SqlCommand(delete, sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter(deletecom);
                SqlDataReader dr = deletecom.ExecuteReader();

                if (dr.Read())
                {                    
                    string number = Convert.ToString(AbsencesID_Textbox.Text);
                    DialogResult durum = MessageBox.Show(number + " numarali satirin kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                    dr.Close();
                    if (DialogResult.Yes == durum)
                    {
                        string silmeSorgusu = "DELETE from Absences where AbsencesId=@absencesid";
                        SqlCommand deleteCommand = new SqlCommand(silmeSorgusu, sqlConnection);
                        deleteCommand.Parameters.AddWithValue("@absencesid", Convert.ToInt32(AbsencesID_Textbox.Text));
                        deleteCommand.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Silindi...");
                        
                    }
                    else
                        MessageBox.Show("Ogrenci Bulunamadı.");
                    sqlConnection.Close();
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmeyen bir hata ile karsilastik"+hata);
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {

            sqlConnection.Open();
            SqlCommand sql = new SqlCommand("SELECT *FROM Absences  ", sqlConnection);
            SqlDataReader dr = sql.ExecuteReader();

            if (dr.Read())
            {
                dr.Close();
                string update = "update Absences set Absence=@absence where AbsencesId = @absenceId";
                SqlCommand updatecom = new SqlCommand(update, sqlConnection);
                updatecom.Parameters.AddWithValue("@absence", Convert.ToDouble(Devamsizlik_Textbox.Text));
                updatecom.Parameters.AddWithValue("@absenceId", Convert.ToInt32(AbsencesID_Textbox.Text));
                updatecom.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Ogrenci Bilgileri Güncellendi.");
                sqlConnection.Close();
            }



        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
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
