using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using static System.Math;

namespace Practic1Pavishin
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x1 = double.Parse(x1TextBox.Text);
            double y1 = double.Parse(y1TextBox.Text);
            double x2 = double.Parse(x2TextBox.Text);
            double y2 = double.Parse(y2TextBox.Text);

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            resultLabel.Content = $"Расстояние между точками ({x1},{y1}) и ({x2},{y2}) равно {distance}";
        }
    }
}
