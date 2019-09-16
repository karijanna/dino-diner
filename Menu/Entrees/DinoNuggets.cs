/*  PrehistoricPBJ.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Dino Nuggets price, calories, and list of ingredients
    /// Contains method to add extra nuggets to the order
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// Sets the price of Dino Nuggets
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Sets the calories of Dino Nuggets
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Count of nuggets when customer adds extra nugget count to the order
        /// </summary>
        public uint nuggetCount;
        /// <summary>
        /// Adds the list of ingredients to the menu
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }
        /// <summary>
        /// Price and calories of Dino Nuggest
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
            // calories will change when adding a nugget
        }
        /// <summary>
        /// Method adds an extra nugget onto the order
        /// Adds the appropriate extra amount for price and calories
        /// </summary>
        public void AddNugget()
        {
            Price += 0.25;
            Calories += 59;
            nuggetCount++;
        }
    }
}
