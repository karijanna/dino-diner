/* SideSelection.xaml.cs
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
        /// <summary>
        /// Gets and sets the side item
        /// </summary>
        public Side Side { get; set; }
        /// <summary>
        /// Constructor for side selection class
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Overriding side selection constructor
        /// </summary>
        /// <param name="side">The side selected by user</param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }
        /*private void ComboSelection(CretaceousCombo combo)
        {
               
        }*/
        /// <summary>
        /// Adds the side to the order when selected
        /// </summary>
        /// <param name="side"></param>
        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Add(side);
                this.Side = side;
            }
        }
        /// <summary>
        /// Allows user to select the size of the side
        /// </summary>
        /// <param name="size"></param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if(Side != null)
            {
                this.Side.Size = size;
            }
        }
        /// <summary>
        /// Add Fryceritops when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
        /// <summary>
        /// Adds Mezzorella Sticks when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
        /// <summary>
        /// Adds Triceritots when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
        /// <summary>
        /// Adds Meteor Mac and Cheese when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
        /// <summary>
        /// Changes the size to small when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void PickSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Changes the size to medium when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void PickMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Changes size to large when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void PickLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
