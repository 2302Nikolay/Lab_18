using System;
using System.Windows;
using System.Windows.Controls;

namespace Lab_18_ind
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Calc_Click(object sender, RoutedEventArgs e) // Обработчик события нажатия на кнопку (она здесь одна)
        {
            try // Блок try-catch нужен на тот случай, если в тактовые поля будут введены не числа, а, например, символы
            {
                // Берем значения из текстовых полей (textBox) и выпадающих списков (comboBox) 
                // и конвертируем их в соответствующий тип (изначально это тип string)
                double p = Convert.ToDouble(TextP.Text);
                double y = Convert.ToDouble(TextY.Text);
                double n = Convert.ToDouble(ComboN.Text);
                double k = Convert.ToDouble(ComboK.Text);
                
                double rez = 0; // Тут будет хранися результат
                
                for (int i = 0; i <= n; i++)
                {
                    for (int j = 0; j <= k; j++)
                    {
                        rez = (Math.Pow((p - 1), i) * Math.Pow(y, j)) / i * j;
                    }
                }
                Label.Content = "Ответ: " + rez.ToString("F"); // Формируем строку и выводим её в 
            }
            catch(Exception ex)
            {
                Label.Content = ex.Message;
            }

        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
