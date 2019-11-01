using System;
using Xunit;
using FluentAssertions;
using System.Collections.Generic;
using RemoveDuplicates;
using static RemoveDuplicates.Program;

namespace RemoveDuplicatesTests
{
    public class RemoveDuplicatesTests
    {
        [Fact]
        public void ReturnEmptyIfEmptyListIntegers()
        {
            var inputValues = new List<int>(){};
            var expected = new List<int>(){};
            var actual = Answer<int>.Deduplicate(inputValues);
           
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ReturnListForDistinctIntegers()
        {
            var inputValues = new List<int>(){1,2};
            var expected = new List<int>(){1,2};
            var actual = Answer<int>.Deduplicate(inputValues);
           
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ReturnListForNonDistinctIntegers()
        {
            var inputValues = new List<int>(){1,1,2,2,3,3};
            var expected = new List<int>(){1,2,3};
            var actual = Answer<int>.Deduplicate(inputValues);
           
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ReturnListForNonDistinctIntegersNonOrdered()
        {
            var inputValues = new List<int>(){1,2,3,1,2,3};
            var expected = new List<int>(){1,2,3};
            var actual = Answer<int>.Deduplicate(inputValues);
           
            actual.Should().BeEquivalentTo(expected);
        }

        
    }
}
