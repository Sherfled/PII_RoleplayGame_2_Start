using System;
namespace RoleplayGame
{
    public class Elve : ICharacter
    {

        public string Name { get; set;}
        public int QuantityLife { get; set; }
        public Item Weapon { get; set; }


        public Elve(string name, int life) 
        {
            this.Name = name;
            this.QuantityLife = life;
        }
        
        public void HealCharacter(ICharacter character, int cantidad)
        {
           character.Cure(cantidad);
           Console.WriteLine($"{Name}ha curado al personaje {character.Name}, y acutalmente su estado de vida es: {character.QuantityLife}."); 
        }

        public void AttackWeapon(ICharacter character)
        {
            Console.WriteLine($"El Personaje {Name} ha atacado a {character.Name}.");
           if (Weapon !=null)

           {
            int damage = Weapon.Ataque;
            character.Cure(-damage);
           }
           else
           {
            Console.WriteLine ($"El personaje no tiene arma.");
           }  
        }
        
        public void Cure(int Quantity) 
        {
            if (Quantity <= 1000)
            {
                QuantityLife += Quantity;
                Console.WriteLine($"Se ha curado a {Name}, su estado de vida actual es {QuantityLife}.");
            }
            else
            {
                Console.WriteLine("La cantidad que desea curar excede los limites de curación.");
            }
        }

    }
}