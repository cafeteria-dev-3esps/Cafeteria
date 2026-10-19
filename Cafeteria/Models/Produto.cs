namespace Cafeteria.Models;

/// <summary>
/// Item do cardápio da Cafeteria Dev.
/// </summary>
public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
    public decimal Preco { get; set; }

    public override string ToString() => $"{Nome}  ({Preco:C2})";
}
