using Bogus;
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
            var faker = new Faker();
            var input = Enumerable.Range(0, elemCount).Select(_ => faker.Random.Int());

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
            var faker = new Faker();
            var input = Enumerable.Range(0, elemCount).Select(_ => faker.Random.Int());

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
            var faker = new Faker();
            var input = Enumerable.Range(0, elemCount).Select(_ => faker.Random.Int());

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
            var input = new PersonTestBuilder(elemCount)
                .WithRandomNames()
                .WithRandomAges()
                .Build();

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
            var input = new PersonTestBuilder(elemCount)
                .WithRandomNames()
                .WithRandomAges()
                .Build();

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
            var input = new PersonTestBuilder(elemCount)
                .WithRandomNames()
                .WithRandomAges()
                .Build();

            // Act
            var result = BubbleSort.Sort(input, (x) => x.Age, SortingOrder.Descending);

            // Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().BeInDescendingOrder(z => z.Age);
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
        public void BubbleSort_ShouldSortAscending_WhenInputIsNotEmptyAndSortingKeyIsInformedSortingOrderIsDefaultAndComparisonIsComplex(int elemCount)
        {
            // Arrange            
            var input = new PersonTestBuilder(elemCount)
                .WithRandomNames()
                .WithRandomAges()
                .Build();

            // Act
            var result = BubbleSort.Sort(input, (x) => x.Name);

            // Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().BeInAscendingOrder(z => z.Name);
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
        public void BubbleSort_ShouldSortAscending_WhenInputIsNotEmptyAndSortingKeyIsInformedSortingOrderIsAscendingAndComparisonIsComplex(int elemCount)
        {
            // Arrange
            var input = new PersonTestBuilder(elemCount)
                .WithRandomNames()
                .WithRandomAges()
                .Build();

            // Act
            var result = BubbleSort.Sort(input, (x) => x.Name, SortingOrder.Ascending);

            // Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().BeInAscendingOrder(z => z.Name);
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
        public void BubbleSort_ShouldSortDescending_WhenInputIsNotEmptyAndSortingKeyIsInformedSortingOrderIsDescendingAndComparisonIsComplex(int elemCount)
        {
            // Arrange
            var input = new PersonTestBuilder(elemCount)
                .WithRandomNames()
                .WithRandomAges()
                .Build();

            // Act
            var result = BubbleSort.Sort(input, (x) => x.Name, SortingOrder.Descending);

            // Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().BeInDescendingOrder(z => z.Name);
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
        public void BubbleSort_ShouldSortAscending_WhenInputIsNotEmptyAndObjImplementsIComparableAndSortingOrderIsDefault(int elemCount)
        {
            // Arrange
            var input = new PersonTestComparableBuilder(elemCount)
                .WithRandomNames()
                .WithRandomAges()
                .Build();

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
            var input = new PersonTestComparableBuilder(elemCount)
                .WithRandomNames()
                .WithRandomAges()
                .Build();

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
            var input = new PersonTestComparableBuilder(elemCount)
                .WithRandomNames()
                .WithRandomAges()
                .Build();

            // Act
            var result = BubbleSort.Sort(input, SortingOrder.Descending);

            // Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().BeInDescendingOrder(z => z.Age);
        }
    }
}
