namespace Cafeteria.Models;

/// <summary>
/// Linha de um pedido: produto, quantidade e preço praticado no momento da venda.
/// </summary>
public class ItemPedido
{
    public int ProdutoId { get; set; }
    public string NomeProduto { get; set; } = string.Empty;
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }

    public decimal Subtotal => Quantidade * PrecoUnitario;
}
