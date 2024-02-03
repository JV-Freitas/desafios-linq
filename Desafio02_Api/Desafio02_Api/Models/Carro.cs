using System.Text.Json.Serialization;

namespace Desafio02_Api.Models;

internal class Carro
{
    [JsonPropertyName("marca")]
    public string Marca { get; set; }
    [JsonPropertyName("modelo")]
    public string Modelo { get; set; }
    [JsonPropertyName("tipo")]
    public string Tipo { get; set; }
    [JsonPropertyName("ano")]
    public int Ano { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine("- Ficha Técnica do Carro");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Tipo: {Tipo}");
        Console.WriteLine($"Ano: {Ano}");
    }
}
