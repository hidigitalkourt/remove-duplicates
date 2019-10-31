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
            var inputList = new List<int>(){};
            var expected = new List<int>(){};
            var answer = new Answer(inputList);
            var actual = answer.Elements;

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
