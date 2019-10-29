/* Order.cs
 * Author: Karijanna Miller
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Calculates the order item total, subtotal, and taxes
    /// Populates the order control interface
    /// </summary>
    public class Order: INotifyPropertyChanged
    {
        /// <summary>
        /// Private variable for price
        /// </summary>
        private double price;
        /// <summary>
        /// New list for the menu items to populate
        /// </summary>
        List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// An event handler for property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Returns all the items on the order into an array
        /// </summary>
        public  IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }
        /// <summary>
        /// Calculates the subtotal cost
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subTotal = 0;
                foreach (IOrderItem io in items)
                {
                    subTotal += io.Price;
                }
                if (subTotal > 0) return Math.Truncate(subTotal * 100) / 100;
                else return 0; 
            }
        }
        /// <summary>
        /// Calculates the sales tax into the cost
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                double cost = SalesTaxRate * SubtotalCost;
                cost = Math.Truncate(cost * 100) / 100;
                return cost;
            }
        }
        /// <summary>
        /// Private variable to calculate sales tax rate
        /// </summary>
        private double salesTaxRate = 0;
        /// <summary>
        /// Calculates the sales tax rate
        /// </summary>
        public double SalesTaxRate { 
            get
            {
                return salesTaxRate;
            }
            set
            {
                salesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }
        /// <summary>
        /// Calculates the total cost 
        /// </summary>
        public double TotalCost
        {
            get
            {
                return Math.Truncate((SubtotalCost + SalesTaxCost) * 100) / 100;
            }
        }
        /// <summary>
        /// Constructor for the order.cs
        /// </summary>
        public Order()
        {
            //Items.Add(new SteakosaurusBurger());
        }
        /// <summary>
        /// Adds a new item to our order
        /// </summary>
        /// <param name="item">The new item</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyAllPropertiesChanged();
        }
        /// <summary>
        /// Method for removing items of the order control
        /// </summary>
        /// <param name="item">Menu item on the order list</param>
        /// <returns>The removed item</returns>
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyAllPropertiesChanged();
            }
            return removed;
        }
        /// <summary>
        /// Method for setting the property change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyAllPropertiesChanged();
        }
        /// <summary>
        /// Method for calling the property change
        /// </summary>
        protected void NotifyAllPropertiesChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
        /*private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }*/
        /*public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            Items.Add(item);
        }*/
    }
}
