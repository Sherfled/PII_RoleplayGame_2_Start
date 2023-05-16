using NUnit.Framework;



namespace RoleplayGame
{
    public class WizardsTest
    {
        [Test]
        public void TestingWizards()
        {
            Wizard Wizard1 = new Wizard("Dr. Strange", 100);
            Wizard Wizard2 = new Wizard("Dr. Doom", 100);
            ItemMagic Object = new ItemMagic("Libro", "El Poder del Fuego", 50, 0);  
            Wizard1.AddObjects(Object);
            Wizard1.Attack(Wizard2);

            Assert.AreEqual(50, Wizard2.QuantityLife);
        }

        [Test]
        public void TestingWizards1()
        {
            Wizard Wizard1 = new Wizard("Dr. Strange", 100);
            Wizard Wizard2 = new Wizard("Dr. Doom", 100);
            ItemMagic Object = new ItemMagic("Libro", "El Poder del Fuego", 50, 0);
            ItemMagic Object1 = new ItemMagic("Libro", "El Poder del Agua", 0, 100);
            Wizard1.AddObjects(Object);
            Wizard1.AddObjects(Object1);
            Wizard1.Attack(Wizard2);

            Assert.AreEqual(150, Wizard2.QuantityLife);
        }

        [Test]
        public void TestingWizards2()
        {
            Wizard Wizard1 = new Wizard("Dr. Strange", 100); 
            Wizard Wizard2 = new Wizard("Dr. Doom", 100);
            ItemMagic Object = new ItemMagic("Libro", "El Poder del Fuego", 50, 0);
            ItemMagic Object1 = new ItemMagic("Libro", "El Poder del Agua", 0, 100);
            Wizard2.AddObjects(Object);
            Wizard2.AddObjects(Object1);
            Wizard2.Attack(Wizard1);

            Assert.AreEqual(150, Wizard1.QuantityLife);
        }
    }
}

