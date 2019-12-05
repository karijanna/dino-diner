/*  Drink.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Abstract class drink that implements within the drinks menu
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The PropertyChanged event handler 
        /// Notifies of changes to the Price, Description, and Special properties
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Helper function for notifying of property changes
        /// </summary>
        /// <param name="propertyName">Name of the property that is changed</param>
        public abstract void NotifyOfPropertyChange(string propertyName);
        /// <summary>
        /// Sets the size
        /// </summary>
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
        public bool Ice = false;
        /// <summary>
        /// Set to false when customers don't want ice in their drinks
        /// </summary>
        public abstract void HoldIce();
        /// <summary>
        /// Gets the special requirements for a menu item
        /// </summary>
        public abstract string[] Special { get; }
        /// <summary>
        /// Gets the description of a menu item
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// Makes drinks available on category
        /// </summary>
        public string Category { get; set; }
    }
}
