/*  SteakosaurusBurger.cs
*   Author: Karijanna Miller
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Steakosaurus Burger price, calories, and list of ingredients
    /// Contains methods to take off certain ingredients if customer wants to
    /// </summary>
    public class SteakosaurusBurger : Entree, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Customers can take off the bun off of their order
        /// </summary>
        private bool wholeWheatBun = true;
        /// <summary>
        /// Customers can take off pickes off of their order
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Customers can take off ketchup off of their order
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Customers can take off mustard off of their order
        /// </summary>
        private bool mustard = true;
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
                if (!wholeWheatBun) special.Add("Hold Whole Wheat Bun");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Adds the ingredients list to the menu for Steakosaurus Burger
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }
        /// <summary>
        /// Price and calories for the Steakosaurus Burger
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
        }
        /// <summary>
        /// Method to take off the bun
        /// </summary>
        public void HoldBun()
        {
            wholeWheatBun = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method to take off the pickles
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method to take off the ketchup
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method to take off the mustard
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
