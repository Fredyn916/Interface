namespace Exemplo3
{
    public class Cartao : IFormaPagamento
    {
        public void CalculaValorPagamento(double valorTotal)
        {
            Console.WriteLine($"Como pagamento será realizado no cartao, vamos cobrar uma multa de 2%, Valor Final será: {valorTotal + (valorTotal * 0.02)}");
        }
    }
}
