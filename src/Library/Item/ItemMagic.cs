
using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class ItemMagic
    {
        public ItemMagic(string type, string name, int powerAttack, int powerDefense)
        {
            this.Type = type;
            this.Name = name;
            this.AttackValue = powerAttack;
            this.DefenseValue = powerDefense;
        }
        

        public string Type { get; set; }
        public string Name { get; set; }
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }
    }
}


// Crea a los items