using System.Text.Json;
using Cafeteria.Models;

namespace Cafeteria.Services;

/// <summary>
/// Armazena as vendas em memória e persiste em um arquivo JSON local,
/// para que o relatório continue disponível após fechar o sistema.
/// </summary>
public static class VendaRepository
{
    private static readonly string CaminhoArquivo = Path.Combine(AppContext.BaseDirectory, "vendas.json");
    private static readonly JsonSerializerOptions OpcoesJson = new() { WriteIndented = true };
    private static readonly List<Venda> Vendas = Carregar();

    public static IReadOnlyList<Venda> ObterTodas() =>
        Vendas.OrderByDescending(v => v.DataHora).ToList();

    public static IReadOnlyList<Venda> ObterPorPeriodo(DateTime inicio, DateTime fim) =>
        Vendas.Where(v => v.DataHora.Date >= inicio.Date && v.DataHora.Date <= fim.Date)
              .OrderByDescending(v => v.DataHora)
              .ToList();

    public static Venda Registrar(Venda venda)
    {
        ArgumentNullException.ThrowIfNull(venda);
        venda.Id = Vendas.Count == 0 ? 1 : Vendas.Max(v => v.Id) + 1;
        venda.DataHora = DateTime.Now;
        Vendas.Add(venda);
        Salvar();
        return venda;
    }

    public static int QuantidadeDoDia() => Vendas.Count(v => v.DataHora.Date == DateTime.Today);

    public static decimal TotalDoDia() =>
        Vendas.Where(v => v.DataHora.Date == DateTime.Today).Sum(v => v.Total);

    private static List<Venda> Carregar()
    {
        try
        {
            if (!File.Exists(CaminhoArquivo)) return new List<Venda>();
            var json = File.ReadAllText(CaminhoArquivo);
            return JsonSerializer.Deserialize<List<Venda>>(json) ?? new List<Venda>();
        }
        catch (Exception ex) when (ex is IOException or JsonException or UnauthorizedAccessException)
        {
            return new List<Venda>();
        }
    }

    private static void Salvar()
    {
        try
        {
            File.WriteAllText(CaminhoArquivo, JsonSerializer.Serialize(Vendas, OpcoesJson));
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            // Sem permissão de escrita: as vendas continuam disponíveis em memória.
        }
    }
}
