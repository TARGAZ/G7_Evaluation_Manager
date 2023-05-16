using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;

namespace Evaluation_Manager
{
    public partial class FrmLogin : Form
    {
        public static Teacher LoggedInTeacher { get; private set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            LoggedInTeacher = TeacherRepository.GetTeacher(username);
            
            if(LoggedInTeacher!= null && LoggedInTeacher.CheckPassword(password) == true)
            {
                this.Hide();
                FrmStudents frmStudents = new FrmStudents();
                this.Hide();
                frmStudents.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong credentials");
            }
        }
    }
}
