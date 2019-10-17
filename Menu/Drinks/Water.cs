/*  Water.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class for drink type water
    /// </summary>
    public class Water : Drink, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Water comes without lemon by default
        /// </summary>
        public bool Lemon = false;
        /// <summary>
        /// The PropertyChanged event handler 
        /// Notifies of changes to the Price, Description, and Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Helper function for notifying of property changes
        /// </summary>
        /// <param name="propertyName">Name of the property that is changed</param>
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        /// <summary>
        /// Gets a description of this order item
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Gets a special instructions for this order item
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Lemon) special.Add("Hold Lemon");
                return special.ToArray();
            }
        }
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
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        public override string ToString()
        {
            return Size.ToString() + " Water";
        }
    }
}
