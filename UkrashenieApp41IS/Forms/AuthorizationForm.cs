using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UkrashenieApp41IS.Forms;
using UkrashenieApp41IS.ModelEF;
using UkrashenieApp41IS.Utils;

namespace UkrashenieApp41IS
{
    public partial class AuthorizationForm : Form
    {
        public static User staticUser { get; set; }
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if(DbConnect.db.User.Any(a => a.UserLogin == loginTextBox.Text && a.UserPassword == passwordTextBox.Text))
            {
                User usr = DbConnect.db.User.First(x => x.UserLogin == loginTextBox.Text);
                switch (usr.UserRole)
                {
                    case 1:
                        MainForm mf = new MainForm();
                        staticUser = usr;
                        mf.Show();
                        this.Hide();
                        break;
                    case 2:
                        MainForm mf2 = new MainForm();
                        staticUser = usr;
                        mf2.Show();
                        this.Hide();
                        break;
                    case 3:
                        MainForm mf3 = new MainForm();
                        staticUser = usr;
                        mf3.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}