using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RPGInventor.Items.Containers;
using RPGInventor.Items.Potions;
using RPGInventor.Items.Weapons;

namespace RPGInventory.Tests
{
    [TestFixture]
    class ContainerTests
    {
        [Test]
        public void CanAddItemToBackPack()
        {
            var backpack = new BackPack();
            var hp = new HealingPotion();
            bool isAdded = backpack.AddItem(hp);
            Assert.IsTrue(isAdded);
        }

        [Test]
        public void CannotAddItemToFullBackpack()
        {
            var backpack = new BackPack();
            backpack.AddItem(new GreatAxe());
            backpack.AddItem(new GreatAxe());
            backpack.AddItem(new GreatAxe());
            backpack.AddItem(new GreatAxe());

            var isAdded = backpack.AddItem(new GreatAxe());

            Assert.IsFalse(isAdded);
        }

        [Test]
        public void CanRemoveItemFromBackpack()
        {
            var backpack = new BackPack();
            var axe = new GreatAxe();

            backpack.AddItem(axe);

            var item = backpack.RemoveItem();

            Assert.AreEqual(axe,item);

            Assert.IsNull(backpack.RemoveItem());

        }

        public void CannotAddDupItemToBackpack()
        {
            var backpack = new BackPack();
            var axe = new GreatAxe();

            backpack.AddItem(axe);
            var isAdded = backpack.AddItem(axe);

            Assert.IsFalse(isAdded);
        }

        [Test]

        public void PotionBagOnlyAllowsPotions()
        {
            var bag = new PotionSatchel();

            Assert.IsTrue(bag.AddItem(new HealingPotion()));
            Assert.IsFalse(bag.AddItem(new GreatAxe()));
        }
    }
}
