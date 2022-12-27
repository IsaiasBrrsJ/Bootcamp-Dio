namespace tech_test_payment_api.Models
{
    public enum StatusVenda
    {
        AguardandoPagamento = 1,
        PagamentoAprovado,
        EnviadoParaTransportadora,
        Entregue,
        Cancelada
    }
}