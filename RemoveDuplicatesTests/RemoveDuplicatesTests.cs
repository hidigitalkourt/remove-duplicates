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

        [Fact]
        public void ReturnEmptyIfEmptyListStrings()
        {
            var inputValues = new List<string>(){};
            var expected = new List<string>(){};
            var actual = Answer<string>.Deduplicate(inputValues);
           
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ReturnListForDistinctStrings()
        {
            var inputValues = new List<string>(){"way","out"};
            var expected = new List<string>(){"way","out"};
            var actual = Answer<string>.Deduplicate(inputValues);
           
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ReturnListForNonDistinctStrings()
        {
            var inputValues = new List<string>(){"way","way","out","out","yonder","yonder"};
            var expected = new List<string>(){"way","out","yonder"};
            var actual = Answer<string>.Deduplicate(inputValues);
           
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ReturnListForNonDistinctStringsNonOrdered()
        {
            var inputValues = new List<string>(){"way","out","yonder","way","out","yonder"};
            var expected = new List<string>(){"way","out","yonder"};
            var actual = Answer<string>.Deduplicate(inputValues);
           
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ReturnEmptyIfEmptyListChars()
        {
            var inputValues = new List<char>(){};
            var expected = new List<char>(){};
            var actual = Answer<char>.Deduplicate(inputValues);
           
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ReturnListForDistinctChars()
        {
            var inputValues = new List<char>(){'w','t'};
            var expected = new List<char>(){'w','t'};
            var actual = Answer<char>.Deduplicate(inputValues);
           
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ReturnListForNonDistinctChars()
        {
            var inputValues = new List<char>(){'w','w','t','t','r','r'};
            var expected = new List<char>(){'w','t','r'};
            var actual = Answer<char>.Deduplicate(inputValues);
           
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ReturnListForNonDistinctCharsNonOrdered()
        {
            var inputValues = new List<char>(){'w','t','r','w','t','r'};
            var expected = new List<char>(){'w','t','r'};
            var actual = Answer<char>.Deduplicate(inputValues);
           
            actual.Should().BeEquivalentTo(expected);
        }

        
    }
}
