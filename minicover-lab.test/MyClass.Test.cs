using System;
using Xunit;

namespace minicover_lab.test
{
    public class MyClassTest
    {
        [Fact]
        public void It_should_return_8_when_passing_5_and_3()
        {
            // Arrange
            var target = new MyClass();

            // Act 
            var actual = target.Add(5, 3);

            // Assert
            Assert.Equal<int>(8, actual);

        }
    }
}
