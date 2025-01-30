# Desafios Intelitrader

Este repositório contém **2 desafios resolvidos em C#**:

1. **Criptografia na Rede do Navio**  
2. **Livro de Ofertas**

A aplicação é **Console** e apresenta um **menu** que permite escolher qual desafio executar.

---

## Como executar

1. **Clonar** este repositório:
   ```bash
   git clone https://github.com/SEU-USUARIO/DesafiosIntelitrader.git
   cd DesafiosIntelitrader
   ```

2. **Compilar** usando o .NET (caso possua o SDK instalado):
   ```bash
   dotnet build
   ```
3. **Rodar**:
   ```bash
   dotnet run
   ```
   O programa exibirá:
   ```
   === Menu de Desafios ===
   1 - Criptografia na Rede do Navio
   2 - Livro de Ofertas
   Escolha uma opção:
   ```
   - **Opção 1**: Executa o desafio de criptografia.
   - **Opção 2**: Executa o desafio do livro de ofertas.

### Compilando manualmente (sem .NET CLI)
- **Windows (csc)**:
  ```bash
  csc Program.cs CriptografiaChallenge.cs LivroOfertasChallenge.cs
  Program.exe
  ```
- **Linux/macOS (Mono)**:
  ```bash
  mcs Program.cs CriptografiaChallenge.cs LivroOfertasChallenge.cs -out:Desafios.exe
  mono Desafios.exe
  ```

---

## Desafio 1: Criptografia na Rede do Navio

- Lê um conjunto de bits (8 bits por caractere).
- Inverte os dois últimos bits.
- Faz a troca de nibbles (4 bits iniciais com 4 bits finais).
- Converte para ASCII e exibe a mensagem descriptografada.

---

## Desafio 2: Livro de Ofertas

1. **Lê** a quantidade de notificações.
2. **Para cada notificação** (`posicao,acao,valor,quantidade`):
   - `0 = Inserir`  
   - `1 = Modificar`  
   - `2 = Deletar`
3. **Armazena** em um dicionário.
4. **Ordena** as posições com **Bubble Sort** (sem funções prontas).
5. **Exibe** o resultado final em `posicao,valor,quantidade`.

