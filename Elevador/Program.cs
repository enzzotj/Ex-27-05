using System;
using Elevador.Classes;

namespace Elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            ElevadorSocial elevadorSoc = new ElevadorSocial();
            ElevadorServico elevadorSer = new ElevadorServico();


            Console.WriteLine(@"
            Qual elevador você quer usar?
            1 - Social
            2 - Serviço");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Quantos andares tem o prédio?");
                    elevadorSoc.NumeroAndares = int.Parse(Console.ReadLine());

                    Console.WriteLine("Qual a capacidade do elevador?");
                    elevadorSoc.Capacidade = int.Parse(Console.ReadLine());

                    Console.WriteLine(elevadorSoc.Inicializar());

                    do
                    {
                        Console.WriteLine(
                        @"O que você quer realizar?
                    1 - Entrar
                    2 - Sair
                    3 - Subir
                    4 - Descer");

                        string opcaoElevador = Console.ReadLine();

                        switch (opcaoElevador)
                        {
                            case "1":
                                Console.WriteLine("Quantas pessoas entraram?");
                                int pessoasEnt = int.Parse(Console.ReadLine());

                                for (var i = 0; i < pessoasEnt; i++)
                                {
                                    Console.WriteLine(elevadorSoc.Entrar());
                                }
                                break;
                            case "2":
                                Console.WriteLine("Quantas pessoas sairam?");
                                int pessoasSair = int.Parse(Console.ReadLine());

                                for (var i = 0; i < pessoasSair; i++)
                                {
                                    Console.WriteLine(elevadorSoc.Sair());
                                }
                                break;
                            case "3":
                                Console.WriteLine("Para qual andar você quer subir?");
                                int andarSubir = int.Parse(Console.ReadLine());

                                for (var i = 0; i < andarSubir; i++)
                                {
                                    elevadorSoc.Subir();
                                }
                                Console.WriteLine(elevadorSoc.Subir());
                                break;
                            case "4":
                                Console.WriteLine("Quantos andares você quer descer?");
                                int andarDescer = int.Parse(Console.ReadLine());

                                for (var i = 0; i < andarDescer; i++)
                                {
                                    elevadorSoc.Descer();
                                }
                                Console.WriteLine(elevadorSoc.Descer());
                                break;
                            default:
                                Console.WriteLine("Digite uma opção válida");
                                break;
                        }
                    } while (elevadorSoc.Pessoas > 0);
                    break;
                case "2":
                    Console.WriteLine("Quantos andares tem o prédio?");
                    elevadorSer.NumeroAndares = int.Parse(Console.ReadLine());

                    Console.WriteLine("Qual a capacidade do elevador?");
                    elevadorSer.Capacidade = int.Parse(Console.ReadLine());

                    elevadorSer.Inicializar();

                    do
                    {
                        Console.WriteLine(
                        @"O que você quer realizar?
                    1 - Entrar
                    2 - Sair
                    3 - Subir
                    4 - Descer
                    5 - Adicionar Caixa
                    6 - Remover caixa");
                        string opcaoElevador = Console.ReadLine();

                        switch (opcaoElevador)
                        {
                            case "1":
                                Console.WriteLine("Quantas pessoas entraram?");
                                int pessoasEnt = int.Parse(Console.ReadLine());

                                for (var i = 0; i < pessoasEnt; i++)
                                {
                                    Console.WriteLine(elevadorSer.Entrar());
                                }
                                break;
                            case "2":
                                Console.WriteLine("Quantas pessoas sairam?");
                                int pessoasSair = int.Parse(Console.ReadLine());

                                for (var i = 0; i < pessoasSair; i++)
                                {
                                    Console.WriteLine(elevadorSer.Sair());
                                }
                                break;
                            case "3":
                                Console.WriteLine("Para qual andar você quer subir?");
                                int andarSubir = int.Parse(Console.ReadLine());

                                for (var i = 0; i < andarSubir; i++)
                                {
                                    elevadorSer.Subir();
                                }
                                Console.WriteLine(elevadorSer.Subir());
                                break;
                            case "4":
                                Console.WriteLine("Quantos andares você quer descer?");
                                int andarDescer = int.Parse(Console.ReadLine());

                                for (var i = 0; i < andarDescer; i++)
                                {
                                    elevadorSer.Descer();
                                }
                                Console.WriteLine(elevadorSer.Descer());
                                break;
                            case "5":
                                Console.WriteLine("Quantas caixas você quer adicionar?");
                                int caixaAdicionar = int.Parse(Console.ReadLine());

                                for (var i = 0; i < caixaAdicionar; i++)
                                {
                                    Console.WriteLine(elevadorSer.AdicionarCaixa());
                                }
                                break;
                            case "6":
                                Console.WriteLine("Quantas caixas você quer remover?");
                                int caixaRemover = int.Parse(Console.ReadLine());

                                for (var i = 0; i < caixaRemover; i++)
                                {
                                    Console.WriteLine(elevadorSer.RetirarCaixa());
                                }
                                break;
                            default:
                                break;
                        }
                    } while (elevadorSer.Pessoas > 0);
                    break;
                default:
                    break;
            }

        }
    }
}