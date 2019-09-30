/*  WaterTest.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal(0.10, water.Price, 2);
        }
        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Water water = new Water();
            Assert.Equal(0.10, water.Price, 2);
            water.Size = Size.Medium;
        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Water water = new Water();
            Assert.Equal(0.10, water.Price, 2);
            water.Size = Size.Large;
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }
        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
            water.Size = Size.Medium;
        }
        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
            water.Size = Size.Large;
        }
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }
        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
            water.Size = Size.Medium;
        }
        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
            water.Size = Size.Large;
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Water water = new Water();
            List<string> ingredients = water.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Equal<int>(1, ingredients.Count);
        }
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }
        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }
        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Contains<string>("Lemon", water.Ingredients);
        }
    }
}
