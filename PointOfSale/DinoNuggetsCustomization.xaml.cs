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
    /// Interaction logic for DinoNuggetsCustomization.xaml
    /// </summary>
    public partial class DinoNuggetsCustomization : Page
    {
        private DinoNuggets dn;
        public DinoNuggetsCustomization(DinoNuggets dn)
        {
            InitializeComponent();
            this.dn = dn;
        }
        private void OnAddNuggets(object sender, RoutedEventArgs args)
        {
            dn.AddNugget();
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
