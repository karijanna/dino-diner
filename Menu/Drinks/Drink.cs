using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public abstract class Drink
    {
        public abstract Size Size { get; set; }
        public double Price { get; set; }
        public uint Calories { get; set; }
        public virtual List<string> Ingredients { get; set; }
        public bool Ice = true;
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
