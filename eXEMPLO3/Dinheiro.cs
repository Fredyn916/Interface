namespace Exemplo3
{
    public class Dinheiro : IFormaPagamento
    {
        public void CalculaValorPagamento(double valorTotal)
        {
            Console.WriteLine($"Como pagamento será realizado no dinheiro, vamos dar desconto de 10 reais, Valor Final será: {valorTotal - (10)}");
        }
    }
}
