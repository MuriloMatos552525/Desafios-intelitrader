namespace Desafios_intelitrader;

using System;


    public static class CriptografiaChallenge
    {
        public static void Run()
        {
            // Array de bits encriptados
            string[] encryptedBits =
            {
                "10010110",
                "11110111",
                "01010110",
                "00000001",
                "00010111",
                "00100110",
                "01010111",
                "00000001",
                "00010111",
                "01110110",
                "01010111",
                "00110110",
                "11110111",
                "11010111",
                "01010111",
                "00000011"
            };

            // Descriptografa
            string decryptedMessage = DecryptMessage(encryptedBits);

            // Exibe o resultado
            Console.WriteLine("\n=== DESAFIO 1: CRIPTOGRAFIA NA REDE DO NAVIO ===");
            Console.WriteLine("Mensagem descriptografada:");
            Console.WriteLine(decryptedMessage);
        }

        private static string DecryptMessage(string[] encryptedBits)
        {
            string result = "";

            foreach (var bits in encryptedBits)
            {
                // Passo 1: Inverte os dois últimos bits
                string invertedLastTwo = InvertLastTwoBits(bits);

                // Passo 2: Troca os nibbles (4 bits e 4 bits)
                string nibbleSwapped = SwapNibbles(invertedLastTwo);

                // Converte para decimal
                int decimalValue = Convert.ToInt32(nibbleSwapped, 2);

                // Converte para caractere ASCII
                char character = (char)decimalValue;

                result += character;
            }

            return result;
        }

        private static string InvertLastTwoBits(string bits)
        {
            if (bits.Length != 8)
                throw new ArgumentException("É esperado um string de 8 bits.");

            string firstSix = bits.Substring(0, 6);
            char bit7 = bits[6];
            char bit8 = bits[7];

            // Invertemos bit7 e bit8
            bit7 = (bit7 == '0') ? '1' : '0';
            bit8 = (bit8 == '0') ? '1' : '0';

            return firstSix + bit7 + bit8;
        }

        private static string SwapNibbles(string bits)
        {
            if (bits.Length != 8)
                throw new ArgumentException("É esperado um string de 8 bits.");

            string leftNibble = bits.Substring(0, 4);
            string rightNibble = bits.Substring(4, 4);

            // Troca esquerda com direita
            return rightNibble + leftNibble;
        }
    }

