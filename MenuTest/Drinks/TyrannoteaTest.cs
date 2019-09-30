/*  TyrannoteaTest.cs
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
    public class TyrannoteaTest
    {
        //The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }
        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }
        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }
        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }
        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, tea.Size);
        }
        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, tea.Size);
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Tyrannotea tea = new Tyrannotea();
            List<string> ingredients = tea.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }
        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Contains<string>("Lemon", tea.Ingredients);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCaloriesWhenSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.MakeSweet = true;
            Assert.Equal<uint>(16, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCaloriesWhenSweetIsFalse()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.MakeSweet = true;
            tea.MakeSweet = false;
            Assert.Equal<uint>(8, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectMediumCaloriesWhenSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.MakeSweet = true;
            Assert.Equal<uint>(32, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectMediumCaloriesWhenSweetIsFalse()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.MakeSweet = true;
            tea.MakeSweet = false;
            Assert.Equal<uint>(16, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectLargeCaloriesWhenSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.MakeSweet = true;
            Assert.Equal<uint>(64, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectLargeCaloriesWhenSweetIsFalse()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.MakeSweet = true;
            tea.MakeSweet = false;
            Assert.Equal<uint>(32, tea.Calories);
        }
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }
        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }
    }
}

