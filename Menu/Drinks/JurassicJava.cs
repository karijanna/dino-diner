/*  JurassicJava.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class that represents the Jurassic Java drink menu item
    /// </summary>
    public class JurassicJava : Drink
    {
        /// <summary>
        /// Private size variable for switch case
        /// </summary>
        private Size size;
        /// <summary>
        /// Variable for making coffee decaf
        /// </summary>
        public bool Decaf = false;
        /// <summary>
        /// Variable for making room for cream
        /// </summary>
        public bool RoomForCream = false;
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
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
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
                return new List<string>() { "Water", "Coffee" };
            }
        }
        /// <summary>
        /// Sets the price, size, and calories of the default size  
        /// </summary>
        public JurassicJava()
        {
            Size = Size.Small;
            Price = 0.59;
            Calories = 2;
        }
        /// <summary>
        /// Method for making room for cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
        /// <summary>
        /// Method for adding ice if customer wants it
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }
        public override string ToString()
        {
            if (Decaf == true)
            {
                return Size.ToString() + " Decaf Jurassic Java";
            }
            return Size.ToString() + " Jurassic Java";
        }
    }
}
