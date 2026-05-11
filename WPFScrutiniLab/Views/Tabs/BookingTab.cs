using System.Windows.Controls;
using System.Windows;


namespace WPFScrutiniLab.Views.Tabs
{
    public class BookingTab
    {
        StackPanel stackPanelTabItemHeader = new StackPanel();
        Grid gridCentr = new Grid();
        TabControl tabControl = new TabControl();
        TabItem tabItemStart = new TabItem();

        public BookingTab()
        {
            gridCentr = new Grid() { Name = "GridCenter" };
            GridCenter.Children.Add(tabControl);
        }
    }
}
