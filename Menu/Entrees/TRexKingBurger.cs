/*  TRexKingBurger.cs
*   Author: Karijanna Miller
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// T-Rex King Burger price, calories, and list of ingredients
    /// Contains methods to take off certain ingredients if customers wants to 
    /// </summary>
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// Customers can ask for the bun off of their order
        /// </summary>
        private bool wholeWheatBun = true;
        /// <summary>
        /// Customers can ask for lettuce off of their order
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Customers can ask for tomatoes off of their order
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// Customers can ask for onions off of their order
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// Customers can ask for pickels off of their order
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Customers can ask for ketchup off of their order
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Customers can ask for mustard off of their order
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// Customers can ask for mayo off of their order
        /// </summary>
        private bool mayo = true;
        /// <summary>
        /// Adds the following ingredients to the menu
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Price and calories for the T-Rex King Burger
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
        }

        /// <summary>
        /// Method to take off the bun
        /// </summary>
        public void HoldBun()
        {
            wholeWheatBun = false;
        }
        /// <summary>
        /// Method to take off the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
        }
        /// <summary>
        /// Method to take off the tomato
        /// </summary>
        public void HoldTomato()
        {
            tomato = false;
        }
        /// <summary>
        /// Method to take off the onion
        /// </summary>
        public void HoldOnion()
        {
            onion = false;
        }
        /// <summary>
        /// Method to take off the pickle
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
        /// <summary>
        /// Mehotd to take off the mayo
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
        }
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }

}
