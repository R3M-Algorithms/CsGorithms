using CsGorithms.Sorting;
using CsGorithms.UnitTests.Helpers;
using FluentAssertions;
using System;
using System.Linq;
using Xunit;

namespace CsGorithms.UnitTests.Sorting
{
    public class BubbleSortTests
    {
        [Fact]
        public void BubbleSort_ShouldDoNothing_WhenInputIsEmpty()
        {
            // Arrange
            var input = Enumerable.Empty<int>();

            // Act
            var result = BubbleSort.Sort(input);

            // Assert
            result.Should().NotBeNull();
            result.Should().BeEmpty();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        [InlineData(512)]
        [InlineData(1024)]
        [InlineData(2096)]
        [InlineData(4192)]
        public void BubbleSort_ShouldSortAscending_WhenInputIsNotEmptyAndSortingOrderIsDefault(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).OrderBy(x => Guid.NewGuid());

            // Act
            var result = BubbleSort.Sort(input);

            // Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().BeInAscendingOrder();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        [InlineData(512)]
        [InlineData(1024)]
        [InlineData(2096)]
        [InlineData(4192)]
        public void BubbleSort_ShouldSortAscending_WhenInputIsNotEmptyAndSortingOrderIsAscending(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).OrderBy(x => Guid.NewGuid());

            // Act
            var result = BubbleSort.Sort(input);

            // Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().BeInAscendingOrder();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        [InlineData(512)]
        [InlineData(1024)]
        [InlineData(2096)]
        [InlineData(4192)]
        public void BubbleSort_ShouldSortDescending_WhenInputIsNotEmptyAndSortingOrderIsDescending(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).OrderBy(x => Guid.NewGuid());

            // Act
            var result = BubbleSort.Sort(input, SortingOrder.Descending);

            // Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().BeInDescendingOrder();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        [InlineData(512)]
        [InlineData(1024)]
        [InlineData(2096)]
        [InlineData(4192)]
        public void BubbleSort_ShouldSortAscending_WhenInputIsNotEmptyAndSortingKeyIsInformedSortingOrderIsDefault(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).Select(x => new PersonTest { Age = x }).OrderBy(x => Guid.NewGuid());

            // Act
            var result = BubbleSort.Sort(input, (x) => x.Age);

            // Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().BeInAscendingOrder(z => z.Age);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        [InlineData(512)]
        [InlineData(1024)]
        [InlineData(2096)]
        [InlineData(4192)]
        public void BubbleSort_ShouldSortAscending_WhenInputIsNotEmptyAndSortingKeyIsInformedSortingOrderIsAscending(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).Select(x => new PersonTest { Age = x }).OrderBy(x => Guid.NewGuid());

            // Act
            var result = BubbleSort.Sort(input, (x) => x.Age, SortingOrder.Ascending);

            // Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().BeInAscendingOrder(z => z.Age);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        [InlineData(512)]
        [InlineData(1024)]
        [InlineData(2096)]
        [InlineData(4192)]
        public void BubbleSort_ShouldSortDescending_WhenInputIsNotEmptyAndSortingKeyIsInformedSortingOrderIsDescending(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).Select(x => new PersonTest { Age = x }).OrderBy(x => Guid.NewGuid());

            // Act
            var result = BubbleSort.Sort(input, (x) => x.Age, SortingOrder.Descending);

            // Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().BeInDescendingOrder(z => z.Age);
        }

        /////
        ///

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        [InlineData(512)]
        [InlineData(1024)]
        [InlineData(2096)]
        [InlineData(4192)]
        public void BubbleSort_ShouldSortAscending_WhenInputIsNotEmptyAndObjImplementsIComparableAndSortingOrderIsDefault(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).Select(x => new PersonTestComparable { Age = x }).OrderBy(x => Guid.NewGuid());

            // Act
            var result = BubbleSort.Sort(input);

            // Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().BeInAscendingOrder(z => z.Age);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        [InlineData(512)]
        [InlineData(1024)]
        [InlineData(2096)]
        [InlineData(4192)]
        public void BubbleSort_ShouldSortAscending_WhenInputIsNotEmptyAndObjImplementsIComparableAndSortingOrderIsAscending(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).Select(x => new PersonTestComparable { Age = x }).OrderBy(x => Guid.NewGuid());

            // Act
            var result = BubbleSort.Sort(input);

            // Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().BeInAscendingOrder(z => z.Age);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]
        [InlineData(512)]
        [InlineData(1024)]
        [InlineData(2096)]
        [InlineData(4192)]
        public void BubbleSort_ShouldSortDescending_WhenInputIsNotEmptyAndObjImplementsIComparableAndSortingOrderIsDescending(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).Select(x => new PersonTestComparable { Age = x }).OrderBy(x => Guid.NewGuid());

            // Act
            var result = BubbleSort.Sort(input, SortingOrder.Descending);

            // Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().BeInDescendingOrder(z => z.Age);
        }
    }
}
