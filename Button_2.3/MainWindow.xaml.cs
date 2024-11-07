using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Button_2._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button button = new Button();
            button.Width = 120;
            button.Height = 40;
            button.Margin = new Thickness(20);
            button.VerticalAlignment = VerticalAlignment.Bottom;
            button.Content = "Кнопка 2";

            button.Background = (Brush)System.ComponentModel.TypeDescriptor.GetConverter(typeof(Brush)).ConvertFromInvariantString("Green");
            //button.Background = new SolidColorBrush(Colors.Green);





            loyout1.Children.Add(button);
        }
    }
}