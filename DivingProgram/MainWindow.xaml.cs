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

namespace DivingProgram
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
        
        private void Register(object sender, RoutedEventArgs e)
        {
            Window register = new RegisterWindow();
            register.Show();
        }

        private void BtnCloseProgrem(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnLogin(object sender, RoutedEventArgs e)
        {
            
        }
    }
}