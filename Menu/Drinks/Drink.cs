/*  Drink.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Abstract class drink that implements within the drinks menu
    /// </summary>
    public abstract class Drink
    {
        public abstract Size Size { get; set; }
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; set; }
        /// <summary>
        /// Variable ice that will be true in default
        /// </summary>
        public bool Ice = true;
        /// <summary>
        /// Set to false when customers don't want ice in their drinks
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
