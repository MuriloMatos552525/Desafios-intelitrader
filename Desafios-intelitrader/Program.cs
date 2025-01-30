using System;
using Desafios_intelitrader;

namespace Desafios_intelitrader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Menu de Desafios ===");
            Console.WriteLine("1 - Criptografia na Rede do Navio");
            Console.WriteLine("2 - Livro de Ofertas");
            Console.Write("Escolha uma opção: ");
            
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    // Desafio de Criptografia
                    CriptografiaChallenge.Run();
                    break;
                case "2":
                    // Desafio do Livro de Ofertas
                    LivroOfertasChallenge.Run();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
