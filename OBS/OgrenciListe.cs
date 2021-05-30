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

namespace OBS
{
    public partial class OgrenciListe : Form
    {
        public OgrenciListe()
        {
            InitializeComponent();
        }
        Komut komut = new Komut();
        SqlConn sqlConn = new SqlConn();
        SqlCommand com = new SqlCommand();


        internal void OgrenciListe_Load(object sender, EventArgs e)
        {


            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(komut.comm("Select *From Students"));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConn.Close();

        }
        static string conString = @"Server=DESKTOP-BRNH8DO\SQLEXPRESS;Initial Catalog=StudentInformationSystem;Integrated Security=True;";
        SqlConnection sqlConnection = new SqlConnection(conString);
        Security security = new Security();

        private void Add_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    string kayit = "INSERT INTO Students (NameLastname,Number,Password,TC,Mail,Phone) values (@nameLastname,@number,@password,@TC,@mail,@phone)";
                    SqlCommand com = new SqlCommand(kayit, sqlConnection);
                    com.Parameters.AddWithValue("@nameLastname", NameLastname_textBox.Text);
                    com.Parameters.AddWithValue("@number", Number_textBox.Text);
                    com.Parameters.AddWithValue("@password", security.Guvenlik(Password_textBox.Text));
                    com.Parameters.AddWithValue("@TC", TC_textBox.Text);
                    com.Parameters.AddWithValue("@mail", Mail_textBox.Text);
                    com.Parameters.AddWithValue("@phone", Phone_textBox.Text);
                    com.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Ogrenci Kayıt İşlemi Gerçekleşti.");

                }

            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmeyen bir hata olustu." + hata.Message);
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                string delete = "SELECT *FROM Students WHERE Number=@number";
                SqlCommand deletecom = new SqlCommand(delete, sqlConnection);
                deletecom.Parameters.AddWithValue("@number", Number_textBox.Text);
                SqlDataAdapter da = new SqlDataAdapter(deletecom);
                SqlDataReader dr = deletecom.ExecuteReader();

                if (dr.Read())
                {

                    string number = dr["Number"].ToString();
                    DialogResult durum = MessageBox.Show(number + " numarali ogrencinin kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                    dr.Close();
                    if (DialogResult.Yes == durum)
                    {

                        string silmeSorgusu = "DELETE from Students where Number=@number";
                        using (SqlCommand deleteCommand = new SqlCommand(silmeSorgusu, sqlConnection))
                        {
                            deleteCommand.Parameters.AddWithValue("@number", Number_textBox.Text);
                            deleteCommand.ExecuteNonQuery();
                            MessageBox.Show("Kayıt Silindi...");
                        }
                    }
                    else
                        MessageBox.Show("Ogrenci Bulunamadı.");
                    sqlConnection.Close();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata ile karsilasildi.\n");
            }

        }
        private void Ara_Button_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string search = "SELECT *FROM Students WHERE Number=@number";
            using (SqlCommand searchCom = new SqlCommand(search, sqlConnection))
            {
                searchCom.Parameters.AddWithValue("@number", Number_textBox.Text);
                SqlDataAdapter da = new SqlDataAdapter(searchCom);
                SqlDataReader dr = searchCom.ExecuteReader();
                if (dr.Read())
                {
                    NameLastname_Label.Text = dr["NameLastname"].ToString();
                    Number_Label.Text = dr["Number"].ToString();
                    Pass_Label.Text = dr["Password"].ToString();
                    TC_Label.Text = dr["TC"].ToString();
                    Mail_Label.Text = dr["Mail"].ToString();
                    Phone_Label.Text = dr["Phone"].ToString();
                    if (NameLastname_Label.Visible == false)
                    {
                        NameLastname_Label.Visible = true;
                        Number_Label.Visible = true;
                        Pass_Label.Visible = true;
                        TC_Label.Visible = true;
                        Mail_Label.Visible = true;
                        Phone_Label.Visible = true;
                        tableLayoutPanel1.Visible = true;
                    }
                }
                else
                    MessageBox.Show("Ogrenci Bulunamadı.");
                sqlConnection.Close();

            }

        }
        private void Update_Button_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string update = "update Students set NameLastname=@nameLastname,Password=@Pass,Mail=@mail,Phone=@phone";
            using (SqlCommand updatecom = new SqlCommand(update, sqlConnection))
            {
                updatecom.Parameters.AddWithValue("@nameLastname", NameLastname_textBox.Text);
                updatecom.Parameters.AddWithValue("@Pass", security.Guvenlik(Password_textBox.Text));
                updatecom.Parameters.AddWithValue("@mail", Mail_textBox.Text);
                updatecom.Parameters.AddWithValue("@phone", Phone_textBox.Text);
                updatecom.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Ogrenci Bilgileri Güncellendi.");

            }
        }
        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(komut.comm("Select *From Students"));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConn.Close();
        }

    }
}
