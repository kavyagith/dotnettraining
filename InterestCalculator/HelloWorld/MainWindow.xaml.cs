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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Content = "hello world !";
            this.Content = 3.1755555;
            this.Content = DateTime.Now;
            this.Content = new Book()
            {
                Title = "new book",
                Author = "Kavyashree",
                Price = 50
            };

            TextBlock text1 = new TextBlock();
            text1.Text = "hello Kavya";
            this.Content = text1;

        }
    }
}
