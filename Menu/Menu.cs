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
    public static class Menu
    {
        /// <summary>
        /// List of total available menu items
        /// </summary>
        public static List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menuItem = new List<IMenuItem>();
                menuItem.AddRange(AvailableCombo);
                menuItem.AddRange(AvailableDrinks);
                menuItem.AddRange(AvailableEntrees);
                menuItem.AddRange(AvailableSides);
                return menuItem;
            }
        }
        /// <summary>
        /// List of all the available entree options
        /// </summary>
        public static List<IMenuItem> AvailableEntrees
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
        public static List<IMenuItem> AvailableSides
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
        public static List<IMenuItem> AvailableDrinks
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
        public static List<IMenuItem> AvailableCombo
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
        /// List of all possible ingredients on a menu item
        /// </summary>
        /// <returns>The list of ingredients</returns>
        public static List<string> PossibleIngredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                foreach(IMenuItem item in AvailableMenuItems)
                {
                    foreach(string s in item.Ingredients)
                    {
                        if(!ingredients.Contains(s))
                        {
                            ingredients.Add(s);
                        }
                    }
                }
                return ingredients;
            }
        }
        /// <summary>
        /// Seaches the menu item
        /// </summary>
        /// <param name="menuitems">The menu item a customer is searching for</param>
        /// <param name="term">The string that the customer enters</param>
        /// <returns>The search that the customer was looking for</returns>
        public static List<IMenuItem> Search(List<IMenuItem> menuitems, string term)
        {
            List<IMenuItem> list = new List<IMenuItem>();
            foreach(IMenuItem item in menuitems)
            {
                if(item.ToString().Contains(term))
                {
                    list.Add(item);
                }
            }
            return list;
        }
        /// <summary>
        /// Method to operate the filter by category functionality
        /// </summary>
        /// <param name="menuitems">The menu items that customer is filtering</param>
        /// <param name="category">Category to filter through</param>
        /// <returns>The filterd categories the customer was looking for</returns>
        public static List<IMenuItem> FilterByCategory(List<IMenuItem> menuitems, List<string> category)
        {
            List<IMenuItem> list = new List<IMenuItem>();
            foreach(IMenuItem item in menuitems)
            {
                if(category.Contains(item.Category))
                {
                    list.Add(item);
                }
            }
            return list;
        }
        /// <summary>
        /// Filters menu items by minimum price
        /// </summary>
        /// <param name="menuitems">The available menu items</param>
        /// <param name="minPrice">The minimum price filter</param>
        /// <returns>The filtered menu items</returns>
        public static List<IMenuItem> FilterByMinPrice(List<IMenuItem> menuitems, float minPrice)
        {
            List<IMenuItem> list = new List<IMenuItem>();
            foreach(IMenuItem item in menuitems)
            {
                if(minPrice <= item.Price)
                {
                    list.Add(item);
                }
            }
            return list;
        }
        /// <summary>
        /// Filters menu items by maximum price
        /// </summary>
        /// <param name="menuitems">The available menu items</param>
        /// <param name="maxPrice">The maximum price filter</param>
        /// <returns>The filtered menu items</returns>
        public static List<IMenuItem> FilterByMaxPrice(List<IMenuItem> menuitems, float maxPrice)
        {
            List<IMenuItem> list = new List<IMenuItem>();
            foreach (IMenuItem item in menuitems)
            {
                if(maxPrice >= item.Price)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public static List<IMenuItem> FilterByIngredients(List<IMenuItem> menuitems, List<string> excludeIngredients)
        {
            List<IMenuItem> list = new List<IMenuItem>();
            list.AddRange(menuitems);
            foreach(IMenuItem item in menuitems)
            {
                foreach(string ingredients in item.Ingredients)
                {
                    if(excludeIngredients.Contains(ingredients))
                    {
                        list.Remove(item);
                    }
                }
            }
            return list;
        }
    }
}
