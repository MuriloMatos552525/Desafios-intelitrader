namespace Desafios_intelitrader;

public class LivroOfertas
{
    public static void Main()
    {
        // 1) Ler quantidade de notificações
        int n = int.Parse(Console.ReadLine());

        // Dicionário para armazenar a posição -> (valor, quantidade)
        Dictionary<int, (double valor, int quantidade)> ofertas
            = new Dictionary<int, (double, int)>();

        // 2) Processar as notificações
        for (int i = 0; i < n; i++)
        {
            // Exemplo de linha de input: "1,0,15.4,50"
            string linha = Console.ReadLine();
            string[] partes = linha.Split(',');

            int posicao = int.Parse(partes[0]);
            int acao = int.Parse(partes[1]);
            double valor = double.Parse(partes[2]);
            int quantidade = int.Parse(partes[3]);

            switch (acao)
            {
                case 0: // INSERIR
                    // Se a posicao já existe, sobrescreve;
                    // se não, insere normalmente.
                    ofertas[posicao] = (valor, quantidade);
                    break;

                case 1: // MODIFICAR
                    // Só modifica se a posição existir
                    if (ofertas.ContainsKey(posicao))
                    {
                        var atual = ofertas[posicao];

                        // Se valor > 0, atualiza; se == 0, mantém anterior
                        double novoValor = (valor > 0) ? valor : atual.valor;
                        // Se quantidade > 0, atualiza; se == 0, mantém anterior
                        int novaQuantidade = (quantidade > 0) ? quantidade : atual.quantidade;

                        ofertas[posicao] = (novoValor, novaQuantidade);
                    }
                    break;

                case 2: // DELETAR
                    // Remove a posição se existir
                    if (ofertas.ContainsKey(posicao))
                    {
                        ofertas.Remove(posicao);
                    }
                    break;
            }
        }

        // 3) Ordenar as posições (chaves) manualmente (sem usar LINQ ou Sort)
        int[] chaves = new int[ofertas.Count];
        ofertas.Keys.CopyTo(chaves, 0);

        // Exemplo de Bubble Sort para ordenar as chaves em ordem crescente
        for (int i = 0; i < chaves.Length - 1; i++)
        {
            for (int j = 0; j < chaves.Length - 1 - i; j++)
            {
                if (chaves[j] > chaves[j + 1])
                {
                    // Troca
                    int temp = chaves[j];
                    chaves[j] = chaves[j + 1];
                    chaves[j + 1] = temp;
                }
            }
        }

        // 4) Exibir o resultado final
        // Cada linha: posicao,valor,quantidade
        foreach (int chave in chaves)
        {
            var (valor, quantidade) = ofertas[chave];
            Console.WriteLine($"{chave},{valor},{quantidade}");
        }
    }
}