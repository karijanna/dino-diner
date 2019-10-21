/*  Tyrannotea.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class that represents the Tyrannotea drink menu item
    /// </summary>
    public class Tyrannotea : Drink, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Private size variable for switch case
        /// </summary>
        private Size size;
        /// <summary>
        /// 
        /// </summary>
        public override void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// Variable for making the tea sweet
        /// </summary>
        public bool Sweet = false;
        /// <summary>
        /// Variable for adding lemon to the tea
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
        public override string Description
        {
            get
            {
                return this.ToString();
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
                //if (!Sweet) special.Add("Hold Sugar");
                return special.ToArray();
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
                if (Lemon) ingredients.Add("Lemon");
                if (MakeSweet) ingredients.Add("Cane Sugar");
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
            Ice = true;
        }
        /// <summary>
        /// Method for adding lemon to the tea
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method for adding sugar to tea
        /// </summary>
        public bool MakeSweet
        {
            get { return Sweet;  }
            set
            {
                Sweet = value;
                if (Sweet == true)
                {
                    Calories *= 2;
                }
                else
                {
                    Calories /= 2;
                }
            }
        }
        public override string ToString()
        {
            if (Sweet == true)
            {
                return Size.ToString() + " Sweet Tyrannotea";
            }
            return Size.ToString() + " Tyrannotea";
        }
    }
}
