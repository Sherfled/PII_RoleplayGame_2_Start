using System;
using System.Collections.Generic;

namespace  RoleplayGame
{
    public class Wizard : ICharacter
    {

        public Wizard(string name, int life)
        {
            this.Name = name;
            this.QuantityLife = life;
        }

        public string Name { get; set; }
        public int QuantityLife { get; set; }
        public Item Weapon { get; set; }
    
        private List<ItemMagic> Inventory = new List<ItemMagic>(); // Se le agregan los conocimientos de magia o items (Baston) que haya adquirido

        public void AddObjects(ItemMagic item)
        {
            this.Inventory.Add(item);       // Añado al inventario.
            
        }
        
         
        public void AttackWeapon(ICharacter character)
        {
            Console.WriteLine($"El Personaje {Name} ha atacado a {character.Name}.");
            if (Weapon != null)
            {
                int damage = Weapon.Ataque;
                character.Cure(-damage);
            }
            else
            {
                Console.WriteLine ($"El personaje no tiene arma");
            }  
        }
    

        public void Attack(ICharacter personaje)
        {
            int damage = 0;
            
            foreach (ItemMagic items in Inventory)
            {
                damage += items.AttackValue;         // Sumo el valor de ataque de los objetos que tiene el mago.
                if (items.DefenseValue > 0)      // Si el valor de defenza del item es mayor a cero, se lo sumo a la vida del mago.
                {
                    personaje.QuantityLife += items.DefenseValue;
                }
            }

            if (damage == 0)      // Si el mago no tiene ningun item/conocimiento, el daño será 0.
            {
                damage = 10;    // Aca se le asigna un daño minimo para cuando no tiene conocimientos o items.
            }

            personaje.QuantityLife -= damage; // Le resta a la vida del personaje escogido, el daño.
            Console.WriteLine($"{personaje} ha recibido {damage} daño.");
        }
        
                        
      
        public void Cure(int Quantity) 
        {
            if (Quantity <= 1000)
            {
                QuantityLife += Quantity;
                Console.WriteLine($"Se ha curado a {Name}, su estado de vida actual es {QuantityLife}");
            }
            else
            {
                Console.WriteLine("La cantidad que desea curar excede los limites de curación.");
            }
        }

    }
    
}