/*  DinoNuggets.cs
*   Author: Karijanna Miller
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Dino Nuggets price, calories, and list of ingredients
    /// Contains method to add extra nuggets to the order
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// Count of nuggets when customer adds extra nugget count to the order
        /// </summary>
        private uint nuggetCount = 6;
        /// <summary>
        /// Adds the list of ingredients to the menu
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
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
            Price = 4.25;
            Calories = 354;
        }
        /// <summary>
        /// Method adds an extra nugget onto the order
        /// Adds the appropriate extra amount for price and calories
        /// </summary>
        public void AddNugget()
        {
            nuggetCount++;
            Price += 0.25;
            Calories += 59;
        }
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
