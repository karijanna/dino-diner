/*  VelociWrap.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Veloci Wrap price, calories, and list of ingredients
    /// Contains methods to take off certain ingredients if customer wants to
    /// </summary>
    public class VelociWrap
    {
        /// <summary>
        /// Customers can ask for dressing off their order
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// Customers can ask for lettuce off their order
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Customers can ask for cheese off their order
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// The price of the order
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Calorie amount of the order
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// The ingredients list that appears on the menu
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla" };
                ingredients.Add("Chicken Breast");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Defining the price and calories for the VelociWrap
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Method to take off the dressing 
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Method to take off the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Method to take off the cheese
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
