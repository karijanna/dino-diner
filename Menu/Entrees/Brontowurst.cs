/*  Brontowurst.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Brontowurst calories, price, and list of ingredients 
    /// Contains methods to take off certain ingredients if customers want to
    /// </summary>
    public class Brontowurst
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
        /// Sets the price of the Brontowurst
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Sets the calories of the Brontowurst
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Adds the list of ingredietns to the menu
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onions");
                return ingredients;
            }
        }
        /// <summary>
        /// Price and calories of the Brontowurst
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// Method to take off the bun
        /// </summary>
        public void HoldBun()
        {
            this.wholeWheatBun = false;
        }
        /// <summary>
        /// Method to take off the peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }
        /// <summary>
        /// Method to take off the onions
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
