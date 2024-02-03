using System.Text.Json.Serialization;

namespace Desafio02_Api.Models;

internal class Pais
{
    [JsonPropertyName("nome")]
    public string Nome { get; set; }
    [JsonPropertyName("capital")]
    public string Capital { get; set; }
    [JsonPropertyName("idioma")]
    public string Idioma { get; set; }
    [JsonPropertyName("populacao")]
    public int Populacao { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine("- Exibir Dados do País");
        Console.WriteLine($"País: {Nome}");
        Console.WriteLine($"Capital: {Capital}");
        Console.WriteLine($"Idioma: {Idioma}");
        Console.WriteLine($"População: {Populacao}");
    }
}
