using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using Xunit;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void OrderClassWorks()
        {
            Order order = new Order();
            order.Items.Add(new PrehistoricPBJ());
            order.Items.Add(new Sodasaurus());
            Assert.Equal(8.02, order.TotalCost);
        }
    }
}
