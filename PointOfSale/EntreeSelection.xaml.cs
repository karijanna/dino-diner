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
        public Entree Entree { get; set; }
        public EntreeSelection()
        {
            InitializeComponent();
        }
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            Entree = entree;
        }
        /*private void OnSelectComebo(object sender, RoutedCommand args)
        {
            NavigationService.Navigate(new ComboSelection());
        }*/
        private void OnAddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new PrehistoricPBJCustomization(pbj));
            }
        }
        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
                this.Entree = entree;
            }
        }
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
