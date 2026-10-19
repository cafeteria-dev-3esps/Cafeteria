using Cafeteria.Models;

namespace Cafeteria.Data;

/// <summary>
/// Cardápio fixo da Cafeteria Dev.
/// </summary>
public static class Cardapio
{
    public static IReadOnlyList<Produto> Produtos { get; } = new List<Produto>
    {
        new() { Id = 1,  Nome = "Espresso Debug",            Categoria = "Cafés",   Preco = 6.00m },
        new() { Id = 2,  Nome = "Coado Compilado",           Categoria = "Cafés",   Preco = 5.50m },
        new() { Id = 3,  Nome = "Cappuccino Commit",         Categoria = "Cafés",   Preco = 9.90m },
        new() { Id = 4,  Nome = "Latte Async",               Categoria = "Cafés",   Preco = 10.50m },
        new() { Id = 5,  Nome = "Mocha Merge",               Categoria = "Cafés",   Preco = 12.00m },
        new() { Id = 6,  Nome = "Macchiato Middleware",      Categoria = "Cafés",   Preco = 8.50m },
        new() { Id = 7,  Nome = "Cold Brew Cloud",           Categoria = "Gelados", Preco = 13.90m },
        new() { Id = 8,  Nome = "Chocolate Quente Hotfix",   Categoria = "Bebidas", Preco = 10.00m },
        new() { Id = 9,  Nome = "Pão de Queijo Pull Request", Categoria = "Comidas", Preco = 5.00m },
        new() { Id = 10, Nome = "Croissant Cache",           Categoria = "Comidas", Preco = 8.90m },
        new() { Id = 11, Nome = "Bolo de Cenoura Backlog",   Categoria = "Comidas", Preco = 7.50m },
    };
}
