
namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        public int numero;
        public decimal saldo;
        public decimal limite;
        public Movimentacao[] movimentacoes;
        private int indiceMovimentacoes = 0;

        public void Sacar(decimal valor)
        {
            if (valor <= saldo + limite)
            {
                saldo -= valor;
                RegistrarMovimentacao(valor, "Débito");
            }
            else
                Console.WriteLine("Saque não autorizado: limite insuficiente.");
        }

        public void Depositar(decimal valor)
        {
            saldo += valor;
            RegistrarMovimentacao(valor, "Crédito");
        }

        public void TransferirPara(ContaCorrente destino, decimal valor)
        {
            if (valor <= saldo + limite)
            {
                Sacar(valor);
                destino.Depositar(valor);
            }
            else
                Console.WriteLine("Transferência não autorizada: limite insuficiente.");
        }

        public void ExibirExtrato()
        {
            Console.WriteLine($"Extrato da Conta {numero}");

            for (int i = 0; i < indiceMovimentacoes; i++)
                Console.WriteLine(movimentacoes[i]);

            Console.WriteLine($"Saldo atual: R$ {saldo:F2}");
        }

        private void RegistrarMovimentacao(decimal valor, string tipo)
        {
            if (indiceMovimentacoes < movimentacoes.Length)
                movimentacoes[indiceMovimentacoes++] = new Movimentacao(valor, tipo);
            else
                Console.WriteLine("Limite de movimentações atingido.");
        }
    }
}
