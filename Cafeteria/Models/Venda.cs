namespace Cafeteria.Models;

/// <summary>
/// Venda finalizada no caixa.
/// </summary>
public class Venda
{
    public int Id { get; set; }
    public DateTime DataHora { get; set; }
    public string Cliente { get; set; } = string.Empty;
    public string FormaPagamento { get; set; } = string.Empty;
    public List<ItemPedido> Itens { get; set; } = new();

    public decimal Total => Itens.Sum(i => i.Subtotal);
    public int QuantidadeItens => Itens.Sum(i => i.Quantidade);
}
