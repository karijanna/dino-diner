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
    public class PrehistoricPBJ : Entree
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
        /// Adds the list of ingredients to the menu
        /// </summary>
        public override List<string> Ingredients
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
            Price = 6.52;
            Calories = 483;
        }
        /// <summary>
        /// Method to take off peanut butter
        /// </summary>
        public void HoldPeanutButter()
        {
            peanutButter = false;
        }
        /// <summary>
        /// Method to take off jelly
        /// </summary>
        public void HoldJelly()
        {
            jelly = false;
        }
    }
}
