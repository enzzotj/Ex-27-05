using System;
using Jogador.Classes;

namespace Jogador
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorAtaque jA = new JogadorAtaque();
            JogadorDefesa jD = new JogadorDefesa();
            JogadorMeioCampo jM = new JogadorMeioCampo();

            Console.WriteLine(@"
            Em qual posição você joga
            1 - Ataque
            2 - Defesa
            3 - MeioCampo");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Qual o seu nome?");
                    jA.Nome = Console.ReadLine();

                    Console.WriteLine("Em que ano você nasceu?");
                    jA.DataNasc = int.Parse(Console.ReadLine());

                    Console.WriteLine("Qual a sua nascionalidade?");
                    jA.Nacionalidade = Console.ReadLine();

                    Console.WriteLine("Qual a sua altura?");
                    jA.Altura = Console.ReadLine();

                    Console.WriteLine("Qual o seu peso?");
                    jA.Peso = Console.ReadLine();

                    Console.WriteLine(jA.MostrarInformacao());

                    Console.WriteLine($"Você se aposentará em {jA.Aposentar()} anos");
                    break;
                case "2":
                    Console.WriteLine("Qual o seu nome?");
                    jD.Nome = Console.ReadLine();

                    Console.WriteLine("Em que ano você nasceu?");
                    jD.DataNasc = int.Parse(Console.ReadLine());

                    Console.WriteLine("Qual a sua nascionalidade?");
                    jD.Nacionalidade = Console.ReadLine();

                    Console.WriteLine("Qual a sua altura?");
                    jD.Altura = Console.ReadLine();

                    Console.WriteLine("Qual o seu peso?");
                    jD.Peso = Console.ReadLine();

                    Console.WriteLine(jD.MostrarInformacao());

                    Console.WriteLine($"Você se aposentará em {jD.Aposentar()} anos");
                    break;
                case "3":
                    Console.WriteLine("Qual o seu nome?");
                    jM.Nome = Console.ReadLine();

                    Console.WriteLine("Em que ano você nasceu?");
                    jM.DataNasc = int.Parse(Console.ReadLine());

                    Console.WriteLine("Qual a sua nascionalidade?");
                    jM.Nacionalidade = Console.ReadLine();

                    Console.WriteLine("Qual a sua altura?");
                    jM.Altura = Console.ReadLine();

                    Console.WriteLine("Qual o seu peso?");
                    jM.Peso = Console.ReadLine();

                    Console.WriteLine(jM.MostrarInformacao());

                    Console.WriteLine($"Você se aposentará em {jM.Aposentar()} anos");
                    break;
                default:
                    Console.WriteLine("Digite uma opção válida");
                    break;
            }

        }
    }
}