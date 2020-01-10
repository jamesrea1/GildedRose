using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GildedRose.tests
{
    public class LegendaryTests
    {
        [Fact]
        public void UpdateQuality_PositiveDaysToSell_NoChange()
        {
            // Arrange
            Item i = new Legendary("Sulfuras", 10, 10);

            // Act
            i.UpdateQuality();

            //Assert
            Assert.Equal(10, i.Quality);
        }

        [Fact]
        public void UpdateQuality_QualityStartsAtMax_NoChange()
        {
            // Arrange
            Item i = new Legendary("Sulfuras", 10, 50);

            // Act
            i.UpdateQuality();

            //Assert
            Assert.Equal(50, i.Quality);
        }

        [Fact]
        public void UpdateQuality_Expired_NoChange()
        {
            // Arrange
            Item i = new Legendary("Sulfuras", -1, 10);

            // Act
            i.UpdateQuality();

            //Assert
            Assert.Equal(10, i.Quality);
        }



        

    }
}
