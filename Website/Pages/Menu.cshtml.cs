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
        public List<IMenuItem> MenuItems;

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
        public List<string> Ingredients;

        /// <summary>
        /// Method to operate when web page is running
        /// </summary>
        public void OnGet()
        {
            MenuItems = Menu.AvailableMenuItems;
            Ingredients = Menu.PossibleIngredients;
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
                MenuItems = Menu.Search(MenuItems, Search);
            }

            if (Category.Count != 0)
            {
                MenuItems = Menu.FilterByCategory(MenuItems, Category);
            }

            if (MinPrice != null)
            {
                MenuItems = Menu.FilterByMinPrice(MenuItems, (float)MinPrice);
            }

            if (MaxPrice != null)
            {
                MenuItems = Menu.FilterByMaxPrice(MenuItems, (float)MaxPrice);
            }

            if(ExcludeIngredients.Count != 0)
            {
                MenuItems = Menu.FilterByIngredients(MenuItems, ExcludeIngredients);
            }
        }
    }
}