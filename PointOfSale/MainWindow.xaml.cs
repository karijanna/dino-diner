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
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*Order order = new Order();
            OrderList.DataContext = order;
            OrderInterface.DataContext = order;*/
            Order order = (Order)DataContext;
            order.Items.Add(new Fryceritops());
            order.Items.Add(new Tyrannotea());
            order.Items.Add(new Fryceritops());
            order.Items.Add(new Tyrannotea());
            order.Items.Add(new Fryceritops());
            order.Items.Add(new Tyrannotea());
            order.Items.Add(new Fryceritops());
            order.Items.Add(new Tyrannotea());
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Size = DinoDiner.Menu.Size.Medium;
            order.Items.Add(tea);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OrderInterface_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        public void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            SetFrameDataContext();
        }
        
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            SetFrameDataContext();
        }

        private void SetFrameDataContext()
        {
            FrameworkElement content = OrderInterface.Content as FrameworkElement;
            if (content == null) return;
            content.DataContext = OrderInterface.DataContext;
        }
    }
}
