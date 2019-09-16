/*  PrehistoricPBJ.cs
*   Author: Karijanna Miller
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Prehistoric PBJ calories, price, and list of ingredients 
    /// Contains methods that takes off certain ingredients if customers want to
    /// </summary>
    public class PrehistoricPBJ
    {
        /// <summary>
        /// Customers can take off peanut butter off of their order
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// Customers can take off peanut butter off of their order
        /// </summary>
        private bool jelly = true;
        /// <summary>
        /// Sets the price of Prehistoric PBJ
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Sets the calories amount for Prehistoric PBJ
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Adds the list of ingredients to the menu
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// Price and calories for the Prehistoric PBJ
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }
        /// <summary>
        /// Method to take off peanut butter
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }
        /// <summary>
        /// Method to take off jelly
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
