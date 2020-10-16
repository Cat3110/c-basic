using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Udvoitel
{
    public partial class Form1 : Form
    {
        // Храним текущий номер
        private int currentNumber = 0;
        // Храним количество команд
        private int commandCount = 0;
        // Храним требуемый номер
        private int guesNumber;
        // Храним требуемое количество команд
        private int guesCount;
        // Команды для стека
        private enum Commands
        {
            AddOne,
            Double
        };
        // Стек
        private Stack<Commands> CommandsStack = new Stack<Commands>();
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Reset";
            button1.Text = "Cancel";
            lblNumber.Text = currentNumber.ToString();
            lblCommand.Text = commandCount.ToString();
            this.Text = "Doubler";
            CommandsStack.Clear();
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            currentNumber++;
            lblNumber.Text = currentNumber.ToString();
            commandCount++;
            lblCommand.Text = commandCount.ToString();
            checkCondition();
            CommandsStack.Push(Commands.AddOne);
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            currentNumber *= 2;
            lblNumber.Text = currentNumber.ToString();
            commandCount++;
            lblCommand.Text = commandCount.ToString();
            checkCondition();
            CommandsStack.Push(Commands.Double);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            commandCount = 0;
            currentNumber = 0;
            lblNumber.Text = currentNumber.ToString();
            lblCommand.Text = commandCount.ToString();
            CommandsStack.Clear();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameStart();
            MessageBox.Show($"Нужно получить {guesNumber}");
        }
        
        // Запускаем метод для старта игры, он возвращает число, которое нужно получить и оптимальное количество попыток.
        private void gameStart()
        {
            // Получаем число для отгадывания
            var rand = new Random();
            guesNumber = rand.Next(10, 99);
            // Получаем минимальное число для отгадывания через метод 
            guesCount = minimalCount(guesNumber);
            // Инициализируем переменные
            CommandsStack.Clear();
            currentNumber = 0;
            commandCount = 0;
            lblNumber.Text = currentNumber.ToString();
            lblCommand.Text = commandCount.ToString();
        }
        private int minimalCount(int num)
        {
            int count = 0;
            // Если делится на 2 нацело - делим, иначе вычитаем 1
            while (num != 0)
            {
                if (num % 2 == 0)
                    num = num / 2;
                else num--;
                count++;
            }
            return count;
        }
        // Метод для проверки выиграл игрок или проиграл
        private void checkCondition()
        {
            if ((currentNumber == guesNumber) && (commandCount <= guesCount))
                MessageBox.Show("You WIN!\nPress \"play\" to play again");
            else if ((commandCount >= guesCount)  || (currentNumber > guesNumber))
                MessageBox.Show("You LOSE!\nPress \"play\" to play again");
        }

        // Метод для отмены через стек и свич
        private void button1_Click(object sender, EventArgs e)
        {
            switch (CommandsStack.Pop())
            {
                case Commands.AddOne:
                    {
                        currentNumber--;
                        commandCount--;
                        lblNumber.Text = currentNumber.ToString();
                        lblCommand.Text = commandCount.ToString();
                        break;
                    }
                case Commands.Double:
                    {
                        currentNumber = currentNumber / 2;
                        commandCount--;
                        lblNumber.Text = currentNumber.ToString();
                        lblCommand.Text = commandCount.ToString();
                        break;
                    }
            }
        }
    }
}
