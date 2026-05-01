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

namespace WPFHostLab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IDateService dateService;
        public MainWindow(IDateService dateService)
        {
            this.dateService = dateService;
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(dateService.FormatedDate);
        }
    }
}