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

namespace ColorPreview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HandleColorPreview(object sender, RoutedEventArgs e)
        {
            ColorPreview();
        }

        private void ColorPreview()
        {
            try
            {
                var color = colorTextBox.Text.ToString();
                var bc = new BrushConverter();
                previewBlock.Background = (Brush)bc.ConvertFrom(color);
            }
            catch
            {
                previewBlock.Background = Brushes.White;
            }
        }
       
        private void AutoChecked(object sender, RoutedEventArgs e)
        {
            applyButton.IsEnabled = !checkbox.IsChecked.Value;
        }

        private void ColorTextChanged(object sender, TextChangedEventArgs e)
        {
            if(checkbox.IsChecked.Value)
            {
                ColorPreview();
            }
        }
    }
}
