namespace ContaCorrente.ConsoleApp
{
    public class Movimentacao
    {
        public decimal Valor;
        public string TipoTransacao;
        public string TipoOperacao;

        public Movimentacao(decimal valor, string tipoTransacao, string tipoOperacao)
        {
            Valor = valor;
            TipoTransacao = tipoTransacao;
            TipoOperacao = tipoOperacao;
        }

        public string MostrarMovimentacao()
        {
            return $"{TipoOperacao} de R$ {Valor:F2} ({TipoTransacao})";
        }
    }
}
