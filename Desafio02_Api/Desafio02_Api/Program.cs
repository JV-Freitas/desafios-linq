using Desafio02_Api.Filters;
using Desafio02_Api.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    string endPointFilme = "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json";
    string endPointPais = "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json";
    string endPointCarro = "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json";
    string endPointLivro = "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json";

    string endPointGameOfThrones = "https://anapioficeandfire.com/api/characters/";

    try
    {
        string responseFilme = await client.GetStringAsync(endPointFilme);
        //Console.WriteLine(responseFilme);

        var filmes = JsonSerializer.Deserialize<List<Filme>>(responseFilme);
        Console.WriteLine($"#Quantidade de dados dentro do JSON {filmes!.Count()}");
        filmes![8].ExibirDetalhes();
        Console.WriteLine();

        string responsePais = await client.GetStringAsync(endPointPais);
        var paises = JsonSerializer.Deserialize<List<Pais>>(responsePais);
        Console.WriteLine($"#Quantidade de dados dentro do JSON {paises.Count()}");
        paises[1].ExibirDetalhes();
        Console.WriteLine();

        string responseCarro =  await client.GetStringAsync(endPointCarro);
        var carros = JsonSerializer.Deserialize<List<Carro>>(responseCarro);
        Console.WriteLine($"#Quantidade de dados dentro do JSON {carros.Count()}");
        carros[3].ExibirFichaTecnica();
        Console.WriteLine();

        string responseLivro = await client.GetStringAsync(endPointLivro);
        var livros = JsonSerializer.Deserialize<List<Livro>>(responseLivro);
        Console.WriteLine($"#Quantidade de dados dentro do JSON {livros.Count()}");
        livros[2].ExibirFichaTecnica();
        Console.WriteLine();

        //Console.Write("Digite um numero para decobrir o persoagem e suas informações: ");
        //int idPersonagem = int.Parse(Console.ReadLine());


        //string responseGOT = await client.GetStringAsync($"{endPointGameOfThrones}{idPersonagem}");
        //var personagem = JsonSerializer.Deserialize<Personagem>(responseGOT);
        //personagem.ExibirDetalhes();

        Console.WriteLine("Response da API de livros");
        Console.WriteLine(responseLivro);
        Console.WriteLine("LINQ FILTER");
        Console.WriteLine();
        LinqOrder.Order(livros);

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error Message: {ex.Message}");
    }
}