using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Getting and setting the price 
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Gets a description of this order item
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Gets a special instructions for this order item
        /// </summary>
        string[] Special { get; }
    }
}
