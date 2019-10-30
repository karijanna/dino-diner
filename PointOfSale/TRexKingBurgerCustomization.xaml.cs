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
    /// Interaction logic for TRexKingBurgerCustomization.xaml
    /// </summary>
    public partial class TRexKingBurgerCustomization : Page
    {
        private TRexKingBurger tk;
        public TRexKingBurgerCustomization(TRexKingBurger tk)
        {
            InitializeComponent();
            this.tk = tk;
        }
        private void OnHoldWholeWheatBun(object sender, RoutedEventArgs args)
        {
            tk.HoldBun();
        }
        private void OnHoldPickles(object sender, RoutedEventArgs args)
        {
            tk.HoldPickle();
        }
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            tk.HoldKetchup();
        }
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            tk.HoldMustard();
        }
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            tk.HoldMayo();
        }
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            tk.HoldOnion();
        }
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            tk.HoldLettuce();
        }
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            tk.HoldTomato();
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
