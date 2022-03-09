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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _4_Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rate_dollar = Convert.ToDouble(rate_d.Text);
            double sum_dollar = Convert.ToDouble(sum_d.Text);
            double result = rate_dollar * sum_dollar;
            ressum_d.Text = result.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rate_dollar = Convert.ToDouble(rate_e.Text);
            double sum_dollar = Convert.ToDouble(sum_e.Text);
            double result = rate_dollar * sum_dollar;
            ressum_e.Text = result.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rate_dollar = Convert.ToDouble(rate_g.Text);
            double sum_dollar = Convert.ToDouble(sum_g.Text);
            double result = rate_dollar * sum_dollar;
            ressum_g.Text = result.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rate_dollar = Convert.ToDouble(rate_a.Text);
            double sum_dollar = Convert.ToDouble(sum_a.Text);
            double result = rate_dollar * sum_dollar;
            ressum_a.Text = result.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double enter_inches = Convert.ToDouble(inches.Text);            
            double result = enter_inches * 0.0254;
            res_i.Text = result.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double enter_feet = Convert.ToDouble(feet.Text);
            double result = enter_feet * 0.3048;
            res_f.Text = result.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double enter_miles = Convert.ToDouble(miles.Text);
            double result = enter_miles * 1609.344;
            res_m.Text = result.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double enter_versts = Convert.ToDouble(versts.Text);
            double result = enter_versts * 1066.8;
            res_v.Text = result.ToString();
        }
    }
}
