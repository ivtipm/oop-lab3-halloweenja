using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot
{
    public partial class LoginForm : Form
    {
        Point newPoint;
        public LoginForm()
        {
            InitializeComponent();

            LoginText.Text = "Имя";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void labelClose_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            newPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - newPoint.X;
                this.Top += e.Y - newPoint.Y;
            }
        }

        private void buttLogin_MouseUp(object sender, MouseEventArgs e)
        {
            {
                // удаляем из входящей строки пробелы и если остаётся пустая строка выдаём ошибку
                if (LoginText.Text.Trim() != "")
                {
                    MainForm frm = new MainForm();
                    MainForm.bot.LoadHistory(LoginText.Text); // загружаем историю сообщений
                    frm.Show();
                    frm.RestoreChat(); // восстанавливаем диалог
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ошибка! Введите своё имя.");
                    LoginText.Text = "Имя";
                }
                    
            }
        }

        private void labelClose_MouseDown_1(object sender, MouseEventArgs e)
        {
            labelClose.BackColor = Color.FromArgb(42, 48, 60);
        }

        private void LoginText_Enter(object sender, EventArgs e)
        {
            if (LoginText.Text == "Имя")
                LoginText.Text = "";
        }

        private void LoginText_Leave(object sender, EventArgs e)
        {
            if (LoginText.Text == "")
                LoginText.Text = "Имя";
        }

        private void buttLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (LoginText.Text == "Имя")
                LoginText.Text = "";
        }
    }
}
