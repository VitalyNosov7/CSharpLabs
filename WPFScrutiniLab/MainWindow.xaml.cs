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
        public MainWindow()
        {
            InitializeComponent();



            #region Пример добавления табов в C#

            //// формируем содержимое вкладки в виде списка
            //ListBox notesList = new ListBox();
            //notesList.Items.Add("Macbook Pro");
            //notesList.Items.Add("HP Pavilion 5478");
            //notesList.Items.Add("Acer LK-08");
            //// добавление вкладки
            
            //products.Items.Add(new TabItem
            //{
            //    Header = new TextBlock { Text = "Ноутбуки" }, // установка заголовка вкладки
            //    Content = notesList // установка содержимого вкладки
            //});

            #endregion Пример добавления табов в C#
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			// формируем содержимое вкладки в виде списка
			ListBox notesList = new ListBox();
			notesList.Items.Add("Macbook Pro");
			notesList.Items.Add("HP Pavilion 5478");
			notesList.Items.Add("Acer LK-08");
            // добавление вкладки

            products.Items.Add(new TabItem
            {
                Header = new TextBlock { Text = "Ноутбуки" }, // установка заголовка вкладки
                Content = notesList // установка содержимого вкладки
            });
        }

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			products.Items.RemoveAt(products.SelectedIndex);

			TabItem current = (TabItem)products.SelectedItem;    

		//	current.Visibility = Visibility.Collapsed;
		}
	}
}