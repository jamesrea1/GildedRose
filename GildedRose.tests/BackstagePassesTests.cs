using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GildedRose.tests
{
    public class BackstagePassesTests
    {
        [Fact]
        public void UpdateQuality_OneDayToSell_QualityIncreasesByThree()
        {
            // Arrange
            Item i = new BackstagePasses("Backstage Classes", 1, 10);

            // Act
            i.UpdateQuality();

            //Assert
            Assert.Equal(13, i.Quality);
        }

        [Fact]
        public void UpdateQuality_FiveDaysToSell_QualityIncreasesByTwo()
        {
            // Arrange
            Item i = new BackstagePasses("Backstage Classes", 5, 10);

            // Act
            i.UpdateQuality();

            //Assert
            Assert.Equal(12, i.Quality);
        }

        [Fact]
        public void UpdateQuality_TenDaysToSell_QualityIncreasesByOne()
        {
            // Arrange
            Item i = new BackstagePasses("Backstage Classes", 10, 10);

            // Act
            i.UpdateQuality();

            //Assert
            Assert.Equal(11, i.Quality);
        }

        [Fact]
        public void UpdateQuality_Expired_QualityDropsToZero()
        {
            // Arrange
            Item i = new BackstagePasses("Backstage Classes", -1, 10);

            // Act
            i.UpdateQuality();

            //Assert
            Assert.Equal(0, i.Quality);
        }

        [Fact]
        public void UpdateQuality_QualityStartsAboveMax_UpdatesToMax50Limit()
        {
            // Arrange
            Item i = new BackstagePasses("Backstage Classes", 10, 55);

            // Act
            i.UpdateQuality();

            //Assert
            Assert.Equal(50, i.Quality);
        }




    }
}
