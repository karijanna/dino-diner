/*  TRexKingBurger.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// T-Rex King Burger price, calories, and list of ingredients
    /// Contains methods to take off certain ingredients if customers wants to 
    /// </summary>
    public class TRexKingBurger
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
        /// Sets the price of the order
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Sets the amount of calories within the order
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Adds the following ingredients to the menu
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Patties", "Steakburger Patties", "Steakburger Patties" };
                if (wholeWheatBun) ingredients.Add("Whole-wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomatoes");
                if (onion) ingredients.Add("Onions");
                if (pickle) ingredients.Add("Pickles");
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
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// Method to take off the bun
        /// </summary>
        public void HoldBun()
        {
            this.wholeWheatBun = false;
        }
        /// <summary>
        /// Method to take off the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// Method to take off the tomato
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }
        /// <summary>
        /// Method to take off the onion
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
        /// <summary>
        /// Method to take off the pickle
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// Method to take off the ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// Method to take off the mustard
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
        /// <summary>
        /// Mehotd to take off the mayo
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }
    }

}
