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
        [Fact]
        public void OrderTestMultipleTimes()
        {
            Order order = new Order();
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            order.Items.Add(dn);
            order.Items.Add(coffee);
            order.Items.Add(mmc);
            order.Items.Add(new VelociWrap());
            Assert.Equal(14.30, order.TotalCost);
        }
        [Fact]
        public void OrderTotalShouldNotBeNegative()
        {
            Order order = new Order();
            Fryceritops ft = new Fryceritops();
            ft.Price = -45;
            order.Items.Add(new PrehistoricPBJ());
            order.Items.Add(new Tyrannotea());
            order.Items.Add(ft);
            Assert.Equal(0, order.TotalCost);
        }
    }
}
