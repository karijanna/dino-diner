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
using DinoDiner.Menu.Entrees;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SteakosaurusBurgerCustomization.xaml
    /// </summary>
    public partial class SteakosaurusBurgerCustomization : Page
    {
        private SteakosaurusBurger sb;
        public SteakosaurusBurgerCustomization(SteakosaurusBurger sb)
        {
            InitializeComponent();
            this.sb = sb;
        }
        private void OnHoldWholeWheatBun(object sender, RoutedEventArgs args)
        {
            sb.HoldBun();
        }
        private void OnHoldPickles(object sender, RoutedEventArgs args)
        {
            sb.HoldPickle();
        }
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            sb.HoldKetchup();
        }
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            sb.HoldMustard();
        }
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
