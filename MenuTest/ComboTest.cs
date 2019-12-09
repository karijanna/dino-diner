/*  ComboTest.cs
*   Author: Karijanna Miller
*/

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
    /// <summary>
    /// Class that represents the test for Cretacious Combo
    /// </summary>
    public class ComboTest
    {
        [Fact]
        public void ComboMustBeSuppliedAnEntree()
        {

        }

        [Fact]
        public void TestMenu()
        {
            //Menu Menu = new Menu();
            Assert.NotNull(Menu.AvailableEntrees);
        }
    }
}
