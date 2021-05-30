using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }
        public string txt;

        Security security = new Security();
        Komut komut = new Komut();
        
        public void Login_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Kullanici_TextBox.Text))
            {
                MessageBox.Show("Kullanıcı bilgisini boş geçemezsiniz.");
                Kullanici_TextBox.SelectAll();
                Kullanici_TextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Sifre_TextBox.Text))
            {
                MessageBox.Show("Parola bilgisini boş geçemezsiniz.");
                Sifre_TextBox.SelectAll();
                Sifre_TextBox.Focus();
                return;
            }
            string pass= security.Guvenlik(Sifre_TextBox.Text);
            bool result = komut.Dogrulama("SELECT *FROM Students WHERE Number= '"+Kullanici_TextBox.Text+"'and Password='"+pass+"'");
            if (result)
            {
                
                StudentHomePage studentHomePage = new StudentHomePage();
                studentHomePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanici adi veya sifre hatali.");
                Kullanici_TextBox.Clear();
                Sifre_TextBox.Clear();
                Kullanici_TextBox.Focus();

            }
            

        }

        private void SifreGoster_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SifreGoster_CheckBox.Checked)
            {
                //karakteri göster.
                Sifre_TextBox.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                Sifre_TextBox.PasswordChar = '*';
            }
        }
        
       
        

    }
}
