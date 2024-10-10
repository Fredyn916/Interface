namespace Exemplo3
{
    public static class GerenciadorPagamento
    {
        public static void ProcessarPagamento(IFormaPagamento formaPagamento, double valor)
        {
            formaPagamento.CalculaValorPagamento(valor);
        }
    }
}
