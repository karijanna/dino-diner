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
        [Fact]
        public void AddIceShouldNotifyChangesOfSpecialPropertyChange()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.PropertyChanged(coffee, "Special", () =>
            {
                coffee.AddIce();
            });
        }
        [Fact]
        public void LeaveRoomForCreamShouldNotifyChangesOfSpecialPropertyChange()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.PropertyChanged(coffee, "Special", () =>
            {
                coffee.LeaveRoomForCream();
            });
        }
        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.Empty(coffee.Special);
        }
        [Fact]
        public void SpecialShouldAddIce()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.AddIce();
            Assert.Collection<string>(coffee.Special,
            item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }
        [Fact]
        public void SpecialShouldLeaveRoomForCream()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.LeaveRoomForCream();
            Assert.Collection<string>(coffee.Special,
            item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            });
        }
        [Fact]
        public void SpecialShouldHoldOrAddAllSpecials()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.AddIce();
            coffee.LeaveRoomForCream();
            Assert.Collection<string>(coffee.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                },
                item =>
                {
                    Assert.Equal("Leave Room For Cream", item);
                });
        }
        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void JurrasicJavaDescriptionShouldGiveNameForSizeAndDecaf(Size size, bool decaf)
        {
            JurassicJava java = new JurassicJava();
            java.Size = size;
            java.Decaf = decaf;
            if (decaf) Assert.Equal($"{size} Decaf Jurassic Java", java.ToString());
            else Assert.Equal($"{size} Jurassic Java", java.ToString());
        }
    }
}
