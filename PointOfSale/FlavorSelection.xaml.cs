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
        public Drink Drink { get; set; }
        public FlavorSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink;
        }
        private void SelectCherry(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus soda)
            {
                soda.ChangeFlavor(SodasaurusFlavor.Cherry);
            }
            NavigationService.GoBack();
        }
        private void SelectOrange(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus soda)
            {
                soda.ChangeFlavor(SodasaurusFlavor.Orange);
            }
            NavigationService.GoBack();
        }
        private void SelectChocolate(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus soda)
            {
                soda.ChangeFlavor(SodasaurusFlavor.Chocolate);
            }
            NavigationService.GoBack();
        }
        private void SelectRootBeer(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus soda)
            {
                soda.ChangeFlavor(SodasaurusFlavor.RootBeer);
            }
            NavigationService.GoBack();
        }
        private void SelectCola(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus soda)
            {
                soda.ChangeFlavor(SodasaurusFlavor.Cola);
            }
            NavigationService.GoBack();
        }
        private void SelectLime(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus soda)
            {
                soda.ChangeFlavor(SodasaurusFlavor.Lime);
            }
            NavigationService.GoBack();
        }
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
