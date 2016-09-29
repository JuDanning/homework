using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculator;
namespace CalculatorTest
{
    public class CalculatorTest
    {
        [Fact]
        public void shoule_return_10_when_given_1km()
        {
            //Given
            double length = 1;
            Calculator.Calculator cal = new Calculator.Calculator();

            //When
            double fee = cal.Calculate(length);

            //Then
            Assert.Equal(10, fee);
        }
        [Fact]
        public void shoule_return_10_when_given_2km()
        {
            //Given
            double length = 2;
            Calculator.Calculator cal = new Calculator.Calculator();

            //When
            double fee = cal.Calculate(length);

            //Then
            Assert.Equal(10, fee);
        }

        [Fact]
        public void shoule_return_14_when_given_6km()
        {
            //Given
            double length = 6;
            Calculator.Calculator cal = new Calculator.Calculator();

            //When
            double fee = cal.Calculate(length);

            //Then
            Assert.Equal(14, fee);
        }

        [Fact]
        public void shoule_return_16_when_given_8km()
        {
            //Given
            double length = 8;
            Calculator.Calculator cal = new Calculator.Calculator();

            //When
            double fee = cal.Calculate(length);

            //Then
            Assert.Equal(16, fee);
        }
       
        [Fact]
        public void shoule_return_18_4_when_given_10km()
        {
            //Given
            double length = 10;
            Calculator.Calculator cal = new Calculator.Calculator();

            //When
            double fee = cal.Calculate(length);

            //Then
            Assert.Equal(18.4, fee);
        }

        [Fact]
        public void shoule_return_20_9_when_given_10km_and_5min()
        {
            //Given
            double length = 10;
            double time = 5;
            Calculator.Calculator cal = new Calculator.Calculator();

            //When
            double fee = cal.Calculate(length,time);

            //Then
            Assert.Equal(20.9, fee);
        }

        [Fact]
        public void shoule_return_16_5_when_given_7km_and_3min()
        {
            //Given
            double length = 7;
            double time = 3;
            Calculator.Calculator cal = new Calculator.Calculator();

            //When
            double fee = cal.Calculate(length, time);

            //Then
            Assert.Equal(16.5, fee);
        }
    }
}
