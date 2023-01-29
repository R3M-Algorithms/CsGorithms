using CsGorithms.Sorting;
using CsGorithms.UnitTests.Helpers;
using FluentAssertions;
using System;
using System.Linq;
using Xunit;

namespace CsGorithms.UnitTests.Sorting
{
    public class InsertionSortTests
    {
        [Fact]
        public void InsertionSort_ShouldDoNothing_WhenInputIsEmpty()
        {
            // Arrange
            var input = Enumerable.Empty<int>();

            // Act
            var result = InsertionSort.Sort(input);

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
        public void InsertionSort_ShouldSortAscending_WhenInputIsNotEmptyAndSortingOrderIsDefault(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).OrderBy(x => Guid.NewGuid());

            // Act
            var result = InsertionSort.Sort(input);

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
        public void InsertionSort_ShouldSortAscending_WhenInputIsNotEmptyAndSortingOrderIsAscending(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).OrderBy(x => Guid.NewGuid());

            // Act
            var result = InsertionSort.Sort(input);

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
        public void InsertionSort_ShouldSortDescending_WhenInputIsNotEmptyAndSortingOrderIsDescending(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).OrderBy(x => Guid.NewGuid());

            // Act
            var result = InsertionSort.Sort(input, SortingOrder.Descending);

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
        public void InsertionSort_ShouldSortAscending_WhenInputIsNotEmptyAndSortingKeyIsInformedSortingOrderIsDefault(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).Select(x => new PersonTest { Age = x }).OrderBy(x => Guid.NewGuid());

            // Act
            var result = InsertionSort.Sort(input, (x) => x.Age);

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
        public void InsertionSort_ShouldSortAscending_WhenInputIsNotEmptyAndSortingKeyIsInformedSortingOrderIsAscending(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).Select(x => new PersonTest { Age = x }).OrderBy(x => Guid.NewGuid());

            // Act
            var result = InsertionSort.Sort(input, (x) => x.Age, SortingOrder.Ascending);

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
        public void InsertionSort_ShouldSortDescending_WhenInputIsNotEmptyAndSortingKeyIsInformedSortingOrderIsDescending(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).Select(x => new PersonTest { Age = x }).OrderBy(x => Guid.NewGuid());

            // Act
            var result = InsertionSort.Sort(input, (x) => x.Age, SortingOrder.Descending);

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
        public void InsertionSort_ShouldSortAscending_WhenInputIsNotEmptyAndObjImplementsIComparableAndSortingOrderIsDefault(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).Select(x => new PersonTestComparable { Age = x }).OrderBy(x => Guid.NewGuid());

            // Act
            var result = InsertionSort.Sort(input);

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
        public void InsertionSort_ShouldSortAscending_WhenInputIsNotEmptyAndObjImplementsIComparableAndSortingOrderIsAscending(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).Select(x => new PersonTestComparable { Age = x }).OrderBy(x => Guid.NewGuid());

            // Act
            var result = InsertionSort.Sort(input);

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
        public void InsertionSort_ShouldSortDescending_WhenInputIsNotEmptyAndObjImplementsIComparableAndSortingOrderIsDescending(int elemCount)
        {
            // Arrange
            var input = Enumerable.Range(0, elemCount).Select(x => new PersonTestComparable { Age = x }).OrderBy(x => Guid.NewGuid());

            // Act
            var result = InsertionSort.Sort(input, SortingOrder.Descending);

            // Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().BeInDescendingOrder(z => z.Age);
        }
    }
}
