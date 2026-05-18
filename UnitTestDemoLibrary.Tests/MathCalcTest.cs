using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace UnitTestDemoLibrary.Tests
{
    public class MathCalcTest
    {
        [Fact]
        public void CalcShouldReturnExceptionWhenDivideedByZero()
        {
            MathCalculation calc = new MathCalculation();
            Assert.Throws<DivideByZeroException>(() => calc.Calc(10, 0, '/'));
        }
        [Theory]
        [InlineData(2,3,'+',5),
         InlineData(5,4,'-',1),
         InlineData(3,6,'*',18),
         InlineData(8,2,'/',4)]
       // [InlineData(10,0,'/',69)]
        public void CalcShouldReturnTheCorrect(double a,double b,char c,double exp)
        {
            MathCalculation calc = new MathCalculation();
            double rslt = calc.Calc(a,b,c);
            Assert.Equal(exp, rslt);
        }
    }
}
