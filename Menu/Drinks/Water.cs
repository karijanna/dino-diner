/*  Water.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class for drink type water
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Water comes without lemon by default
        /// </summary>
        public bool Lemon = false;
        /// <summary>
        /// Varriable for setting the size
        /// </summary>
        public override Size Size
        {
            get; set;
        }
        /// <summary>
        /// List of ingredients for water
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }
        /// <summary>
        /// Default setting for water
        /// </summary>
        public Water()
        {
            Size = Size.Small;
            Price = 0.10;
            Calories = 0;
        }
        /// <summary>
        /// Method that adds lemon to the water
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;   
        }
    }
}
