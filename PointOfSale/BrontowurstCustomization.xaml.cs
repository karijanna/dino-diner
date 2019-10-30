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
    /// Interaction logic for BrontowurstCustomization.xaml
    /// </summary>
    public partial class BrontowurstCustomization : Page
    {
        private Brontowurst br;
        public BrontowurstCustomization(Brontowurst br)
        {
            InitializeComponent();
            this.br = br;
        }
        private void OnHoldWholeWheatBun(object sender, RoutedEventArgs args)
        {
            br.HoldBun();
        }
        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            br.HoldPeppers();
        }
        private void OnHoldOnions(object sender, RoutedEventArgs args)
        {
            br.HoldOnion();
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
