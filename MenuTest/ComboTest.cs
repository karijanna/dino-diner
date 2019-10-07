/*  ComboTest.cs
*   Author: Karijanna Miller
*/

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    /// <summary>
    /// Class that represents the test for Cretacious Combo
    /// </summary>
    public class ComboTest
    {
        public void ComboMustBeSuppliedAnEntree()
        {

        }

        [Fact]
        public void TestMenu()
        {
            Menu menu = new Menu();
            Assert.NotNull(menu.AvailableEntrees);
        }
    }
}
