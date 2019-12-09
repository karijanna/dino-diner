using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        /// <summary>
        /// Menu items displayed on the webpage
        /// </summary>
        public IEnumerable<IMenuItem> MenuItems;

        /// <summary>
        /// Search bar string
        /// </summary>
        [BindProperty]
        public string Search { get; set; }

        /// <summary>
        /// Checked categories in a list
        /// </summary>
        [BindProperty]
        public List<string> Category { get; set; } = new List<string>();

        /// <summary>
        /// Mininum price on filter
        /// </summary>
        [BindProperty]
        public float? MinPrice { get; set; }

        /// <summary>
        /// Max price on filter
        /// </summary>
        [BindProperty]
        public float? MaxPrice { get; set; }

        /// <summary>
        /// Ingredients to exclude from menu item
        /// </summary>
        [BindProperty]
        public List<string> ExcludeIngredients { get; set; } = new List<string>();

        /// <summary>
        /// List of all ingredients on menu item
        /// </summary>
        public IEnumerable<string> Ingredients;

        /// <summary>
        /// Method to operate when web page is running
        /// </summary>
        public void OnGet()
        {
            MenuItems = Menu.AvailableMenuItems.OrderBy(menuItem => menuItem.Category);
            Ingredients = Menu.PossibleIngredients.OrderBy(ingredient => ingredient.ToString());
        }

        /// <summary>
        /// Method that operates when user is using the webpage
        /// </summary>
        public void OnPost()
        {
            MenuItems = Menu.AvailableMenuItems;
            Ingredients = Menu.PossibleIngredients;

            if (Search != null)
            {
                MenuItems = MenuItems.Where(menuItem => menuItem.ToString().Contains(Search, StringComparison.OrdinalIgnoreCase));
            }

            if (Category.Count != 0)
            {
                MenuItems = MenuItems.Where(menuItem => Category.Contains(menuItem.Category));
            }

            if (MinPrice != null)
            {
                MenuItems = MenuItems.Where(menuItem => menuItem.Price >= MinPrice);
            }

            if (MaxPrice != null)
            {
                MenuItems = MenuItems.Where(menuItem => menuItem.Price <= MaxPrice);
            }

            if(ExcludeIngredients.Count != 0)
            {
                foreach (string s in ExcludeIngredients)
                {
                    MenuItems = MenuItems.Where(menuItem => !menuItem.Ingredients.Contains(s));
                }
            }
        }
    }
}