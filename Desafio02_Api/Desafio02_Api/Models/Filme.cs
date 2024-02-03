using System.Text.Json.Serialization;

namespace Desafio02_Api.Models;

internal class Filme
{
    [JsonPropertyName("title")]
    public string Nome { get; set; }
    [JsonPropertyName("year")]
    public string Ano { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine("- Detalhes do Filme");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Ano: {Ano}");
    }

    //colocar propiedades - ok
    //jsonpropertyname - ok
    //serializar json pra colcoar na lista

}
