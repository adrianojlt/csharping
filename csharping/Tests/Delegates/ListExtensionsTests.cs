﻿namespace csharping.Tests.Delegates
{
    using csharping.Delegates;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class ListExtensionsTests
    {
        private List<string> names = new List<string>() { "Alice", "john", "Bobby", "Kyle", "Tod", "Armin", "George" };

        [Theory]
        [InlineData(1, 7)]
        [InlineData(3, 6)]
        [InlineData(6, 0)]
        public void Names_In_List_with_More_Than(int nameLength, int expected)
        {
            // Assert
            int result = names.MoreThan(nameLength).Count();

            // Result
            Assert.AreEqual(result, expected);
        }


        [Theory]
        [InlineData(2, 0)]
        [InlineData(4, 1)]
        [InlineData(5, 3)]
        [InlineData(10, 7)]
        public void Names_In_List_with_Less_Than(int nameLength, int expected)
        {
            // Assert
            int result = names.LessThan(nameLength).Count();

            // Result
            Assert.AreEqual(result, expected);
        }

        [Theory]
        [InlineData(6, 1)]
        public void Names_In_List_With_Exactly(int nameLength, int expected)
        {
            // Assert
            int result = names.Exactly(nameLength).Count();

            // Result
            Assert.AreEqual(result, expected);
        }

        [Fact]
        public void List_Is_Null()
        {
            // Arrange
            List<string> emptyList = null;

            // Assert
            int result = emptyList.Exactly(0).Count();

            // Result
            Assert.AreEqual(result, 0);
        }

        [Fact]
        public void List_Is_Empty()
        {
            // Arrange
            List<string> emptyList = Enumerable.Empty<string>().ToList();

            // Assert
            int result = emptyList.Exactly(0).Count();

            // Result
            Assert.AreEqual(result, 0);
        }
    }
}
