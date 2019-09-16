/*  PterodactylWings.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Pterodactyle Wings calories, price, and list of ingredients
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// Sets the price for the Pterodactyl Wings
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Sets the calories amount for the menu item 
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Adds the list of ingredients to the menu
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken" };
                ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }
        /// <summary>
        /// Price and calories for Pterodactyl Wings
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
