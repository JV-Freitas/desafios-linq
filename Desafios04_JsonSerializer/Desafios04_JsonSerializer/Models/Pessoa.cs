using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Channels;

namespace Desafios04_JsonSerializer.Models;

internal class Pessoa
{
    [JsonPropertyName("nome")]
    public string Nome { get; set; }
    [JsonPropertyName("email")]
    public string Email { get; set; }
    [JsonPropertyName("idade")]
    public int Idade { get; set; }
    public Pessoa(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            idade = Idade,
            email = Email,
        });

        string NomeArquivo = $"pessoa-{Nome}.json";
        File.WriteAllText(NomeArquivo, json);

        Console.WriteLine($"Json criado com sucesso! -> {Path.GetFullPath(NomeArquivo)}");
        Console.WriteLine();
    }
}
