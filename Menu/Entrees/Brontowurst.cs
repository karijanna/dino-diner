/*  Brontowurst.cs
*   Author: Karijanna Miller
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Brontowurst calories, price, and list of ingredients 
    /// Contains methods to take off certain ingredients if customers want to
    /// </summary>
    public class Brontowurst : Entree, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Customers can take off bun off of their order
        /// </summary>
        private bool wholeWheatBun = true;
        /// <summary>
        /// Customers can take off peppers off of their order
        /// </summary>
        private bool peppers = true;
        /// <summary>
        /// Customers can take of onions off of their order
        /// </summary>
        private bool onions = true;
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
        /// Gets and sets the description
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!wholeWheatBun) special.Add("Hold Whole Wheat Bun");
                if (!onions) special.Add("Hold Onions");
                if (!peppers) special.Add("Hold Peppers");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Adds the list of ingredietns to the menu
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }
        /// <summary>
        /// Price and calories of the Brontowurst
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
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
        /// Method to take off the peppers
        /// </summary>
        public void HoldPeppers()
        {
            peppers = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method to take off the onions
        /// </summary>
        public void HoldOnion()
        {
            onions = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
