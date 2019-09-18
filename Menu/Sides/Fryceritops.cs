/*  Fryceritops.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Class that represents the Fryceritops side menu item
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// Sets the price, size, and calories of the default size  
        /// Adds the ingredients to the menu
        /// </summary>
        public Fryceritops()
        {
            Size = Size.Small;
            Price = 0.99;
            Calories = 222;
            Ingredients = new List<string>() { "Potato", "Salt", "Vegtable Oil" };
        }
        /// <summary>
        /// Private size variable for switch case
        /// </summary>
        private Size size;
        /// <summary>
        /// Overrides the public Size method 
        /// To set specific amount for Fryceritops
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }
            get
            {
                return size;
            }
        }
    }
}
