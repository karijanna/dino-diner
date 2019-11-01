using System.Collections.Generic;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged, IOrderItem
{
        /// <summary>
        /// Customers can take off bun off of their order
        /// </summary>
        private bool jelly = true;
        /// <summary>
        /// Customers can take off peppers off of their order
        /// </summary>
        private bool peanutButter = true;
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
                if (!jelly) special.Add("Hold Jelly");
                if (!peanutButter) special.Add("Hold Peanut Butter");
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
                if (jelly) ingredients.Add("Jelly");
                if (peanutButter) ingredients.Add("Peanut Butter");
                return ingredients;
            }
        }
        /// <summary>
        /// Price and calories of the Brontowurst
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
        }
        /// <summary>
        /// Method to take off the bun
        /// </summary>
        public void HoldJelly()
        {
            jelly = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Method to take off the peppers
        /// </summary>
        public void HoldPeanutButter()
        {
            peanutButter = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Turns the order into a string
        /// </summary>
        /// <returns>The readable version of the order</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
