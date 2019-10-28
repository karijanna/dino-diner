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
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public Side Side { get; set; }
        public SideSelection()
        {
            InitializeComponent();
        }
        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }
        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Add(side);
                this.Side = side;
            }
        }
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if(Side != null)
            {
                this.Side.Size = size;
            }
        }
        protected void AddFryceritops(object sender, RoutedEventArgs args)
        {
            SelectSide(new Fryceritops());
            BtnAddFryceritops.IsEnabled = true;
            BtnAddTriceritots.IsEnabled = true;
            BtnAddMezzorellaSticks.IsEnabled = true;
            BtnAddMeteorMacAndCheese.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickSmall.IsEnabled = true;
        }
        protected void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
            BtnAddFryceritops.IsEnabled = true;
            BtnAddTriceritots.IsEnabled = true;
            BtnAddMezzorellaSticks.IsEnabled = true;
            BtnAddMeteorMacAndCheese.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickSmall.IsEnabled = true;
        }
        protected void AddTriceritots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
            BtnAddFryceritops.IsEnabled = true;
            BtnAddTriceritots.IsEnabled = true;
            BtnAddMezzorellaSticks.IsEnabled = true;
            BtnAddMeteorMacAndCheese.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickSmall.IsEnabled = true;
        }
        protected void AddMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
            BtnAddFryceritops.IsEnabled = true;
            BtnAddTriceritots.IsEnabled = true;
            BtnAddMezzorellaSticks.IsEnabled = true;
            BtnAddMeteorMacAndCheese.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickSmall.IsEnabled = true;
        }
        protected void PickSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
            NavigationService.Navigate(new MenuCategorySelection());
        }
        protected void PickMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
            NavigationService.Navigate(new MenuCategorySelection());
        }
        protected void PickLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
