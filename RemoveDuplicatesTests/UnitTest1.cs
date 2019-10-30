using System;
using Xunit;
using FluentAssertions;
using System.Collections.Generic;
using RemoveDuplicates;

namespace RemoveDuplicatesTests
{
    public class RemoveDuplicatesTests
    {
        [Fact]
        public void Test1()
        {
            var inputList = new List<int>();
            var expected = new List<int>();
            var actual = new Answer(inputList);

            actual.Should().Be(expected);
        }
    }
}
