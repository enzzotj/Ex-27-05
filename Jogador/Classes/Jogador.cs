using System;

namespace Jogador.Classes
{
    public abstract class Jogador
    {
        public string Nome
        {
            get; set;
        }
        public int DataNasc
        {
            get; set;
        }
        public string Nacionalidade
        {
            get; set;
        }
        public string Altura
        {
            get; set;
        }
        public string Peso
        {
            get; set;
        }

        public int CalcularIdade()
        {
            int idade = DateTime.Now.Year - DataNasc;

            return idade;
        }
        public virtual int Aposentar()
        {
            int idadeAposentar = 35 - CalcularIdade();
            return idadeAposentar;
        }
        public string MostrarInformacao()
        {
            return $@"
            Nome: {Nome}
            Data de Nacimento: {DataNasc}
            Nacionalidade: {Nacionalidade}
            Altura: {Altura}
            Peso: {Peso}";
        }        
    }
}