/*DrinkSelection.xaml.cs
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Gets and sets the drink item
        /// </summary>
        public Drink Drink { get; set; }
        /// <summary>
        /// Constructor for drink selection class
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Overriding constructor of drink selection
        /// </summary>
        /// <param name="drink">The drink selected from order control</param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink; 
        }
        /// <summary>
        /// Method for selecting drink item
        /// </summary>
        /// <param name="drink">The drink item selected</param>
        private void SelectDrink(Drink drink)
        {
            if (DataContext is Order order)
            {
                order.Add(drink);
                this.Drink = drink;
            }
        }
        /// <summary>
        /// Selects size of the drink
        /// </summary>
        /// <param name="size">The size that the customer chooses</param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
            {
                this.Drink.Size = size;
            }
        }
        /// <summary>
        /// Add sodasaurus item to the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddSodasaurus(object sender, RoutedEventArgs args)
        {
            SelectDrink(new Sodasaurus());
            BtnSodasaurus.IsEnabled = true;
            BtnTyrannotea.IsEnabled = false;
            BtnWater.IsEnabled = false;
            BtnJurassicJava.IsEnabled = false;
            BtnPickLarge.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickSmall.IsEnabled = true;

            Button flavor = new Button { Height = 60, Width = 165, Content = "Flavor" };
            Grid.SetRow(flavor, 0);
            Grid.SetColumn(flavor, 2);
            Grid.SetRowSpan(flavor, 2);
            DrinkGrid.Children.Add(flavor);
            flavor.Click += new RoutedEventHandler(SelectFlavor);

            Button ice = new Button { Height = 60, Width = 165, Content = "Hold Ice" };
            Grid.SetRow(ice, 1);
            Grid.SetColumn(ice, 2);
            Grid.SetRowSpan(ice, 2);
            DrinkGrid.Children.Add(ice);
            ice.Click += new RoutedEventHandler(SelectHoldIce);

            Button done = new Button { Height = 60, Width = 165, Content = "Done" };
            Grid.SetRow(done, 2);
            Grid.SetColumn(done, 2);
            Grid.SetRowSpan(done, 2);
            DrinkGrid.Children.Add(done);
            done.Click += new RoutedEventHandler(SelectDone);
        }
        /// <summary>
        /// Adds tyrannotea to the menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddTyrannotea(object sender, RoutedEventArgs args)
        {
            SelectDrink(new Tyrannotea());
            BtnSodasaurus.IsEnabled = false;
            BtnTyrannotea.IsEnabled = true;
            BtnWater.IsEnabled = false;
            BtnJurassicJava.IsEnabled = false;
            BtnPickLarge.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickSmall.IsEnabled = true;

            Button lemon = new Button { Height = 45, Width = 165, Content = "Add Lemon" };
            Grid.SetRow(lemon, 0);
            Grid.SetColumn(lemon, 2);
            Grid.SetRowSpan(lemon, 2);
            DrinkGrid.Children.Add(lemon);
            lemon.Click += new RoutedEventHandler(SelectLemon);

            Button sweet = new Button { Height = 45, Width = 165, Content = "Make Sweet" };
            Grid.SetRow(sweet, 1);
            Grid.SetColumn(sweet, 2);
            Grid.SetRowSpan(sweet, 1);
            DrinkGrid.Children.Add(sweet);
            sweet.Click += new RoutedEventHandler(SelectSweet);

            Button ice = new Button { Height = 45, Width = 165, Content = "Hold Ice" };
            Grid.SetRow(ice, 2);
            Grid.SetColumn(ice, 2);
            Grid.SetRowSpan(ice, 1);
            DrinkGrid.Children.Add(ice);
            ice.Click += new RoutedEventHandler(SelectHoldIce);

            Button done = new Button { Height = 45, Width = 165, Content = "Done" };
            Grid.SetRow(done, 3);
            Grid.SetColumn(done, 2);
            Grid.SetRowSpan(done, 1);
            DrinkGrid.Children.Add(done);
            done.Click += new RoutedEventHandler(SelectDone);
            //NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Adds water to the order selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddWater(object sender, RoutedEventArgs args)
        {
            SelectDrink(new Water());
            BtnSodasaurus.IsEnabled = false;
            BtnTyrannotea.IsEnabled = false;
            BtnWater.IsEnabled = true;
            BtnJurassicJava.IsEnabled = false;
            BtnPickLarge.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickSmall.IsEnabled = true;
            //NavigationService.Navigate(new MenuCategorySelection());

            Button lemon = new Button { Height = 60, Width = 165, Content = "Add Lemon" };
            Grid.SetRow(lemon, 0);
            Grid.SetColumn(lemon, 2);
            Grid.SetRowSpan(lemon, 2);
            DrinkGrid.Children.Add(lemon);
            lemon.Click += new RoutedEventHandler(SelectLemon);

            Button ice = new Button { Height = 60, Width = 165, Content = "Hold Ice" };
            Grid.SetRow(ice, 1);
            Grid.SetColumn(ice, 2);
            Grid.SetRowSpan(ice, 2);
            DrinkGrid.Children.Add(ice);
            ice.Click += new RoutedEventHandler(SelectHoldIce);

            Button done = new Button { Height = 60, Width = 165, Content = "Done" };
            Grid.SetRow(done, 2);
            Grid.SetColumn(done, 2);
            Grid.SetRowSpan(done, 2);
            DrinkGrid.Children.Add(done);
            done.Click += new RoutedEventHandler(SelectDone);
        }
        /// <summary>
        /// Adds Jurassic Java on the menu selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddJurassicJava(object sender, RoutedEventArgs args)
        {
            SelectDrink(new JurassicJava());
            BtnSodasaurus.IsEnabled = false;
            BtnTyrannotea.IsEnabled = false;
            BtnWater.IsEnabled = false;
            BtnJurassicJava.IsEnabled = true;
            BtnPickLarge.IsEnabled = true;
            BtnPickMedium.IsEnabled = true;
            BtnPickSmall.IsEnabled = true;
            //NavigationService.Navigate(new MenuCategorySelection());

            Button cream = new Button { Height = 45, Width = 165, Content = "Room for Cream" };
            Grid.SetRow(cream, 0);
            Grid.SetColumn(cream, 2);
            Grid.SetRowSpan(cream, 2);
            DrinkGrid.Children.Add(cream);
            cream.Click += new RoutedEventHandler(SelectCream);

            Button decaf = new Button { Height = 45, Width = 165, Content = "Decaf" };
            Grid.SetRow(decaf, 1);
            Grid.SetColumn(decaf, 2);
            Grid.SetRowSpan(decaf, 1);
            DrinkGrid.Children.Add(decaf);
            decaf.Click += new RoutedEventHandler(SelectDecaf);

            Button ice = new Button { Height = 45, Width = 165, Content = "Add Ice" };
            Grid.SetRow(ice, 2);
            Grid.SetColumn(ice, 2);
            Grid.SetRowSpan(ice, 1);
            DrinkGrid.Children.Add(ice);
            ice.Click += new RoutedEventHandler(SelectAddIce);

            Button done = new Button { Height = 45, Width = 165, Content = "Done" };
            Grid.SetRow(done, 3);
            Grid.SetColumn(done, 2);
            Grid.SetRowSpan(done, 1);
            DrinkGrid.Children.Add(done);
            done.Click += new RoutedEventHandler(SelectDone);
        }
        /// <summary>
        /// Ables the customer to pick size small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void PickSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
            //NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Ables the customer to pick size medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void PickMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
            //NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Ables the customer to pick size large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void PickLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
            //NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Ables the customer select flavor by directing user to the flavor selection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection(Drink));
        }
        /// <summary>
        /// When user clicks done, it redirects them to the main page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// When clicking hold ice, it adds it to the special list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectHoldIce(object sender, RoutedEventArgs args)
        {
            this.Drink.HoldIce();
        }
        /// <summary>
        /// When adding lemon, it adds lemon to the item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectLemon(object sender, RoutedEventArgs args)
        {
            if (Drink is Tyrannotea tea)
            {
                tea.AddLemon();
            }
            if (Drink is Water water)
            {
                water.AddLemon();
            }
        }
        /// <summary>
        /// Adds sugar to the Tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectSweet(object sender, RoutedEventArgs args)
        {
            if (Drink is Tyrannotea tea)
            {
                tea.MakeSweet = true;
            }
        }
        /// <summary>
        /// Makes room for cream in Jurassic Java 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectCream(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava coffee)
            {
                coffee.LeaveRoomForCream();
            }
        }
        /// <summary>
        /// Makes decaf coffee for Jurassic Java 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectDecaf(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava coffee)
            {
                coffee.MakeDecaf = true;
            }
        }
        /// <summary>
        /// Adds ice to Jurassic Java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void SelectAddIce(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava coffee)
            {
                coffee.AddIce();
            }
        }
    }
}
