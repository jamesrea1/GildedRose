using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GildedRose.tests
{
    public class NormalItemTests
    {
        #region Test SellIn Updates

        [Fact]
        public void UpdateSellIn_PositiveDaysToSell_SellInDecrementsByOne()
        {
            // Arrange
            Item i = new Item("Normal Item", 5, 10);

            // Act
            i.UpdateSellIn();

            //Assert
            Assert.Equal(4, i.SellIn);
        }

        [Fact]
        public void UpdateSellIn_ZeroDaysToSell_SellInDecrementsByOne()
        {
            // Arrange
            Item i = new Item("Normal Item", 0, 10);

            // Act
            i.UpdateSellIn();

            //Assert
            Assert.Equal(-1, i.SellIn);
        }

        [Fact]
        public void UpdateSellIn_Expired_SellinDecrementsByOne()
        {
            // Arrange
            Item i = new Item("Normal Item", -1, 10);

            // Act
            i.UpdateSellIn();

            //Assert
            Assert.Equal(-2, i.SellIn);
        }

        #endregion


        #region Test Quality Updates

        [Fact]
        public void UpdateQuality_PositiveDaysToSell_QualityDecreasesByOne()
        {
            // Arrange
            Item i = new Item("Normal Item", 10, 10);

            // Act
            i.UpdateQuality();

            //Assert
            Assert.Equal(9, i.Quality);
        }

        [Fact]
        public void UpdateQuality_Expired_QualityDecreasesByTwo()
        {
            // Arrange
            Item i = new Item("Normal Item", -1, 10);

            // Act
            i.UpdateQuality();

            //Assert
            Assert.Equal(8, i.Quality);
        }

        [Fact]
        public void UpdateQuality_QualityStartsAboveMax_UpdatesToMax50Limit()
        {
            // Arrange
            Item i = new Item("Normal Item", 10, 55);

            // Act
            i.UpdateQuality();

            //Assert
            Assert.Equal(50, i.Quality);
        }

        #endregion




    }
}
