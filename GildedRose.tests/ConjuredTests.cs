using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GildedRose.tests
{
    public class ConjuredTests
    {
        [Fact]
        public void UpdateQuality_PositiveDaysToSell_QualityDegradesByTwo()
        {
            // Arrange
            Item i = new Conjured("Conjured", 10, 10);

            // Act
            i.UpdateQuality();

            //Assert
            Assert.Equal(8, i.Quality);
        }

        [Fact]
        public void UpdateQuality_Expired_QualityDegradesByFour()
        {
            // Arrange
            Item i = new Conjured("Conjured", -1, 10);

            // Act
            i.UpdateQuality();

            //Assert
            Assert.Equal(6, i.Quality);
        }

        [Fact]
        public void UpdateQuality_QualityStartsAboveMax_UpdatesToMax50Limit()
        {
            // Arrange
            Item i = new Conjured("Conjured", 10, 55);

            // Act
            i.UpdateQuality();

            //Assert
            Assert.Equal(50, i.Quality);
        }

        

    }
}
