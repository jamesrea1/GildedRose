using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GildedRose.tests
{
    public class CheeseTests
    {
        [Fact]
        public void UpdateQuality_PositiveDaysToSell_QualityIncreasesByOne()
        {
            // Arrange
            Item i = new Cheese("Aged Brie", 10, 10);

            // Act
            i.UpdateQuality();

            //Assert
            Assert.Equal(11, i.Quality);
        }

        [Fact]
        public void UpdateQuality_QualityStartsAboveMax_UpdatesToMax50Limit()
        {
            // Arrange
            Item i = new Cheese("Aged Brie", 10, 55);

            // Act
            i.UpdateQuality();

            //Assert
            Assert.Equal(50, i.Quality);
        }



        

    }
}
