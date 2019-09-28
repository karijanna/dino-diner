using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurassicJava : Drink
    {
        private Size size;
        private bool decaf = false;
        private bool roomForCream = false;
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
            }
        }
        public JurassicJava()
        {
            Size = Size.Small;
            Price = 0.59;
            Calories = 2;
        }
        public void LeaveRoomForCream()
        {
            roomForCream = true;
        }
        public void AddIce()
        {
            Ice = false;
        }
    }
}
