/*  JurassicJava.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class that represents the Jurassic Java drink menu item
    /// </summary>
    public class JurassicJava : Drink, INotifyPropertyChanged, IOrderItem
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
                if (Ice) special.Add("Add Ice");
                if (RoomForCream) special.Add("Leave Room For Cream");
                //if (!Decaf) special.Add("Hold")
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
            //Ice = false;
        }
        /// <summary>
        /// Method for making room for cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method for adding ice if customer wants it
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
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
