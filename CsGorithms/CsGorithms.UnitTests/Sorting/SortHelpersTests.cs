using CsGorithms.Sorting;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CsGorithms.UnitTests.Sorting
{
    public class SortHelpersTests
    {
        [Fact]
        public void IsOrdered_ShouldReturn_WhenSortingOrderIsAscending()
        {
            // Arrange
            var sortingOrder = SortingOrder.Ascending;

            // Act
            var func = SortHelpers.IsOrdered(sortingOrder);

            // Assert
            func(1).Should().Be(false);
            func(0).Should().Be(true);
            func(-1).Should().Be(true);
        }

        [Fact]
        public void IsOrdered_ShouldReturn_WhenSortingOrderIsDescending()
        {
            // Arrange
            var sortingOrder = SortingOrder.Descending;

            // Act
            var func = SortHelpers.IsOrdered(sortingOrder);

            // Assert
            func(1).Should().Be(true);
            func(0).Should().Be(true);
            func(-1).Should().Be(false);
        }

        [Fact]
        public void IsOrdered_ShouldThrow_WhenSortingOrderIsUnknown()
        {
            // Arrange
            var sortingOrder = SortingOrder.Descending + 1;

            // Act
            var func = () => SortHelpers.IsOrdered(sortingOrder);

            // Assert
            func.Should().ThrowExactly<KeyNotFoundException>();
        }
    }
}
