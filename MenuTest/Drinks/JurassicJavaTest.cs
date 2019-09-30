/*  JurassicJavaTest.cs
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
    public class JurassicJavaTest
    {
        //The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.Equal<double>(0.59, coffee.Price);
        }
        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Small;
            Assert.Equal<double>(0.59, coffee.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            Assert.Equal<double>(0.99, coffee.Price);
        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Large;
            Assert.Equal<double>(1.49, coffee.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
           JurassicJava coffee = new JurassicJava();
            Assert.Equal<uint>(2, coffee.Calories);
        }
        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            Assert.Equal<uint>(4, coffee.Calories);
        }
        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Large;
            Assert.Equal<uint>(8, coffee.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.Equal<Size>(Size.Small, coffee.Size);
        }
        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, coffee.Size);
        }
        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, coffee.Size);
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurassicJava coffee = new JurassicJava();
            List<string> ingredients = coffee.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }
       [Fact]
        public void ShouldAddtIce()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.AddIce();
            Assert.True(coffee.Ice);
        }
        [Fact]
        public void ShouldHaveDefaultSpaceForCream()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.False(coffee.RoomForCream);
        }
        [Fact]
        public void ShouldLeaveSpaceForCream()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.LeaveRoomForCream();
            Assert.True(coffee.RoomForCream);
        }
    }
}
