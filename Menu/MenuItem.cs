/*  MenuItem.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for IMenuItem to implement in DinoDiner
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Getting and setting the price 
        /// </summary>
        double Price { get; set; }
        /// <summary>
        /// Getting and setting the calories
        /// </summary>
        uint Calories { get; set; }
        /// <summary>
        /// Getting and setting the ingredients
        /// </summary>
        List<string> Ingredients { get; }
    }
}
