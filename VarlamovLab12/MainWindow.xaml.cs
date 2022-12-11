using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace VarlamovLab12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }


        private void Calculate1(object sender, RoutedEventArgs e)
        {
            Diameter.Focus();
            if (int.TryParse(Diameter.Text, out int D))
            {
                double L, PI = 3.14;
                L = PI * D;
                Length.Text = L.ToString();
            }
            else MessageBox.Show("Введите число");
        }

        private void DiameterChange(object sender, TextChangedEventArgs e)
        {
            Length.Text = null;
        }

        private void Clear1(object sender, RoutedEventArgs e)
        {

            Length.Clear();
            Diameter.Clear();
        }

        private void Calculate2(object sender, RoutedEventArgs e)
        {
            Number.Focus();
            if (int.TryParse(Number.Text, out int Num))
            {

                int a = (Num % 10) * 100;
                int b = Num / 10;
                if (a == 0)
                {
                    ChangeNumber.Text = "0" + b;
                }
                else
                {
                int c = a + b;
                ChangeNumber.Text = c.ToString();
                }
            }
            else MessageBox.Show("Введите число");
        }
        private void NumberChange(object sender, TextChangedEventArgs e)
        {
            ChangeNumber.Text = null;
        }

        private void Clear2(object sender, RoutedEventArgs e)
        {
            Number.Clear();
            ChangeNumber.Clear();
        }

        DispatcherTimer timer;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            time.Text = d.ToString("hh:mm:ss");
            data.Text = d.ToString("dd.MM.yyyy");
        }

        private void AboutProgramm1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дан диаметр окружности D. Найти ее длину L = PI*D. " +
                "\r\nВ качестве значения PI nиспользовать 3.14.");
        }

        private void AboutProgramm2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дано трехзначное число." +
                "\r\nВ нем зачеркнули первую справа цифру и приписали ее слева. " +
                "\r\nВывести полученное число.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
