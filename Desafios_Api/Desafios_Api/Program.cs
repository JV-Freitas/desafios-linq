using Desafios_Api;
using System.Runtime.Intrinsics.X86;
using System;
//1 - Escrever um programa que faça uam requisição para a API de games CheapShark e mostre na tela a lista de promoções cadastrada na ferramenta (Você pode utilizar o endpoint: https://www.cheapshark.com/api/1.0/deals).

using (HttpClient client = new HttpClient())

{
    try
    {
        string response = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
        Console.WriteLine(response);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Houve algum problema: {ex.Message}");
    }


 }

    ////2 - Escrever um programa que solicite dois números a e b lidos do teclado e realize a divisão de a por b. Caso essa operação não seja possível, mostrar uma mensagem no console que deixe claro o erro ocorrido.


    Divisao conta1 = new();

try
{
    Console.Write("Digite o  valor de A:");
    int a = int.Parse(Console.ReadLine());

    Console.Write("Digite o  valor de B:");
    int b = int.Parse(Console.ReadLine());

    Console.WriteLine(conta1.CalculoDividir(a, b));
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Erro: na matemática não é permitida a divisão por 0. \nError status: {ex.Message}");
}

////3 - Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente. Tratar a exceção

List<int> listaDeInteiros = new();
listaDeInteiros.Add(1);
listaDeInteiros.Add(2);
listaDeInteiros.Add(3);
try
{
    Console.WriteLine(listaDeInteiros[5]);
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

//4 - Criar uma classe simples com um método e chame esse método em um objeto nulo. Tratar a exceção de método em objeto nulo.

try
{
    Divisao objetoNulo = null;
    objetoNulo.CalculoDividir(20,30);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}