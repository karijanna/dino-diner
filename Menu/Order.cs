using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        private double price;
        public ObservableCollection<IOrderItem> Items { get; set; }
        public double SubtotalCost
        {
            get
            {
                foreach(IOrderItem item in Items)
                {
                    price += item.Price;
                }
                return price;
            }
        }
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }
        public double SalesTaxRate { get; set; } //protected
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}
