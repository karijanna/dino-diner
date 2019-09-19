/*  SteakosaurusBurger.cs
*   Author: Karijanna Miller
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Steakosaurus Burger price, calories, and list of ingredients
    /// Contains methods to take off certain ingredients if customer wants to
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Customers can take off the bun off of their order
        /// </summary>
        private bool wholeWheatBun = true;
        /// <summary>
        /// Customers can take off pickes off of their order
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Customers can take off ketchup off of their order
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Customers can take off mustard off of their order
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// Adds the ingredients list to the menu for Steakosaurus Burger
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }
        /// <summary>
        /// Price and calories for the Steakosaurus Burger
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
        }
        /// <summary>
        /// Method to take off the bun
        /// </summary>
        public void HoldBun()
        {
            wholeWheatBun = false;
        }
        /// <summary>
        /// Method to take off the pickles
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
        }
        /// <summary>
        /// Method to take off the ketchup
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
        }
        /// <summary>
        /// Method to take off the mustard
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
        }
    }
}
