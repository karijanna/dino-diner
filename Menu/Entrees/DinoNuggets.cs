/*  DinoNuggets.cs
*   Author: Karijanna Miller
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Dino Nuggets price, calories, and list of ingredients
    /// Contains method to add extra nuggets to the order
    /// </summary>
    public class DinoNuggets : Entree, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Count of nuggets when customer adds extra nugget count to the order
        /// </summary>
        private uint nuggetCount = 6;
        /// <summary>
        /// Adds the list of ingredients to the menu
        /// </summary>
        /// /// <summary>
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
                if (nuggetCount > 6) special.Add(string.Format("{0} Extra Nugget", nuggetCount - 6));
                return special.ToArray();
            }
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                for (int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }
        /// <summary>
        /// Price and calories of Dino Nuggest
        /// </summary>
        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 354;
        }
        /// <summary>
        /// Method adds an extra nugget onto the order
        /// Adds the appropriate extra amount for price and calories
        /// </summary>
        public void AddNugget()
        {
            nuggetCount++;
            Price += 0.25;
            Calories += 59;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
