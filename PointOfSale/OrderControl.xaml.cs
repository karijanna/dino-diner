/* OrderControl.xaml.cs
 * Author: Karijanna Miller
 */

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
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for UserControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Gets and sets the navigation to certain pages
        /// </summary>
        public NavigationService NavigationService {get; set;}
        /// <summary>
        /// Constructor for order control class
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Navigates to the side selection when side is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if (OrderItems.SelectedItem is Side side)
            {

                NavigationService?.Navigate(new SideSelection(side));
            }
        }
        /// <summary>
        /// Removes an order item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ars"></param>
        private void OnRemoveItem(object sender, RoutedEventArgs ars)
        {
            if(DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if(element.DataContext is IOrderItem item)
                    order.Remove(item);
                }
            }
            //OrderItems.SelectedItem;
        }
    }
}
