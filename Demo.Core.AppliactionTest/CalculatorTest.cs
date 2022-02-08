using Demo.Core.Application;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Demo.Core.AppliactionTest
{

    public class CalculatorData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
           yield return new object[] {5,2,3 };
           yield return new object[] {10,3,7 };
           yield return new object[] {8,2,6 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class CalculatorTest
    {
        //[Fact]
        //public void WhenInput2and3ShouldRetuen5()
        //{
        //    Calculator calculator = new Calculator();
        //    int result= calculator.Sum(2, 3);
        //    Assert.Equal(5, result);

        //}

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4,5,9)]
        [InlineData(5,7,12)]
        [Trait("math","primary")]
        public void CanSum(int value1,int value2,int expected)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Sum(value1, value2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(CalculatorData))]

        [Trait("math", "primary")]
        public void CanMinus(int value1,int value2,int expected)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Minus(value1, value2);

            Assert.Equal(expected, result);



        }

        [Theory]
        //[MemberData(nameof(InitData))]
        [MemberData(nameof(InitDataWithFilter),parameters:2)]

        [Trait("math", "secondary")]
        public void CanMultiply(int value1,int value2,int expected)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Multiply(value1, value2);

            Assert.Equal(expected, result);

        }


        public static IEnumerable<object[]> InitData() =>
            new List<object[]>
            {
                new object[]{3,5,15},
                new object[]{10,4,40},
                new object[]{20,4,80},
            };
        
        public static IEnumerable<object[]> InitDataWithFilter(int numTests)
        {
            var data = new List<object[]>
            {
                new object[]{3,5,15},
                new object[]{3,6,18},
                new object[]{10,4,40},
                new object[]{20,4,80},
            };
            return data.Take(numTests);
        }

    }
}
