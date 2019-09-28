/*  Tyrannotea.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class that represents the Tyrannotea drink menu item
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Private size variable for switch case
        /// </summary>
        private Size size;
        /// <summary>
        /// Variable for making the tea sweet
        /// </summary>
        private bool sweet = false;
        /// <summary>
        /// Variable for adding lemon to the tea
        /// </summary>
        private bool lemon = false;
        /// <summary>
        /// Overrides the public Size method 
        /// To set specific amount for Tyrannotea
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Adds the ingredients to the menu
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (lemon) ingredients.Add("Lemon");
                if (sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }
        /// <summary>
        /// Sets the price, size, and calories of the default size  
        /// </summary>
        public Tyrannotea()
        {
            Size = Size.Small;
            Price = 0.99;
            Calories = 8;
        }
        /// <summary>
        /// Method for adding lemon to the tea
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
        }
        /// <summary>
        /// Method for adding sugar to tea
        /// </summary>
        public void MakeSweet()
        {
            sweet = true;
        }
    }
}
