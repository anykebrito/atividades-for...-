/*int[] ordenar = new int[5];

for (int x = 0; x < 5; x++)
{
    Console.Write($"Digite o {x + 1}º número:");
    ordenar[x] = int.Parse(Console.ReadLine()!);

}

for (int x = 0; x < 5; x++)
{
    for (int y = x + 1; y < 5; y++) //contador no 0, roda enquanto a condição for verdadeira
    {
        if (ordenar[x] > ordenar[y]) //perguntano se o índice 0(x) é maior q o índice 1(y) / comparando x com y / adiciona +1 e vê o próximo número que o usuário adicionou dentro os 5 pedidos
        { // quando um número é maior do que o outro, ele etra no if, caso contrário passa direto pro Console.WriteLine
            int aux = ordenar[x]; // foi rodando o y do primeiro número ao último; enquanto o auxiliar for maior que o outro eles se mantem (ex: 5 < 10). Caso contrário, eles trocam de lugar(ex: 10 < 5)
            ordenar[x] = ordenar[y];
            ordenar[y] = aux;
        }
    }
}
Console.WriteLine("Números ordenados");

for (int x = 0; x < 5; x++)
{
    Console.WriteLine($"{x + 1}º número: {ordenar[x]}  ");
}*/