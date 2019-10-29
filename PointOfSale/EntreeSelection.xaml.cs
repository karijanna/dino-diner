﻿/* EntreeSelection.xaml.cs
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
using System.ComponentModel;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// Gets and sets an entree item
        /// </summary>
        public Entree Entree { get; set; }
        /// <summary>
        /// Constructor for entree selection class
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Overriding constructor for entree selection
        /// </summary>
        /// <param name="entree">The entree item added to the order</param>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            Entree = entree;
        }
        /*private void OnSelectComebo(object sender, RoutedCommand args)
        {
            NavigationService.Navigate(new ComboSelection());
        }*/
        /// <summary>
        /// Directs user to the PBJ customization page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new PrehistoricPBJCustomization(pbj));
            }
        }
        /// <summary>
        /// Enables user to select an entree item
        /// </summary>
        /// <param name="entree"></param>
        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
                this.Entree = entree;
            }
        }
        /// <summary>
        /// Adds Brontowurst to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            SelectEntree(new Brontowurst());
            BtnBrontowurst.IsEnabled = true;
            BtnDinoNuggets.IsEnabled = true;
            BtnPBJ.IsEnabled = true;
            BtnPterodactylWings.IsEnabled = true;
            BtnSteakosaurus.IsEnabled = true;
            BtnTRexKingburger.IsEnabled = true;
            BtnVelociWrap.IsEnabled = true;
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Adds dino nuggets to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            SelectEntree(new DinoNuggets());
            BtnBrontowurst.IsEnabled = true;
            BtnDinoNuggets.IsEnabled = true;
            BtnPBJ.IsEnabled = true;
            BtnPterodactylWings.IsEnabled = true;
            BtnSteakosaurus.IsEnabled = true;
            BtnTRexKingburger.IsEnabled = true;
            BtnVelociWrap.IsEnabled = true;
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Adds PBJ to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddPBJ(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PrehistoricPBJ());
            BtnBrontowurst.IsEnabled = true;
            BtnDinoNuggets.IsEnabled = true;
            BtnPBJ.IsEnabled = true;
            BtnPterodactylWings.IsEnabled = true;
            BtnSteakosaurus.IsEnabled = true;
            BtnTRexKingburger.IsEnabled = true;
            BtnVelociWrap.IsEnabled = true;
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Adds pterodactyl wings to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddPterodactylWings(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PterodactylWings());
            BtnBrontowurst.IsEnabled = true;
            BtnDinoNuggets.IsEnabled = true;
            BtnPBJ.IsEnabled = true;
            BtnPterodactylWings.IsEnabled = true;
            BtnSteakosaurus.IsEnabled = true;
            BtnTRexKingburger.IsEnabled = true;
            BtnVelociWrap.IsEnabled = true;
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Adds steakosaurus to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddSteakosaurus(object sender, RoutedEventArgs args)
        {
            SelectEntree(new SteakosaurusBurger());
            BtnBrontowurst.IsEnabled = true;
            BtnDinoNuggets.IsEnabled = true;
            BtnPBJ.IsEnabled = true;
            BtnPterodactylWings.IsEnabled = true;
            BtnSteakosaurus.IsEnabled = true;
            BtnTRexKingburger.IsEnabled = true;
            BtnVelociWrap.IsEnabled = true;
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Adds the t rex king burder to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            SelectEntree(new TRexKingBurger());
            BtnBrontowurst.IsEnabled = true;
            BtnDinoNuggets.IsEnabled = true;
            BtnPBJ.IsEnabled = true;
            BtnPterodactylWings.IsEnabled = true;
            BtnSteakosaurus.IsEnabled = true;
            BtnTRexKingburger.IsEnabled = true;
            BtnVelociWrap.IsEnabled = true;
            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Adds veloci wrap to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void AddVelociWrap(object sender, RoutedEventArgs args)
        {
            SelectEntree(new VelociWrap());
            BtnBrontowurst.IsEnabled = true;
            BtnDinoNuggets.IsEnabled = true;
            BtnPBJ.IsEnabled = true;
            BtnPterodactylWings.IsEnabled = true;
            BtnSteakosaurus.IsEnabled = true;
            BtnTRexKingburger.IsEnabled = true;
            BtnVelociWrap.IsEnabled = true;
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}