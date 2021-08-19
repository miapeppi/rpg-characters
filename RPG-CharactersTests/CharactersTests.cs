using RPG_Characters.Charachters;
using System;
using Xunit;

namespace RPG_CharactersTests
{
    public class CharactersTests
    {
        #region Character creation
        [Fact]
        public void ConstructorMage_InitializegMage_ShouldCreateLevel1Mage()
        {
            // Arrange
            int startingLevel = 1;
            int expected = startingLevel;

            // Act
            Mage mage = new Mage("Gandalf");
            int actual = mage.HeroLevel;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConstructorMage_InitializeMage_ShouldCreateMageWithVitality5Stregth1Dexterity1Intelligence8()
        {
            // Arrange
            int expectedVitality = 5;
            int expectedStrength = 1;
            int expectedDexterity = 1;
            int expectedIntelligence = 8;
            Mage mage = new Mage("Gandalf");

            // Act
            int actualVitality = mage.BasePrimaryAttribute.Vitality;
            int actualStrength = mage.BasePrimaryAttribute.Strength;
            int actualDexterity = mage.BasePrimaryAttribute.Dexterity;
            int actualIntelligence = mage.BasePrimaryAttribute.Intelligence;

            // Assert
            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }

        [Fact]
        public void ConstructorRanger_InitializeRanger_ShouldCreateRangerWithVitality8Stregth1Dexterity7Intelligence1()
        {
            // Arrange
            int expectedVitality = 8;
            int expectedStrength = 1;
            int expectedDexterity = 7;
            int expectedIntelligence = 1;
            Ranger ranger = new Ranger("Legolas");

            // Act
            int actualVitality = ranger.BasePrimaryAttribute.Vitality;
            int actualStrength = ranger.BasePrimaryAttribute.Strength;
            int actualDexterity = ranger.BasePrimaryAttribute.Dexterity;
            int actualIntelligence = ranger.BasePrimaryAttribute.Intelligence;

            // Assert
            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }

        [Fact]
        public void ConstructorRogue_InitializeRogue_ShouldCreateRogueWithVitality8Stregth2Dexterity6Intelligence1()
        {
            // Arrange
            int expectedVitality = 8;
            int expectedStrength = 2;
            int expectedDexterity = 6;
            int expectedIntelligence = 1;
            Rogue rogue = new Rogue("Aragorn");

            // Act
            int actualVitality = rogue.BasePrimaryAttribute.Vitality;
            int actualStrength = rogue.BasePrimaryAttribute.Strength;
            int actualDexterity = rogue.BasePrimaryAttribute.Dexterity;
            int actualIntelligence = rogue.BasePrimaryAttribute.Intelligence;

            // Assert
            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }

        [Fact]
        public void ConstructorWarrior_InitializeWarrior_ShouldCreateWarriorWithVitality10Stregth5Dexterity2Intelligence1()
        {
            // Arrange
            int expectedVitality = 10;
            int expectedStrength = 5;
            int expectedDexterity = 2;
            int expectedIntelligence = 1;
            Warrior warrior = new Warrior("Boromir");

            // Act
            int actualVitality = warrior.BasePrimaryAttribute.Vitality;
            int actualStrength = warrior.BasePrimaryAttribute.Strength;
            int actualDexterity = warrior.BasePrimaryAttribute.Dexterity;
            int actualIntelligence = warrior.BasePrimaryAttribute.Intelligence;

            // Assert
            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }
        #endregion

        #region Leveling Up
        [Fact]
        public void LevelUpMage_MageGainsLevel_ShoudldLevelUpToLevel2()
        {
            // Arrange
            int leveledUpLevel = 2;
            int expected = leveledUpLevel;
            Mage mage = new Mage("Gandalf");

            // Act
            mage.LevelUp();
            int actual = mage.HeroLevel;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void LevelUpMage_MageGains0orNegativeLevels_ShoudlThrowArgumentException(int levels)
        {
            // Arrange
            Mage mage = new Mage("Gandalf");

            // Act & Assert
            Assert.Throws<ArgumentException>(() => mage.LevelUp(levels));
        }

        [Fact]
        public void LevelUpMage_MageGainLevel_ShouldHaveMageWithVitality8Strength2Dexterity2Intelligence13()
        {
            // Arrange
            int expectedVitality = 8;
            int expectedStrength = 2;
            int expectedDexterity = 2;
            int expectedIntelligence = 13;
            Mage mage = new Mage("Gandalf");

            // Act
            mage.LevelUp();
            int actualVitality = mage.BasePrimaryAttribute.Vitality;
            int actualStrength = mage.BasePrimaryAttribute.Strength;
            int actualDexterity = mage.BasePrimaryAttribute.Dexterity;
            int actualIntelligence = mage.BasePrimaryAttribute.Intelligence;

            // Arrange
            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }

        [Fact]
        public void LevelUpRanger_RangerGainLevel_ShouldHaveRangerWithVitality10Strength2Dexterity12Intelligence2()
        {
            // Arrange
            int expectedVitality = 10;
            int expectedStrength = 2;
            int expectedDexterity = 12;
            int expectedIntelligence = 2;
            Ranger ranger = new Ranger("Legolas");

            // Act
            ranger.LevelUp();
            int actualVitality = ranger.BasePrimaryAttribute.Vitality;
            int actualStrength = ranger.BasePrimaryAttribute.Strength;
            int actualDexterity = ranger.BasePrimaryAttribute.Dexterity;
            int actualIntelligence = ranger.BasePrimaryAttribute.Intelligence;

            // Arrange
            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }

        [Fact]
        public void LevelUpRogue_RogueGainLevel_ShouldHaveRogueWithVitality11Strength3Dexterity10Intelligence2()
        {
            // Arrange
            int expectedVitality = 11;
            int expectedStrength = 3;
            int expectedDexterity = 10;
            int expectedIntelligence = 2;
            Rogue rogue = new Rogue("Aragorn");

            // Act
            rogue.LevelUp();
            int actualVitality = rogue.BasePrimaryAttribute.Vitality;
            int actualStrength = rogue.BasePrimaryAttribute.Strength;
            int actualDexterity = rogue.BasePrimaryAttribute.Dexterity;
            int actualIntelligence = rogue.BasePrimaryAttribute.Intelligence;

            // Arrange
            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }

        [Fact]
        public void LevelUpWarrior_WarriorGainLevel_ShouldHaveWarriorWithVitality15Strength8Dexterity4Intelligence2()
        {
            // Arrange
            int expectedVitality = 15;
            int expectedStrength = 8;
            int expectedDexterity = 4;
            int expectedIntelligence = 2;
            Warrior warrior = new Warrior("Boromir");

            // Act
            warrior.LevelUp();
            int actualVitality = warrior.BasePrimaryAttribute.Vitality;
            int actualStrength = warrior.BasePrimaryAttribute.Strength;
            int actualDexterity = warrior.BasePrimaryAttribute.Dexterity;
            int actualIntelligence = warrior.BasePrimaryAttribute.Intelligence;

            // Arrange
            Assert.Equal(expectedVitality, actualVitality);
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
        }

        [Fact]
        public void LevelUpWarrior_WarriorGainLevel_ShouldHaveWarriorWithHealth150ArmorRating12ElementalResistance2()
        {
            // Arrange
            int expectedHealth = 150;
            int expectedArmorRating = 12;
            int expectedElementalResistance = 2;
            Warrior warrior = new Warrior("Boromir");
            warrior.LevelUp();

            // Act
            int actualHealt = warrior.SecondaryAttribute.Health;
            int actualArmorRating = warrior.SecondaryAttribute.ArmorRating;
            int actualElementalResistance = warrior.SecondaryAttribute.ElementalResistance;

            // Arrange
            Assert.Equal(expectedHealth, actualHealt);
            Assert.Equal(expectedArmorRating, actualArmorRating);
            Assert.Equal(expectedElementalResistance, actualElementalResistance);
        }
        #endregion
    }
}
