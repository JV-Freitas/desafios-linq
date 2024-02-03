//1 - Dada uma lista de números, cri;ar uma consulta LINQ para retornar apenas os elementos únicos da lista. [ok]

//2 - Dada uma lista de livros com título, autor e ano de publicação, 
//criar uma consulta LINQ para retornar uma lista com os títulos dos livros publicados após o ano 2000, ordenados alfabeticamente. [+/-]

//3 - Dada uma lista de produtos com nome e preço, criar uma consulta LINQ para calcular o preço médio dos produtos.

//4 - Dada uma lista de inteiros, criar uma consulta LINQ para retornar apenas os números pares.[ok]

using Desafios03_Linq;
using Desafios03_Linq.Filtros;

List<int> numeros = new List<int>();
numeros.Add(1);
numeros.Add(1);
numeros.Add(2);
numeros.Add(5);
numeros.Add(3);
numeros.Add(2);
numeros.Add(3);
numeros.Add(9);
numeros.Add(3);

LinqFilter.FiltrarUnicos(numeros);
LinqFilter.FiltrarNumerosPares(numeros);
LinqFilter.FiltrarNumerosImpares(numeros);

List<Produto> produtos = new()
{
   new Produto { Nome = "Laptop", Preco = 1200 },
   new Produto { Nome = "Smartphone", Preco = 800 },
   new Produto { Nome = "Tablet", Preco = 500 },
   new Produto { Nome = "Câmera", Preco = 300 }
};

List<Produto> lista = new List<Produto>();
Produto prod1 = new Produto();
prod1.Nome = "Mouse";
prod1.Preco = 500;

Produto prod2 = new Produto();
prod1.Nome = "Teclado";
prod1.Preco = 800;

lista.Add(prod1);
lista.Add(prod2);

LinqFilter.CalculaPrecoMedio(produtos);
