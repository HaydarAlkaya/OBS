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
    public partial class TeacherHomePage : Form
    {

        public TeacherHomePage()
        {
            InitializeComponent();
        }

        private void gorevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciListe ogrenciListe = new OgrenciListe();
            ogrenciListe.Show();

        }


        private void devamsızlıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devamsizlik devamsizlik = new Devamsizlik();
            devamsizlik.Show();
        }


        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-BRNH8DO\SQLEXPRESS;Initial Catalog=StudentInformationSystem;Integrated Security=True");
        TeacherLogin teacherLogin = new TeacherLogin();

        private void TeacherHomePage_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string search = "SELECT *FROM Teachers ";
            SqlCommand Com = new SqlCommand(search, sqlConnection);


            SqlDataAdapter da = new SqlDataAdapter(Com);
            SqlDataReader dr = Com.ExecuteReader();
            if (dr.Read())
            {
                    Ad_textBox.Text = dr["Name"].ToString();
                    Soyad_textBox.Text = dr["Lastname"].ToString();
                    TC_TextBox.Text = dr["TC"].ToString();
                    Mail_textBox.Text = dr["Mail"].ToString();
                    DogumTarihi_textBox.Text = dr["Phone"].ToString();

            }
            else
                MessageBox.Show("Ogrenci Bulunamadı.");
            sqlConnection.Close();

        }

        private void dersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherLessons teacherLessons = new TeacherLessons();
            teacherLessons.Show();
        }

        private void nolandırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachersNotes teachersNotes = new TeachersNotes();
            teachersNotes.Show();
        }

        private void dersOnayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseConfirmation courseConfirmation = new CourseConfirmation();
            courseConfirmation.Show();
        }
    }
}
