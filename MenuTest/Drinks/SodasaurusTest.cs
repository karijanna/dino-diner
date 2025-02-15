﻿/*  SodasaurusTest.cs
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
    public class SodasaurusTest
    {
        ///The ability to set each possible flavor
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus soda = new DinoDiner.Menu.Drinks.Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, s.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, s.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, s.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, s.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, s.Flavor);
        }
        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus s = new DinoDiner.Menu.Drinks.Sodasaurus();
            s.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, s.Flavor);
        }
        //The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(1.50, soda.Price, 2);
        }
        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal(2.00, soda.Price, 2);
        }
        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal(2.50, soda.Price, 2);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }
        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }
        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }
        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, soda.Size);
        }
        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, soda.Size);
        }
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Sodasaurus soda = new Sodasaurus();
            List<string> ingredients = soda.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Natural Flavors", ingredients);
            Assert.Contains<string>("Cane Sugar", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }
        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }
        [Fact]
        public void HoldIceShouldNotifyChangesOfSpecialPropertyChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Special", () =>
            {
                soda.HoldIce();
            });
        }
        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Empty(soda.Special);
        }
        [Fact]
        public void SpecialShouldHoldIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.Collection<string>(soda.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }
        [Theory]
        [InlineData(Size.Small, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Small, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Small, SodasaurusFlavor.Cola)]
        [InlineData(Size.Small, SodasaurusFlavor.Lime)]
        [InlineData(Size.Small, SodasaurusFlavor.Orange)]
        [InlineData(Size.Small, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Small, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Medium, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cola)]
        [InlineData(Size.Medium, SodasaurusFlavor.Lime)]
        [InlineData(Size.Medium, SodasaurusFlavor.Orange)]
        [InlineData(Size.Medium, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Medium, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Large, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Large, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Large, SodasaurusFlavor.Cola)]
        [InlineData(Size.Large, SodasaurusFlavor.Lime)]
        [InlineData(Size.Large, SodasaurusFlavor.Orange)]
        [InlineData(Size.Large, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Large, SodasaurusFlavor.Vanilla)]
        public void SodaSaurusDescriptionShouldGiveNameForSizeAndFlavor(Size size, SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            soda.Flavor = flavor;
            Assert.Equal($"{size} {flavor} Sodasaurus", soda.Description);
        }
    }
}
