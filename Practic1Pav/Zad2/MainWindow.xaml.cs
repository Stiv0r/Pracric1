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
            int a = int.Parse(vvod.Text);
            double x1 = 1.0;
            double y1 = 2.0;
            double x2 = 4.0;
            double y2 = 6.0;

            double distance = Sqrt(Pow(x2 - x1, 2) + Pow(y2 - y1, 2));

            otvet.Text = ("Расстояние между точками: " + distance);
        }
    }
}
