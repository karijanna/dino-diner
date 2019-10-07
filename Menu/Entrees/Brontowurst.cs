/*  Brontowurst.cs
*   Author: Karijanna Miller
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Brontowurst calories, price, and list of ingredients 
    /// Contains methods to take off certain ingredients if customers want to
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        /// Customers can take off bun off of their order
        /// </summary>
        private bool wholeWheatBun = true;
        /// <summary>
        /// Customers can take off peppers off of their order
        /// </summary>
        private bool peppers = true;
        /// <summary>
        /// Customers can take of onions off of their order
        /// </summary>
        private bool onions = true;
        /// <summary>
        /// Adds the list of ingredietns to the menu
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }
        /// <summary>
        /// Price and calories of the Brontowurst
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
        }
        /// <summary>
        /// Method to take off the bun
        /// </summary>
        public void HoldBun()
        {
            wholeWheatBun = false;
        }
        /// <summary>
        /// Method to take off the peppers
        /// </summary>
        public void HoldPeppers()
        {
            peppers = false;
        }
        /// <summary>
        /// Method to take off the onions
        /// </summary>
        public void HoldOnion()
        {
            onions = false;
        }
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
