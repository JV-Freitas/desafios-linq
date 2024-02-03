using System.Text.Json.Serialization;

namespace Desafio02_Api.Models;

internal class Personagem
{
    //List<string> codenames = new();

    [JsonPropertyName("name")]
    public string Nome { get; set; }
    [JsonPropertyName("gender")]
    public string Genero { get; set; }

    [JsonPropertyName("aliases")]
    public string[] Codename {  get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine("- Detalhes do Personagem GOT");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Gênero: {Genero}");

        foreach( var codename in Codename)
        {
            Console.WriteLine($"Nickname: {codename}");
        }
    }

}
