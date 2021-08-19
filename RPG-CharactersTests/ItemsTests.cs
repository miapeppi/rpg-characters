using RPG_Characters.Charachters;
using RPG_Characters.Items;
using System;
using Xunit;

namespace RPG_CharactersTests
{
    public class ItemsTests
    {
        #region Equipping items

        [Fact]
        public void EquipItem_WarriorTryToEquipAxeWhichIsTooHighLevel_ShouldTrowInvalidWeaponException()
        {
            // Arrange
            Warrior warrior = new Warrior("Boromir");
            Weapon commonAxe = new Weapon()
            {
                ItemName = "Common axe",
                ItemLevel = 2,
                EquippingSlot = Item.Slot.Weapon,
                WeaponType = Weapon.WeaponTypes.Axe,
                WeaponAttribute = new WeaponAttribute() { Damage = 7, AttackSpeed = 1.1 }
            };

            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => warrior.EquipItem(commonAxe));
        }

        [Fact]
        public void EquipItem_WarriorTryToEquipPlateArmorWhichIsTooHighLevel_ShouldTrowInvalidArmorException()
        {
            // Arrange
            Warrior warrior = new Warrior("Boromir");
            Armor commonPlateBody = new Armor()
            {
                ItemName = "Common plate body armor",
                ItemLevel = 2,
                EquippingSlot = Item.Slot.Body,
                ArmorType = Armor.ArmorTypes.Plate,
                ArmorAttribute = new PrimaryAttribute() { Vitality = 2, Strength = 1}
            };

            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => warrior.EquipItem(commonPlateBody));
        }

        [Fact]
        public void EquipItem_WarriorTryToEquipWrongWeapontype_ShouldTrowInvalidWeaponException()
        {
            // Arrange
            Warrior warrior = new Warrior("Boromir");
            Weapon commonBow = new Weapon()
            {
                ItemName = "Common bow",
                ItemLevel = 1,
                EquippingSlot = Item.Slot.Weapon,
                WeaponType = Weapon.WeaponTypes.Bow,
                WeaponAttribute = new WeaponAttribute() { Damage = 12, AttackSpeed = 0.8 }
            };

            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => warrior.EquipItem(commonBow));
        }

        [Fact]
        public void EquipItem_WarriorTryToEquipWrongArmortype_ShouldTrowInvalidArmorException()
        {
            // Arrange
            Warrior warrior = new Warrior("Boromir");
            Armor commonClothHead = new Armor()
            {
                ItemName = "Common cloth head armor",
                ItemLevel = 1,
                EquippingSlot = Item.Slot.Head,
                ArmorType = Armor.ArmorTypes.Cloth,
                ArmorAttribute = new PrimaryAttribute() { Vitality = 1, Intelligence = 5}
            };

            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => warrior.EquipItem(commonClothHead));
        }

        [Fact]
        public void EquipItem_WarriorEquipsWeapon_ShouldReturnNewWeaponEquipped()
        {
            // Arrange
            string expected = "New weapon equipped!";
            Warrior warrior = new Warrior("Boromir");
            Weapon commonAxe = new Weapon()
            {
                ItemName = "Common axe",
                ItemLevel = 1,
                EquippingSlot = Item.Slot.Weapon,
                WeaponType = Weapon.WeaponTypes.Axe,
                WeaponAttribute = new WeaponAttribute() { Damage = 7, AttackSpeed = 1.1 }
            };

            // Act
            string actual = warrior.EquipItem(commonAxe);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EquipItem_WarriorEquipsArmor_ShouldReturnNewArmorEquipped()
        {
            // Arrange
            string expected = "New armor equipped!";
            Warrior warrior = new Warrior("Boromir");
            Armor commonPlateBody = new Armor()
            {
                ItemName = "Common plate body armor",
                ItemLevel = 1,
                EquippingSlot = Item.Slot.Body,
                ArmorType = Armor.ArmorTypes.Plate,
                ArmorAttribute = new PrimaryAttribute() { Vitality = 2, Strength = 1 }
            };

            // Act
            string actual = warrior.EquipItem(commonPlateBody);

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region DPS Calculation
        
        [Fact]
        public void CalculateDPS_CreateWarrior_ShouldReturnDPS()
        {
            // Arrnage
            Warrior warrior = new Warrior("Boromir");
            double expected = 1 * (double)(1 + (warrior.DamageAttribute/ 100));

            // Act
            double actual = warrior.SecondaryAttribute.DPS;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDPS_CreateWarriorEquipWeapon_ShouldReturnDPS()
        {
            // Arrnage
            Warrior warrior = new Warrior("Boromir");
            Weapon commonAxe = new Weapon()
            {
                ItemName = "Common axe",
                ItemLevel = 1,
                EquippingSlot = Item.Slot.Weapon,
                WeaponType = Weapon.WeaponTypes.Axe,
                WeaponAttribute = new WeaponAttribute() { Damage = 7, AttackSpeed = 1.1 }
            };
            warrior.EquipItem(commonAxe);
            double expected = commonAxe.WeaponAttribute.DPS * (1 + (warrior.DamageAttribute / 100));

            // Act
            double actual = warrior.SecondaryAttribute.DPS;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDPS_CreateWarriorEquipWeaponAndArmour_ShouldReturnDPS()
        {
            // Arrnage
            Warrior warrior = new Warrior("Boromir");
            Weapon commonAxe = new Weapon()
            {
                ItemName = "Common axe",
                ItemLevel = 1,
                EquippingSlot = Item.Slot.Weapon,
                WeaponType = Weapon.WeaponTypes.Axe,
                WeaponAttribute = new WeaponAttribute() { Damage = 7, AttackSpeed = 1.1 }
            };

            Armor commonPlateBody = new Armor()
            {
                ItemName = "Common plate body armor",
                ItemLevel = 1,
                EquippingSlot = Item.Slot.Body,
                ArmorType = Armor.ArmorTypes.Plate,
                ArmorAttribute = new PrimaryAttribute() { Vitality = 2, Strength = 1 }
            };
            warrior.EquipItem(commonPlateBody);
            warrior.EquipItem(commonAxe);
            double expected = commonAxe.WeaponAttribute.DPS * (double)(1 + (warrior.DamageAttribute/ 100));

            // Act
            double actual = warrior.SecondaryAttribute.DPS;

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion
    }
}
