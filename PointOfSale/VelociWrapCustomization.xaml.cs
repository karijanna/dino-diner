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
    /// Interaction logic for VelociWrapCustomization.xaml
    /// </summary>
    public partial class VelociWrapCustomization : Page
    {
        private VelociWrap vw;
        public VelociWrapCustomization(VelociWrap vw)
        {
            InitializeComponent();
            this.vw = vw;
        }
        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            vw.HoldDressing();
        }
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            vw.HoldLettuce();
        }
        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            vw.HoldCheese();
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
