using System;

namespace Elevador.Classes
{
    public abstract class Elevador
    {
        public int AndarAtual
        {
            get; set;
        }
        public int NumeroAndares
        {
            get; set;
        }
        public int Capacidade
        {
            get; set;
        }
        public int Pessoas
        {
            get; set;
        }
        public string Inicializar()
        {
            return ($"O Elevador tem {NumeroAndares} andares, com uma capacidade de {Capacidade} pessoas");
        }
        public string Entrar()
        {
            if (Pessoas < Capacidade)
            {
                Pessoas = Pessoas + 1;
                return $"Entrou uma pessoa no elevador, tem {Pessoas} pessoa(s) no elevador";
            }
            else
            {
                return "Elevador cheio";
            }
        }
        public string Sair()
        {
            if (Pessoas > 0)
            {
                Pessoas = Pessoas - 1;
                return $"Saiu uma pessoa do elevador, tem {Pessoas} pessoa(s) no elevador";
            }
            else
            {
                return "Elevador vazio, não é possível sair ninguem";
            }
        }
        public string Subir()
        {
            if (AndarAtual < NumeroAndares)
            {
                AndarAtual = AndarAtual + 1;
                return $"Você subiu para o {AndarAtual} andar";
            }
            else
            {
                return "Você já está no último andar";
            }
        }
        public string Descer() 
        {
            if (AndarAtual >= 1)
            {
                AndarAtual = AndarAtual - 1;
                return $"Você desceu para o {AndarAtual}° andar";
            }
            else
            {
                return "Você está no terreo"; 
            }
        }
    }
}