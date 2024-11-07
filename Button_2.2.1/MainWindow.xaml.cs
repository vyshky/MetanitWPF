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

namespace Button_2._2._1
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
            button.Width = 150;
            button.Height = 30;
            button.Content = "Кнопка";
            button.Name = "Button1";

            TextBox textBox = new TextBox();
            textBox.Width = 150;
            textBox.Height = 30;
            textBox.VerticalAlignment = VerticalAlignment.Top;
            textBox.HorizontalAlignment = HorizontalAlignment.Left;
            loyoutGrid.Children.Add(button);
            loyoutGrid.Children.Add(textBox);
        }

    }
}