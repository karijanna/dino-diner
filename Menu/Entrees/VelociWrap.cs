/*  VelociWrap.cs
*   Author: Karijanna Miller
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Veloci Wrap price, calories, and list of ingredients
    /// Contains methods to take off certain ingredients if customer wants to
    /// </summary>
    public class VelociWrap : Entree, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Customers can ask for dressing off their order
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// Customers can ask for lettuce off their order
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Customers can ask for cheese off their order
        /// </summary>
        private bool cheese = true;
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
                if (!dressing) special.Add("Hold Dressing");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!cheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }
        /// <summary>
        /// The ingredients list that appears on the menu
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla" };
                ingredients.Add("Chicken Breast");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Defining the price and calories for the VelociWrap
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
        }

        /// <summary>
        /// Method to take off the dressing 
        /// </summary>
        public void HoldDressing()
        {
            dressing = false;
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
        /// Method to take off the cheese
        /// </summary>
        public void HoldCheese()
        {
            cheese = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
