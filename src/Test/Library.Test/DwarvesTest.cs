using NUnit.Framework;

namespace RoleplayGame
{
    public class DwarvesTest
    {
        [Test]
        public void TestingDwarves()
        {
            Item sword = new Item("Sword", 20);

            Dwarves Enano1 = new Dwarves("John", 100);
            Dwarves Enano2 = new Dwarves("Jack", 100);

            Enano1.Weapon = sword;
            Enano1.AttackWeapon(Enano2);
            Enano2.Cure(30);
            Assert.AreEqual(80, Enano2.QuantityLife);
        }
    }
}
    