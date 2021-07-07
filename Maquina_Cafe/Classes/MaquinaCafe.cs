namespace Maquina_Cafe.Classes
{
    public class MaquinaCafe
    {
        public int AcucarDisponivel = 100;

        public string FazerCafe()
        {
            if (AcucarDisponivel >= 10)
            {
                AcucarDisponivel = AcucarDisponivel - 10;
                return $"Café com açucar feito, restam {AcucarDisponivel}g de açucar";
            }
            else if (AcucarDisponivel < 10)
            {
                AcucarDisponivel = AcucarDisponivel - AcucarDisponivel;
                return $"Café com açucar feito, restam {AcucarDisponivel}g de açucar";
            }
            else
            {
                return "Sem açucar disponivel";
            }
        }
        public string FazerCafe(int gramasCafe)
        {
            if (gramasCafe > AcucarDisponivel)
            {
                return "Quantidade de açucar pedida maior do que a disponível, tente novamente";
            }
            else
            {
                AcucarDisponivel = AcucarDisponivel - gramasCafe;
                return $"Café com açucar feito, restam {AcucarDisponivel}g de açucar";
            }
        }
        public string CafePuro()
        {
            return $"Café sem açucar feito, restam {AcucarDisponivel}g de açucar";
        }

    }
}