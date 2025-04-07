using System;
using System.Globalization;

namespace SISTEMADEALUNO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1: Nome e Saudação
            Console.WriteLine("Digite seu nome:");
            string nomeUsuario = Console.ReadLine();
            Console.WriteLine($"Olá, {nomeUsuario}! Seja bem-vindo(a)!");

            // Exercício 2: Calculando a Idade
            Console.WriteLine("\nDigite seu ano de nascimento:");
            int anoNascimento = int.Parse(Console.ReadLine());
            int idade = 2024 - anoNascimento;
            Console.WriteLine($"Você tem {idade} anos.");

            // Exercício 3: Média de Notas
            Console.WriteLine("\nDigite a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a terceira nota:");
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"A média das notas é: {media.ToString("F2", CultureInfo.InvariantCulture)}");

            // Exercício 4: Maior Número
            Console.WriteLine("\nDigite o primeiro número:");
            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o segundo número:");
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num1 > num2)
            {
                Console.WriteLine($"O maior número é: {num1}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"O maior número é: {num2}");
            }
            else
            {
                Console.WriteLine("Os dois números são iguais.");
            }

            // Exercício 5: Verificar Par ou Ímpar
            Console.WriteLine("\nDigite um número para verificar se é par ou ímpar:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }

            // Parte original do seu programa - sistema de aluno
            Console.WriteLine("\nAgora, vamos cadastrar um aluno.");

            Console.WriteLine("Digite o nome do aluno:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota:");
            double notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a segunda nota:");
            double notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Aluno aluno = new Aluno(nome, notaA, notaB);
            aluno.ExibirResultado();
        }
    }
}