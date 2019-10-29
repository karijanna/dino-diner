/* FlavorSelection.xaml.cs
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
using DinoDiner.Menu.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// Gets and sets the drink menu item
        /// </summary>
        public Drink Drink { get; set; }
        /// <summary>
        /// Constructor for flavor selection class
        /// </summary>
        /// <param name="drink">The drink item selected in order</param>
        public FlavorSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink;
        }
        /// <summary>
        /// Changes flvor to cherry when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCherry(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus soda)
            {
                soda.ChangeFlavor(SodasaurusFlavor.Cherry);
            }
            NavigationService.GoBack();
        }
        /// <summary>
        /// Changes flavor to orange when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectOrange(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus soda)
            {
                soda.ChangeFlavor(SodasaurusFlavor.Orange);
            }
            NavigationService.GoBack();
        }
        /// <summary>
        /// Changes flavor to chocolate when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectChocolate(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus soda)
            {
                soda.ChangeFlavor(SodasaurusFlavor.Chocolate);
            }
            NavigationService.GoBack();
        }
        /// <summary>
        /// Changes flavor to root beer when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectRootBeer(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus soda)
            {
                soda.ChangeFlavor(SodasaurusFlavor.RootBeer);
            }
            NavigationService.GoBack();
        }
        /// <summary>
        /// Changes flavor to cola when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCola(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus soda)
            {
                soda.ChangeFlavor(SodasaurusFlavor.Cola);
            }
            NavigationService.GoBack();
        }
        /// <summary>
        /// Changes flavor to lime when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectLime(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus soda)
            {
                soda.ChangeFlavor(SodasaurusFlavor.Lime);
            }
            NavigationService.GoBack();
        }
        /// <summary>
        /// Changes flavor to vanilla when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectVanilla(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus soda)
            {
                soda.ChangeFlavor(SodasaurusFlavor.Vanilla);
            }
            NavigationService.GoBack();
        }
    }
}
