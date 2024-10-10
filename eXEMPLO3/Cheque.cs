namespace Exemplo3
{
    public class Cheque : IFormaPagamento
    {
        public void CalculaValorPagamento(double valorTotal)
        {
            Console.WriteLine($"Como pagamento será realizado no cheque, vamos dar um desconto de 15% de desconto, Valor Final será: {valorTotal - (valorTotal * 0.15)}");
        }
    }
}
