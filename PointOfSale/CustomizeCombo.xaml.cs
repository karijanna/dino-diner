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
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        private CretaceousCombo combo;
        public CustomizeCombo(CretaceousCombo Combo)
        {
            InitializeComponent();
            this.combo = Combo;
        }
        private void SelectSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }
        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if ( combo != null)
            {
                this.combo.Size = size;
            }
        }
        protected void PickSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
            //NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Changes the size to medium when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void PickMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
            //NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Changes size to large when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void PickLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
            //NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
