using RPG_Characters.Charachters;
using System;
using Xunit;

namespace RPG_CharactersTests
{
    public class CharactersTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            int expected = 1;

            // Act
            Mage Peppi = new Mage();
            int actual = Peppi.Level;

            // Assert
            Assert.Equal(actual, expected);
        }
    }
}
