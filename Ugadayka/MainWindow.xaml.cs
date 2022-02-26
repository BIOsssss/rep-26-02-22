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

namespace Ugadayka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random ran = new Random();
        public MainWindow()
        {
            InitializeComponent();
            rnd = ran.Next(1, 100);

        }

        int rnd;
        int numb;

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Random ran = new Random();
            lstResult.Items.Clear();
            txtNumb.Text = "";
            rnd = ran.Next(1, 100);
        }

        private void txtNumb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(int.TryParse(txtNumb.Text, out numb))
            {

            }
            else
            {
                txtNumb.Text = "";
                return;
            }
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                if (numb < 0 || numb > 100)
                {
                    lstResult.Items.Add("Необходимо вводить число от 1 до 100");
                    txtNumb.Text = "";
                    return;
                }
                else
                {

                }
                btnOK.IsEnabled = true;
                if (numb < rnd)
                {
                    lstResult.Items.Add($"x > {numb} - недобор :(");
                }
                else if (numb > rnd)
                {
                    lstResult.Items.Add($"x < {numb} - перебор :(");
                }
                else if (numb == rnd)
                {
                    lstResult.Items.Add($"x = {numb} - УРА!!! Угадано! :)");
                }
                else
                {

                }
            }
        }
    }
}
