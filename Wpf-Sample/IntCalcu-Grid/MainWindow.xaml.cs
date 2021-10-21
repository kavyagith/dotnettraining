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

namespace IntCalcu_Grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            statusBar.Content = "Ready";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //interest = principal * rate * period / 1200
            var interest = double.Parse(principalTextBox.Text) * double.Parse(rateTextBox.Text) * double.Parse(periodTextBox.Text) / 1200;
            //MessageBox.Show(interest.ToString(),"interest is:");
            var amount = double.Parse(principalTextBox.Text) + interest;
            interestTextBox.Text = interest.ToString();
            amountTextBox.Text = amount.ToString();
            statusBar.Content = "Done";
        }
    }
}
