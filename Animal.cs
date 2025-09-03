using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio2
{
    public class Animal

{
    public string Nome { get; set; }

    public Animal(string nome)
    {
        Nome = nome;
    }

    public virtual void Descrever()
    {
        Console.WriteLine(Nome);
    }
}

public class Passaro : Animal
{
    public double Envergadura { get; set; }

    public Passaro(string nome, double envergadura) : base(nome)
    {
        Envergadura = envergadura;
    }

    public override void Descrever()
    {
        Console.WriteLine($"{Nome}, Envergadura: {Envergadura} m");
    }
}

    }
