//Desafio 1 – Crie uma classe para gerenciar um ingresso de cinema com filme
//"Aventura Épica" e preço inicial de R$30,00. A classe deve permitir a compra de
//ingressos (reduzindo a quantidade disponível) apenas se houver ingressos e garantir
//que a quantidade nunca seja negativa. Forneça um método para exibir os dados no
//formato: "Filme: [filme], Preço: R$[preço], Disponíveis: [quantidade]". Inclua um
//programa principal que realiza a compra de 2 ingressos (de um total inicial de 10) e
//exibe os dados do ingresso.
//Escreva o código completo.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio1GFT
{
    public class Cinema(int quantidadeinicial)
    {
        //Propriedades 
        public string Filme { get; set; } = "Aventura Épica";
        public double Preco { get; set; } = 30.0;

        public int QuantidadeDeIngressos { get; set; } = quantidadeinicial;

        //Métodos 
        public void IngressosTotais()
        {
            Console.WriteLine("---- Detalhes do Ingresso ----");
            Console.WriteLine($"Filme : {Filme}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Disponíveis: {QuantidadeDeIngressos}");
            Console.WriteLine("----------------------");
        }

        public void ComprarIngressos(int quantidadeDesejada)
        {
            if (quantidadeDesejada <= QuantidadeDeIngressos)
            {
                Console.WriteLine("Quantidade inválida para compra");
                return;
            }

            if (quantidadeDesejada <= QuantidadeDeIngressos)
            {
                QuantidadeDeIngressos -= quantidadeDesejada;
                Console.WriteLine($"Compra realizada! Você comprou {quantidadeDesejada} ingresso(s).");
            }
            else
            {
                Console.WriteLine("Não há ingressos suficientes disponíveis!");
            }
        }

    }
    
}