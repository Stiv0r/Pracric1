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

namespace Practic1Pavishin
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(X.Text);
            double b = double.Parse(A.Text);
            double c = double.Parse(Y.Text);

            double pricePerKg = a / b;

            double totalPrice = pricePerKg * c;

            Answer.Text = ("Стоимость 1 кг конфет: " + pricePerKg);
            Answer_Copy.Text = ("Стоимость " + c + " кг конфет: " + totalPrice);

        }
    }
}


