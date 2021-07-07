namespace Jogador.Classes
{
    public class JogadorMeioCampo : Jogador
    {
        public override int Aposentar()
        {
            int idadeAposentar = 38 - CalcularIdade();
            return idadeAposentar;
        }
    }
}