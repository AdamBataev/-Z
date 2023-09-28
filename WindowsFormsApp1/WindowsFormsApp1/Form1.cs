using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // считываем введенный пользователем массив чисел
            string[] inputArray = textBoxArray.Text.Split(' ');

            // инициализируем переменные
            int sum = 0;
            int product = 1;

            // ищем минимальный и максимальный элементы
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                int currentValue = int.Parse(inputArray[i]);
                if (currentValue < int.Parse(inputArray[minIndex]))
                {
                    minIndex = i;
                }
                if (currentValue > int.Parse(inputArray[maxIndex]))
                {
                    maxIndex = i;
                }

                // суммируем положительные элементы
                if (currentValue > 0)
                {
                    sum += currentValue;
                }
            }

            // вычисляем произведение чисел между минимальным и максимальным элементами
            int startIndex = Math.Min(minIndex, maxIndex) + 1;
            int endIndex = Math.Max(minIndex, maxIndex);
            for (int i = startIndex; i < endIndex; i++)
            {
                product *= int.Parse(inputArray[i]);
            }

            // выводим результаты
            labelSumResult.Text = sum.ToString();
            labelProductResult.Text = product.ToString();
        }
    }
}
