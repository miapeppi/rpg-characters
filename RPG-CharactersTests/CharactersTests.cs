using RPG_Characters.Charachters;
using System;
using Xunit;

namespace RPG_CharactersTests
{
    public class CharactersTests
    {
        [Fact]
        public void Mage_CreatingMage_ShouldCreateLevel1Mage()
        {
            // Arrange
            int expected = 1;

            // Act
            Mage mage = new Mage();
            int actual = mage.Level;

            // Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Ranger_CreatingRanger_ShouldCreateLevel1Ranger()
        {
            // Arrange
            int expected = 1;

            // Act
            Ranger ranger = new Ranger();
            int actual = ranger.Level;

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Rogue_CreatingRogue_ShouldCreateLevel1Rogue()
        {
            // Arrange
            int expected = 1;

            // Act
            Rogue rogue = new Rogue();
            int actual = rogue.Level;

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Warrior_CreatingWarrior_ShouldCreateLevel1Warrior()
        {
            // Arrange
            int expected = 1;

            // Act
            Warrior warrior = new Warrior();
            int actual = warrior.Level;

            // Assert
            Assert.Equal(actual, expected);
        }
    }
}
