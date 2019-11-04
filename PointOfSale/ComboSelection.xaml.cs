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
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public CretaceousCombo Combo = new CretaceousCombo(new Brontowurst());
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
            CretaceousCombo cc = new CretaceousCombo(new DinoNuggets());
            SelectCombo(cc);
            if (cc.Entree is DinoNuggets bw)
            {
                NavigationService.Navigate(new DinoNuggetsCustomization(bw));
            }
        }
        private void SelectPBJ(object sender, RoutedEventArgs e)
        {
            CretaceousCombo cc = new CretaceousCombo(new PrehistoricPBJ());
            SelectCombo(cc);
            if (cc.Entree is PrehistoricPBJ bw)
            {
                NavigationService.Navigate(new PrehistoricPBJCustomization(bw));
            }
        }
        private void SelectVelociWrap(object sender, RoutedEventArgs e)
        {
            CretaceousCombo cc = new CretaceousCombo(new VelociWrap());
            SelectCombo(cc);
            if (cc.Entree is VelociWrap bw)
            {
                NavigationService.Navigate(new VelociWrapCustomization(bw));
            }
        }
        private void SelectSteakosaurus(object sender, RoutedEventArgs e)
        {
            CretaceousCombo cc = new CretaceousCombo(new SteakosaurusBurger());
            SelectCombo(cc);
            if (cc.Entree is SteakosaurusBurger bw)
            {
                NavigationService.Navigate(new SteakosaurusBurgerCustomization(bw));
            }
        }
        private void SelectTRexKingBurger(object sender, RoutedEventArgs e)
        {
            CretaceousCombo cc = new CretaceousCombo(new TRexKingBurger());
            SelectCombo(cc);
            if (cc.Entree is TRexKingBurger bw)
            {
                NavigationService.Navigate(new TRexKingBurgerCustomization(bw));
            }
        }
        private void SelectPterodactylWings(object sender, RoutedEventArgs e)
        {
            CretaceousCombo cc = new CretaceousCombo(new PterodactylWings());
            SelectCombo(cc);
            if (cc.Entree is PterodactylWings bw)
            {
                NavigationService.Navigate(new CustomizeCombo());
            }
        }
    }
}
