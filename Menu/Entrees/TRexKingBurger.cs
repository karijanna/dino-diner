/*  TRexKingBurger.cs
*   Author: Karijanna Miller
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// T-Rex King Burger price, calories, and list of ingredients
    /// Contains methods to take off certain ingredients if customers wants to 
    /// </summary>
    public class TRexKingBurger : Entree, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Customers can ask for the bun off of their order
        /// </summary>
        private bool wholeWheatBun = true;
        /// <summary>
        /// Customers can ask for lettuce off of their order
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Customers can ask for tomatoes off of their order
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// Customers can ask for onions off of their order
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// Customers can ask for pickels off of their order
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Customers can ask for ketchup off of their order
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Customers can ask for mustard off of their order
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// Customers can ask for mayo off of their order
        /// </summary>
        private bool mayo = true;
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
                if (!lettuce) special.Add("Hold Lettuce");
                if (!tomato) special.Add("Hold Tomato");
                if (!onion) special.Add("Hold Onion");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Adds the following ingredients to the menu
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Price and calories for the T-Rex King Burger
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
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
        /// Method to take off the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method to take off the tomato
        /// </summary>
        public void HoldTomato()
        {
            tomato = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method to take off the onion
        /// </summary>
        public void HoldOnion()
        {
            onion = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method to take off the pickle
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
        /// <summary>
        /// Mehotd to take off the mayo
        /// </summary>
        public void HoldMayo()
        {
            mayo = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }

}
