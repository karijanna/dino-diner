/*  CretaceousCombo.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that represents the Cretaceous Combo option on the menu
    /// </summary>
    public class CretaceousCombo : IMenuItem
    {
        /// <summary>
        /// Getting the Entree options
        /// </summary>
        public Entree Entree { get; set; }
        /// <summary>
        /// Getting the Drink options
        /// </summary>
        public Drink Drink { get; set; }
        /// <summary>
        /// Getting the side options
        /// </summary>
        public Side Side { get; set; }
        /// <summary>
        /// Setting the default size to small
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// Getting the size options
        /// </summary>
        public Size Size
        {
            get { return size; }
            set {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }
        /// <summary>
        /// When making a combo, customers get 25 cents off of the order
        /// </summary>
        public double Price
        {
            get
            {
                return Drink.Price + Side.Price + Entree.Price - 0.25;
            }
            set
            {

            }
        }
        /// <summary>
        /// Getting the ingredients for the menu items
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }
        /// <summary>
        /// Method for converting the entree name to string
        /// </summary>
        /// <returns>The converted entree option as a combo into a string</returns>
        public override string ToString()
        {
            //return Entree.ToString() + " Combo";
            return $"{Entree} Combo";
        }
        /// <summary>
        /// Public constructor for Cretacous Combo
        /// </summary>
        private CretaceousCombo()
        {

        }
        /// <summary>
        /// Setting the default side and drink to Fryceritops and Sodasaurus
        /// </summary>
        /// <param name="entree">The entree options on the menu</param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }
        /// <summary>
        /// The total calories amount for the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Drink.Calories + Side.Calories + Entree.Calories;
            }
            set
            {

            }
        }
        /// <summary>
        /// Returns the description of the combo into string
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// Returns the combo items into string and to an array all together
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> ingredients = new List<string>();
                //ingredients.Add(Entree.ToString());
                ingredients.AddRange(Entree.Special);
                ingredients.Add(Side.ToString());
                ingredients.AddRange(Side.Special);
                ingredients.Add(Drink.ToString());
                ingredients.AddRange(Drink.Special);
                return ingredients.ToArray();
            }
        }
    }
}
