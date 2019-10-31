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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public CretaceousCombo Combo { get; set; }
        /// <summary>
        /// Opens the combo selection screen
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }
        public ComboSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            Combo = combo;
        }
        private void SelectCombo(CretaceousCombo combo)
        {
            if (DataContext is Order order)
            {
                order.Add(combo);
                this.Combo = combo;
            }
        }
        /// <summary>
        /// Opens customize combo screen for customize combo button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBrontowurst(object sender, RoutedEventArgs e)
        {
            CretaceousCombo cc = new CretaceousCombo(new Brontowurst());
            SelectCombo(cc);
            if (cc.Entree is Brontowurst bw)
            {
                NavigationService.Navigate(new BrontowurstCustomization(bw));
            }
        }
        private void SelectDinoNuggets(object sender, RoutedEventArgs e)
        {
            DinoNuggets dw = new DinoNuggets();
            NavigationService.Navigate(new DinoNuggetsCustomization(dw));
        }
        private void SelectPBJ(object sender, RoutedEventArgs e)
        {
            PrehistoricPBJ pb = new PrehistoricPBJ();
            NavigationService.Navigate(new PrehistoricPBJCustomization(pb));
        }
        private void SelectVelociWrap(object sender, RoutedEventArgs e)
        {
            VelociWrap vw = new VelociWrap();
            NavigationService.Navigate(new VelociWrapCustomization(vw));
        }
        private void SelectSteakosaurus(object sender, RoutedEventArgs e)
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            NavigationService.Navigate(new SteakosaurusBurgerCustomization(sb));
        }
        private void SelectTRexKingBurger(object sender, RoutedEventArgs e)
        {
            TRexKingBurger tr = new TRexKingBurger();
            NavigationService.Navigate(new TRexKingBurgerCustomization(tr));
        }
        private void SelectPterodactylWings(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PterodactylWings());
        }
    }
}
