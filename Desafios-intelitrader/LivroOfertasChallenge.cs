using System;
using System.Collections.Generic;

namespace Desafios_intelitrader
{
    public static class LivroOfertasChallenge
    {
        public static void Run()
        {
            Console.WriteLine("\n=== DESAFIO 2: LIVRO DE OFERTAS ===");
            Console.Write("Digite o número de notificações: ");

            // 1) Ler o número de notificações
            int n = int.Parse(Console.ReadLine());

            // Dicionário para armazenar: posicao -> (valor, quantidade)
            Dictionary<int, (double valor, int quantidade)> livro
                = new Dictionary<int, (double, int)>();

            // 2) Processar cada notificação
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite a notificação {i + 1}/{n} (ex: 1,0,15.4,50): ");
                string linha = Console.ReadLine();
                string[] partes = linha.Split(',');

                int posicao = int.Parse(partes[0]);
                int acao = int.Parse(partes[1]);
                double valor = double.Parse(partes[2]);
                int quantidade = int.Parse(partes[3]);

                switch (acao)
                {
                    case 0: // INSERIR
                        // Se a posição já existe, sobrescreve; senão, cria
                        livro[posicao] = (valor, quantidade);
                        break;

                    case 1: // MODIFICAR
                        // Só modifica se a posição existir
                        if (livro.ContainsKey(posicao))
                        {
                            var (valorAtual, qtdAtual) = livro[posicao];

                            // Se valor > 0, atualiza; se == 0, mantém o anterior
                            double novoValor = (valor > 0) ? valor : valorAtual;

                            // Se quantidade > 0, atualiza; se == 0, mantém o anterior
                            int novaQuantidade = (quantidade > 0) ? quantidade : qtdAtual;

                            livro[posicao] = (novoValor, novaQuantidade);
                        }
                        break;

                    case 2: // DELETAR
                        // Remove a posição do livro, se existir
                        if (livro.ContainsKey(posicao))
                        {
                            livro.Remove(posicao);
                        }
                        break;
                }
            }

            // 3) Ordenar as posições manualmente (sem usar OrderBy, Sort, etc.)
            int[] chaves = new int[livro.Count];
            livro.Keys.CopyTo(chaves, 0);

            // Implementação de um Bubble Sort simples para ordenar as chaves em ordem crescente
            for (int i = 0; i < chaves.Length - 1; i++)
            {
                for (int j = 0; j < chaves.Length - 1 - i; j++)
                {
                    if (chaves[j] > chaves[j + 1])
                    {
                        // Troca de posições sem função pronta
                        int temp = chaves[j];
                        chaves[j] = chaves[j + 1];
                        chaves[j + 1] = temp;
                    }
                }
            }

            // 4) Imprimir o resultado no formato: "posicao,valor,quantidade"
            Console.WriteLine("\n=== LIVRO DE OFERTAS (RESULTADO) ===");
            foreach (int pos in chaves)
            {
                var (v, q) = livro[pos];
                Console.WriteLine($"{pos},{v},{q}");
            }
        }
    }
}
