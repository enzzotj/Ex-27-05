using System;
using Maquina_Cafe.Classes;

namespace Maquina_Cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe mC = new MaquinaCafe();

            int gramasCafe;

            bool cafeteiraLigada = true;

            do
            {
                Console.WriteLine(@"
            Deseja Fazer Café:
            1 - Com Açucar
            2 - Sem Açucar
            3 - Desligar Cafeteira");

                string tipoCafe = Console.ReadLine();

                switch (tipoCafe)
                {
                    case "1":
                        Console.WriteLine("Deseja escolher a quantidade de açucar? S para sim e N para não");
                        string quantidadeAcucar = Console.ReadLine().ToUpper();

                        switch (quantidadeAcucar)
                        {
                            case "S":
                            Console.WriteLine("Quantos gramas de açucar?");
                            gramasCafe = int.Parse(Console.ReadLine());

                            Console.WriteLine(mC.FazerCafe(gramasCafe));
                                break;
                            case "N":
                                Console.WriteLine(mC.FazerCafe());
                                break;
                            default:
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine(mC.CafePuro());
                        break;
                    case "3":
                        cafeteiraLigada = false;
                        break;
                    default:
                        break;
                }

            } while (cafeteiraLigada);


        }
    }
}