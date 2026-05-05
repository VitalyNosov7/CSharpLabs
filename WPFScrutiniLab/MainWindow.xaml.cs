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
        TabControl tabControl = new TabControl();
        


        public MainWindow()
        {
            InitializeComponent();

            
            
            GridCenter.Children.Add(tabControl);

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

		private void AddTabItem(object sender, RoutedEventArgs e)
		{
            // формируем содержимое вкладки в виде списка
            //ListBox notesList = new ListBox();
            //notesList.Items.Add("Macbook Pro");
            //notesList.Items.Add("HP Pavilion 5478");
            //notesList.Items.Add("Acer LK-08");
            // добавление вкладки

            //products.Items.Add(new TabItem
            //{
            //    Header = new TextBlock { Text = "Ноутбуки" }, // установка заголовка вкладки
            //    Content = notesList // установка содержимого вкладки
            //});
            TabItem tabItem = new TabItem();
            tabItem.Header = "Мой ТАБ";
            tabControl.Items.Add(tabItem);
            //tabItem.Header = "Мой ТАБ";

        }

		private void DelTabItem(object sender, RoutedEventArgs e)
		{
            //products.Items.RemoveAt(products.SelectedIndex);

            TabItem current = (TabItem)tabControl.SelectedItem;
            current.Visibility = Visibility.Collapsed;
       

            // tabControl.Items.Remove(tabControl.SelectedItem);



        }
	}
}