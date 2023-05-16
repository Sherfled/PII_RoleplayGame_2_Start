namespace RoleplayGame;
using System;
using System.Collections.Generic;
public class Item
{
    public string Nombre {get;set;}
    public int Ataque{get;set;}
    public int Defensa{get;set;}
    private List<string> Armaduras;
    private List<string> Armas;
    public Item(string Nombre, int Ataque)
    {
        this.Nombre = Nombre;
        this.Ataque = Ataque;
        this.Defensa = 0;
        this.Armas.Add(Nombre);
    }
    public Item(string Nombre, int Defensa, bool isDefense)
    {
        this.Nombre = Nombre;
        this.Ataque = 0;
        this.Defensa = Defensa;
        this.Armaduras.Add(Nombre);
    }
    public void GetArmaduras()
    {
        Console.WriteLine("Las armaduras disponibles son: ");
        foreach (string defensa in Armaduras)
        {
            Console.WriteLine(defensa);
        }
    }
    public void GetArmas()
    {
        Console.WriteLine("Las armas disponibles son: ");
        foreach (string arma in Armas)
        {
            Console.WriteLine(arma);
        }
    }
}


/*
Item espada = new Item("Espada", 30)
Item escudo = new Item("Escudo", 15, true);
*/