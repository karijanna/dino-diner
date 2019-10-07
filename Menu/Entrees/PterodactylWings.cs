/*  PterodactylWings.cs
*   Author: Karijanna Miller
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Pterodactyle Wings calories, price, and list of ingredients
    /// </summary>
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// Adds the list of ingredients to the menu
        /// </summary>
        public override List<string> Ingredients
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
            Price = 7.21;
            Calories = 318;
        }
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
