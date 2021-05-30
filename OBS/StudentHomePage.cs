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
    public partial class StudentHomePage : Form
    {
        
        public StudentHomePage()
        {
            InitializeComponent();
        }
        

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentHomePage studentHomePage = new StudentHomePage();
            studentHomePage.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentHomePage studentHomePage = new StudentHomePage();
            studentHomePage.Close();
        }

        private void devamsizlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentAbsence studentAbsence = new StudentAbsence();
            studentAbsence.Show();
        }

        

        private void notToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentLesson studentLesson = new StudentLesson();
            studentLesson.Show();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP - BRNH8DO\SQLEXPRESS; Initial Catalog = StudentInformationSystem; Integrated Security = True");

        private void Number_textBox_TextChanged(object sender, EventArgs e)
        {

            string sorgu = "SELECT *FROM Students WHERE Number LIKE '%" + Number_textBox.Text + "%'";

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
