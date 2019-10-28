﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The PropertyChanged event handler 
        /// Notifies of changes to the Price, Description, and Special properties
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Helper function for notifying of property changes
        /// </summary>
        /// <param name="propertyName">Name of the property that is changed</param>
        public abstract void NotifyOfPropertyChange(string propertyName);
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }
        /// <summary>
        /// 
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// 
        /// </summary>
        public abstract string[] Special { get; }
    }
}
