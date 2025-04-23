namespace ContaCorrente.ConsoleApp
{
    public class Movimentacao
    {
        public decimal Valor;
        public string TipoTransacao;

        public Movimentacao(decimal valor, string tipoTransacao)
        {
            Valor = valor;
            TipoTransacao = tipoTransacao;
        }

        public string MostrarMovimentacao()
        {
            return $"{TipoTransacao}: R$ {Valor:F2}";
        }
    }
}
