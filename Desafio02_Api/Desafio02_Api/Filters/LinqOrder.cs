using Desafio02_Api.Models;

namespace Desafio02_Api.Filters;

internal class LinqOrder
{
    public static void Order(List<Livro>livros)
    {
        var ordenarLivrosAno2000 = livros.Where(livro => livro.Ano < 2000).OrderBy(livro => livro.Titulo).Select(livro => livro.Titulo);

        
        Console.WriteLine("Livros < Anos 2000");
        foreach (var item in ordenarLivrosAno2000)
        {
            Console.WriteLine($"- {item}");
        }
    }
}
