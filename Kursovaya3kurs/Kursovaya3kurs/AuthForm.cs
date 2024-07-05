using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya3kurs
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthBtn_Click(object sender, EventArgs e)
        {
            string login = LoginTB.Text;
            string password = PasswordTB.Text;
            bool success = false;
            using (ApplicationContext db = new ApplicationContext())
            {
                var account = db.accounts
                    .Where(x => EF.Functions.Collate(x.Login, "Cyrillic_General_CS_AS") == login)
                    .Where(x => EF.Functions.Collate(x.Password, "Cyrillic_General_CS_AS") == password)
                    .ToList();
                if (account.Count != 0)
                {
                    success = true;
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                    PasswordTB.Text = String.Empty;
                }
                if (success)
                {
                    CurrentUser.login = login;
                    CurrentUser.name = account[0].Name;
                    CurrentUser.isAdmin = account[0].IsAdmin;
                    Close();
                }
            }
        }

        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
