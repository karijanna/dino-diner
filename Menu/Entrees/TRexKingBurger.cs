using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    public class TRexKingBurger
    {
        private bool wholeWheatBun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Patties" };
                if (wholeWheatBun) ingredients.Add("Whole-wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomatoes");
                if (onion) ingredients.Add("Onions");
                if (pickle) ingredients.Add("Pickles");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        public void HoldWholeWheatBun()
        {
            this.wholeWheatBun = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldTomato()
        {
            this.tomato = false;
        }

        public void HoldOnion()
        {
            this.onion = false;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }

        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        
        public void HoldMustard()
        {
            this.mustard = false;
        }

        public void HoldMayo()
        {
            this.mayo = false;
        }
    }

}
