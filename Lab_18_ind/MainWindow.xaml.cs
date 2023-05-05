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
        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            double p = Convert.ToDouble(TextP.Text);
            double f = Convert.ToDouble(TextF.Text);
            double x = Convert.ToDouble(TextX.Text);
            double y = Convert.ToDouble(TextY.Text);
            double n = Convert.ToDouble(ComboN.Text);
            double k = Convert.ToDouble(ComboK.Text); 

            double rez = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    rez = (Math.Pow(p, i) * Math.Pow(x, 3) * Math.Pow(f, j) * Math.Pow(y, 2)) / (i * j);
                }
            }
            Label.Content = "Ответ: " + rez.ToString("F");

        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
