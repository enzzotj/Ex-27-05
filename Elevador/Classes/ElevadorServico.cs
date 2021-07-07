namespace Elevador.Classes
{
    public class ElevadorServico : Elevador
    {
        public int MaxCaixas = 4;
        public int CaixasAtual
        {
            get; set;
        }
        public string AdicionarCaixa()
        {
            if (CaixasAtual < MaxCaixas)
            {
                CaixasAtual = CaixasAtual + 1;
                return $"Caixa adicionada, atualmente tem {CaixasAtual} caixas";
            }
            else
            {
                return "Número máximo de caixas atingido";
            }
        }
        public string RetirarCaixa()
        {
            if (CaixasAtual >= 1)
            {
                CaixasAtual = CaixasAtual - 1;
                return $"Caixa retirada, atualmente tem {CaixasAtual} caixas";  
            }
            else
            {
                return "Nenhuma caixa presente";
            }
        }
    }
}