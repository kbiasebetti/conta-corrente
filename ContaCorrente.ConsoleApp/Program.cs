namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
			ContaCorrente conta01 = new ContaCorrente();
			ContaCorrente conta02 = new ContaCorrente();

			// Dados da primeira conta
			conta01.numero = 1;
			conta01.saldo = 2000;
			conta01.limite = 500;
			conta01.movimentacoes = new Movimentacao[10];

			// Dados da segunda conta
			conta02.numero = 2;
			conta02.saldo = 900;
			conta02.limite = 0;
			conta02.movimentacoes = new Movimentacao[10];

			// Operações
			conta01.Depositar(450);
			conta01.Sacar(600);
			conta01.TransferirPara(conta02, 700);

			conta02.Sacar(230);

			// Resultados
			conta01.ExibirExtrato();
			Console.WriteLine();
			conta02.ExibirExtrato();

			Console.ReadLine();
		}
    }
}
