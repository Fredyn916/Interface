namespace Exemplo3
{
    public class Pix : IFormaPagamento
    {
        public void CalculaValorPagamento(double valorTotal)
        {
            Console.WriteLine($"Como pagamento será realizado no pix, vamos oferecer 30% de desconto, Valor Final será: {valorTotal - (valorTotal * 0.3)}");
        }
    }
}
