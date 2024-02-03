namespace Desafios03_Linq.Filtros;

internal class LinqFilter
{
    public static void FiltrarUnicos(List<int> numeros)
    {
        var numerosUnicos = numeros.Distinct().ToList();
        Console.WriteLine("Numeros Unicos:");
        foreach (var item in numerosUnicos)
        {
            Console.WriteLine($"- {item}");
        }
    }

    public static void FiltrarNumerosPares(List<int> numeros)
    {
        var numerosPares = numeros.Where(num => num % 2 == 0);
        Console.WriteLine("Numeros Pares:");
        foreach (var item in numerosPares)
        {
            Console.WriteLine($"- {item}");
        }
    }
    public static void FiltrarNumerosImpares(List<int> numeros)
    {
        var numerosImpares = numeros.Where(num => num % 2 == 1);
        Console.WriteLine("Numeros Impares:");
        foreach (var item in numerosImpares)
        {
            Console.WriteLine($"- {item}");
        }
    }

    public static void CalculaPrecoMedio(List<Produto> produtos)
    {
        var precoMedio = produtos.Average(prod => prod.Preco);
        Console.WriteLine("Preço médio dos produtos: " + precoMedio);
    }
}
