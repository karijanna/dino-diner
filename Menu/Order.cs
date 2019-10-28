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
                return SubtotalCost + SalesTaxCost;
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
