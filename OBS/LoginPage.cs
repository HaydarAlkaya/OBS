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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Teacher_Button_Click(object sender, EventArgs e)
        {
            TeacherLogin teacherLogin = new TeacherLogin();
            teacherLogin.Show();
            this.Hide();
        }

        private void Student_Button_Click(object sender, EventArgs e)
        {
            StudentLogin studentLogin = new StudentLogin();
            studentLogin.Show();
            this.Hide();
        }
    }
}
