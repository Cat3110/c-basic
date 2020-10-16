using System;
using System.Windows.Forms;

namespace Ex_2
{
    public partial class Form1 : Form
    {
        // Переменная для второй формы
        Form2 answerForm;
        // Переменная для загаданного числа
        private int number;
        // Переменная для подсчета количества попыток
        private int count;
        public Form1()
        {
            InitializeComponent();
            StartGame();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            // Инициализируем переменные
            var rnd = new Random();
            number = rnd.Next(1, 100);
            count = 10;
            lblComputerAnswer.Text = "Я загадал число";
            lblTryCount.Text = count.ToString();
            // Показываем вторую форму
            answerForm = new Form2();
            answerForm.Show();
            answerForm.MyDelegateEvent += GetAnswer;
        }
        private void UpdateGame()
        {
            lblTryCount.Text = count.ToString();
        }

        private void GetAnswer(int n)
        {
            count--;
            if (n == number)
            {
                lblComputerAnswer.Text = "Вы угадали мое число!";
                answerForm.Close();
            }
            else if (count == 0)
            {
                lblComputerAnswer.Text = "Вы проиграли! \n Мое число " + number.ToString();
                answerForm.Close();
            }
            else if (n < number)
                lblComputerAnswer.Text = "Мое число больше!";
            else
                lblComputerAnswer.Text = "Мое число меньше!";
            UpdateGame();
        }
    }
}
