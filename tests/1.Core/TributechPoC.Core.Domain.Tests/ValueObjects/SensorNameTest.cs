using Shouldly;
using TributechPoC.Domain.Exceptions;
using TributechPoC.Domain.ValueObjects;

namespace TributechPoC.Core.Domain.Tests.ValueObjects
{
    [Trait("Category", "ValueObject")]
    public class SensorNameTest
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("a")]        
        public void Should_ThrowInvalidValueObjectStateException_When_InputIsInvalid(string inputData)
        {
            //Arrange

            SensorName sensorName;
            //Act

            //Assert
            Should.Throw<InvalidValueObjectStateException>(() => sensorName = new SensorName(inputData));
        }
    }
}
