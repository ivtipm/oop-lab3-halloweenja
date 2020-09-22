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
    public partial class MainForm : Form
    {
        Point newPoint;

        static public ChatBot bot = new ChatBot();
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, восстанавливающий историю сообщений в TextBox
        /// </summary>
        public void RestoreChat()
        {
            for (int i = 0; i < bot.History.Count; i++)
                ChatText.Text += bot.History[i] + Environment.NewLine;
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

        private void labelClose_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void labelClose_MouseDown(object sender, MouseEventArgs e)
        {
            labelClose.BackColor = Color.FromArgb(42, 48, 60);
        }

        private void SendButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (SendText.Text.Trim() != "")
            {
                String[] userQuestion = SendText.Text.Split(new String[] { "\r\n" },
                    StringSplitOptions.RemoveEmptyEntries);

                string message = userQuestion[0]; // для отправки боту

                userQuestion[0] = userQuestion[0].Insert(0,
                    "[" + DateTime.Now.ToString("HH:mm") + "] " + bot.UserName + ": ");

                bot.AddToHistory(userQuestion); // добавляем вопрос в файл

                ChatText.AppendText(userQuestion[0] + "\r\n");
                SendText.Text = ""; // очищаем поле отправки

                string[] botAnswer = new string[] { bot.Answer(message) };
                botAnswer[0] = botAnswer[0].Insert(0,
                    "[" + DateTime.Now.ToString("HH:mm") + "] Бот: ");

                ChatText.AppendText(botAnswer[0] + Environment.NewLine);

                bot.AddToHistory(botAnswer); // добавляем ответ бота в файл
            }
        }

        /// <summary>
        /// Обновление текста и перевод каретки в конец
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChatText_TextChanged_1(object sender, EventArgs e)
        {
            ChatText.SelectionStart = ChatText.Text.Length;
            ChatText.ScrollToCaret();
            ChatText.Refresh();
        }

    }
}
