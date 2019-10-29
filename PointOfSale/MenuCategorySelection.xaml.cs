/* MenuCategorySelection.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        /// <summary>
        /// Constructor for menu caterogry selection class
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Navigates user to the combo selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCombo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComboSelection());
        }
        /// <summary>
        /// Navigates user to the side selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }
        /// <summary>
        /// Navigates user to the drink selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Navigates user to the entree selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectEntree(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EntreeSelection());
        }
    }
}
