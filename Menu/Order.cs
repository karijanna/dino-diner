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
    public class Order: INotifyPropertyChanged
    {
        private double price;
        List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// An event handler for property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        public  IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }

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
        public double SalesTaxCost
        {
            get
            {
                double cost = SalesTaxRate * SubtotalCost;
                cost = Math.Truncate(cost * 100) / 100;
                return cost;
            }
        }
        private double salesTaxRate = 0;
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

        public double TotalCost
        {
            get
            {
                return Math.Truncate((SubtotalCost + SalesTaxCost) * 100) / 100;
            }
        }
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
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyAllPropertiesChanged();
            }
            return removed;
        }
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyAllPropertiesChanged();
        }
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
