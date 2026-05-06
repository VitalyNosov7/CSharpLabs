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

namespace WPFScrutiniLab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //TabControl tabControl = new TabControl();
        


        public MainWindow()
        {
            InitializeComponent();
            //AddTabItem();
        }

		private void AddTabItem(object sender, RoutedEventArgs e)
		{
            TabItem tabItem = new TabItem();
            StackPanel stackPanel = new StackPanel();
            Ellipse ellipse = new Ellipse() { Height = 10, Width=10, Fill=Brushes.Black };
            TextBlock textBlock = new TextBlock() { Margin = new Thickness(3), Text = "Программный Таб"} ;

            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Children.Add(ellipse);
            stackPanel.Children.Add(textBlock);

            tabItem.Header = stackPanel;

            tabControl.Items.Add(tabItem);
            tabItem.IsSelected = true;
        }

		private void DelTabItem(object sender, RoutedEventArgs e)
		{
            //products.Items.RemoveAt(products.SelectedIndex);

            TabItem current = (TabItem)tabControl.SelectedItem;
            current.Visibility = Visibility.Collapsed;  
        }
	}
}