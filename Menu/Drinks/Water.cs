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
        /// Private size variable for switch case
        /// </summary>
        private Size size;
        /// <summary>
        /// Water comes without lemon by default
        /// </summary>
        public bool Lemon = false;
        /// <summary>
        /// 
        /// </summary>
        public override void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChange("Special");
        }
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
        /// Gets a description of this order item
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
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
                    case Size.Small:
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Medium:
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Large:
                        NotifyOfPropertyChange("Description");
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Gets a special instructions for this order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
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
            Ice = true;
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
