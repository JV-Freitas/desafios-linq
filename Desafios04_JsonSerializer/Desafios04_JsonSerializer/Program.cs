
using Desafios04_JsonSerializer.Models;
using System.Text.Json;

var pessoaJoao = new Pessoa("João Vitor", "jvfreitas02@gmail.com", 20);
pessoaJoao.GerarArquivoJson();

var pessoaInfamme = new Pessoa("Infamme", "infamme@gmail.com", 99);
pessoaInfamme.GerarArquivoJson();

string fileName = @"C:\Repositorios\C#\04-C#_Consumindo_Api_Gravando_Arquivos_Linq\Desafios04_JsonSerializer\Desafios04_JsonSerializer\bin\Debug\net8.0\pessoa-Infamme.json";
//string fileName = "pessoa-Infamme.json";

if (File.Exists(fileName))
{
    string jsonString = File.ReadAllText(fileName);

    Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(jsonString);
    Console.WriteLine($"Nome: {pessoa.Nome}");
    Console.WriteLine($"Idade: {pessoa.Idade}");
    Console.WriteLine($"E-mail: {pessoa.Email}");
}
else
{
    Console.WriteLine($"O arquivo {fileName} não existe.");
}
