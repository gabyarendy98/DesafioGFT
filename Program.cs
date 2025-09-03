using System;

class Program
{
    public static void Main(string[] args)
    {
        Cinema ingresso = new Cinema(10);

        ingresso.IngressosTotais();
        ingresso.ComprarIngressos(2);
        ingresso.IngressosTotais; 
    }
}