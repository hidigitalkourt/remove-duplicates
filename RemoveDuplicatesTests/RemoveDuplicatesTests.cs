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
        public void ReturnEmptyIfEmpty()
        {
            var inputList = new List<int>(){};
            var expected = new List<int>(){};
            var actual = Answer.Deduplicate(inputList);
           
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ReturnListForDistinctValues()
        {
            var inputList = new List<int>(){1,2};
            var expected = new List<int>(){1,2};
            var actual = Answer.Deduplicate(inputList);
           
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ReturnListForNonDistinctValues()
        {
            var inputList = new List<int>(){1,1,2,2,3,3};
            var expected = new List<int>(){1,2,3};
            var actual = Answer.Deduplicate(inputList);
           
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ReturnListForNonDistinctValuesNonOrdered()
        {
            var inputList = new List<int>(){1,2,3,1,2,3};
            var expected = new List<int>(){1,2,3};
            var actual = Answer.Deduplicate(inputList);
           
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
