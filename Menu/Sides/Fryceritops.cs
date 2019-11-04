/*  Fryceritops.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Class that represents the Fryceritops side menu item
    /// </summary>
    public class Fryceritops : Side, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// The PropertyChanged event handler 
        /// Notifies of changes to the Price, Description, and Special properties
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Helper function for notifying of property changes
        /// </summary>
        /// <param name="propertyName">Name of the property that is changed</param>
        public override void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Gets and sets the description
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
        /// <summary>
        /// Sets the price, size, and calories of the default size  
        /// Adds the ingredients to the menu
        /// </summary>
        public Fryceritops()
        {
            Size = Size.Small;
            Price = 0.99;
            Calories = 222;
        }
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
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
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        NotifyOfPropertyChange("Description");
                        NotifyOfPropertyChange("Price");
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Turns the order into a string
        /// </summary>
        /// <returns>The readable version of the order</returns>
        public override string ToString()
        {
            return Size.ToString() + " Fryceritops";
        }
    }
}
