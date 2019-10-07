/*  Menu.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that represents the Menu
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// List of total available menu items
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menuItem = new List<IMenuItem>();
                menuItem.Add(new Brontowurst());
                menuItem.Add(new JurassicJava());
                menuItem.Add(new Sodasaurus());
                menuItem.Add(new Tyrannotea());
                menuItem.Add(new Water());
                menuItem.Add(new DinoNuggets());
                menuItem.Add(new PrehistoricPBJ());
                menuItem.Add(new PterodactylWings());
                menuItem.Add(new SteakosaurusBurger());
                menuItem.Add(new TRexKingBurger());
                menuItem.Add(new VelociWrap());
                menuItem.Add(new Fryceritops());
                menuItem.Add(new MeteorMacAndCheese());
                menuItem.Add(new MezzorellaSticks());
                menuItem.Add(new Triceritots());
                menuItem.Add(new CretaceousCombo(new Brontowurst()));
                menuItem.Add(new CretaceousCombo(new DinoNuggets()));
                menuItem.Add(new CretaceousCombo(new PrehistoricPBJ()));
                menuItem.Add(new CretaceousCombo(new PterodactylWings()));
                menuItem.Add(new CretaceousCombo(new SteakosaurusBurger()));
                menuItem.Add(new CretaceousCombo(new TRexKingBurger()));
                menuItem.Add(new CretaceousCombo(new VelociWrap()));
                return menuItem;
            }
        }
        /// <summary>
        /// List of all the available entree options
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> entreeItem = new List<IMenuItem>();
                entreeItem.Add(new Brontowurst());
                entreeItem.Add(new DinoNuggets());
                entreeItem.Add(new PrehistoricPBJ());
                entreeItem.Add(new PterodactylWings());
                entreeItem.Add(new SteakosaurusBurger());
                entreeItem.Add(new TRexKingBurger());
                entreeItem.Add(new VelociWrap());
                return entreeItem;
            }
        }
        /// <summary>
        /// List of all availalbe side options
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> sideItem = new List<IMenuItem>();
                sideItem.Add(new Fryceritops());
                sideItem.Add(new MeteorMacAndCheese());
                sideItem.Add(new MezzorellaSticks());
                sideItem.Add(new Triceritots());
                return sideItem;
            }
        }
        /// <summary>
        /// List of all available drink options
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> drinkItem = new List<IMenuItem>();
                drinkItem.Add(new JurassicJava());
                drinkItem.Add(new Sodasaurus());
                drinkItem.Add(new Tyrannotea());
                drinkItem.Add(new Water());
                return drinkItem;
            }
        }
        /// <summary>
        /// List of all available combo options
        /// </summary>
        public List<IMenuItem> AvailableCombo
        {
            get
            {
                List<IMenuItem> comboItem = new List<IMenuItem>();
                comboItem.Add(new CretaceousCombo(new Brontowurst()));
                comboItem.Add(new CretaceousCombo(new DinoNuggets()));
                comboItem.Add(new CretaceousCombo(new PrehistoricPBJ()));
                comboItem.Add(new CretaceousCombo(new PterodactylWings()));
                comboItem.Add(new CretaceousCombo(new SteakosaurusBurger()));
                comboItem.Add(new CretaceousCombo(new TRexKingBurger()));
                comboItem.Add(new CretaceousCombo(new VelociWrap()));
                return comboItem;
            }
        }
        /// <summary>
        /// Converting menu items into string to be readable to customers
        /// </summary>
        /// <returns>The menu stringbuilder into a string</returns>
        public override string ToString()
        {
            StringBuilder menu = new StringBuilder();
            foreach(IMenuItem item in AvailableMenuItems)
            {
                menu.Append(item.ToString() + "\n");
            }
            return menu.ToString();
        }
    }
}
