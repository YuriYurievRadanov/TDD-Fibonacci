using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Fibonacci.Test
{
    public class FibonacciTest
    {
        //[Fact]
        //public void FirstNumberInSequenceIsZero()
        //{
        //    Assert.Equal(0, new Fibonacci().GetNumber(0));
        //}

        //[Fact]
        //public void SecondNumberInSequenceIsOne()
        //{
        //    Assert.Equal(1, new Fibonacci().GetNumber(1));
        //}

        //[Theory]
        //[InlineData(0, 0)]
        //[InlineData(1, 1)]     
        //public void FirstTwoNumbersAreSameAsIndex(int index, int expected)
        //{
        //    Assert.Equal(expected, new Fibonacci().GetNumber(index));
        //}

        //[Theory]
        //[InlineData(0, 0)]
        //[InlineData(1, 1)]
        //[InlineData(2, 1)]
        //public void FirstTwoNumbersAreSameAsIndex(int index, int expected)
        //{
        //    Assert.Equal(expected, new Fibonacci().GetNumber(index));
        //}


        //[Theory]
        //[InlineData(0, 0)]
        //[InlineData(1, 1)]
        //[InlineData(2, 1)]
        //[InlineData(3, 2)]
        //public void FirstTwoNumbersAreSameAsIndex(int index, int expected)
        //{
        //    Assert.Equal(expected, new Fibonacci().GetNumber(index));
        //}


        //[Theory]
        //[InlineData(0, 0)]
        //[InlineData(1, 1)]
        //[InlineData(2, 1)]
        //[InlineData(3, 2)]
        //[InlineData(4, 3)]
        //public void FirstTwoNumbersAreSameAsIndex(int index, int expected)
        //{
        //    Assert.Equal(expected, new Fibonacci().GetNumber(index));
        //}

        [Theory]
        [InlineData(6, 8)]
        public void FirstTwoNumbersAreSameAsIndex(int index, int expected)
        {
            Assert.Equal(expected, new Fibonacci().GetNumber(index));
        }
    }
}
