using System.Globalization;
using System.Text.Json.Serialization;

namespace Desafio02_Api.Models;

internal class Livro
{
    [JsonPropertyName("titulo")]
    public string Titulo { get; set; }
    [JsonPropertyName("autor")]
    public string Autor { get; set; }
    [JsonPropertyName("genero")]
    public string Genero { get; set; }
    [JsonPropertyName("ano_publicacao")]
    public int Ano { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine("- Exibir Ficha Técnica do Livro");
        Console.WriteLine($"Titulo: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Ano de publicação: {Ano}");
    }
}
