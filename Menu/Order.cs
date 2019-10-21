using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        private double price;
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();
        public double SubtotalCost
        {
            get
            {
                foreach(IOrderItem item in Items)
                {
                    price += item.Price;
                }
                if (price >= 0)
                {
                    return price;
                }
                else
                {
                    return 0;
                }
            }
        }
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }
        public double SalesTaxRate { get; set; } = 0;
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}
