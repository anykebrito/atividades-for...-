/*string[] nome = new string[3];
double[,] nota = new double[3, 3];

for (int coluna = 0; coluna < 3; coluna++)
{
    Console.Write($"Digite o {linha + 1}º nome: ");
    nome[linha] = Console.ReadLine()!;
}

for (int linha = 0; linha < 3; linha++)
{
    double divisor = 0;
    double soma = 0;
    for (int coluna = 0; coluna < 3; coluna++)
    {
        Console.Write($"Digite a {coluna + 1}º nota do aluno {nome[linha]}:");
        nota[linha, coluna] = double.Parse(Console.ReadLine()!);
        soma += nota[linha, coluna];
        divisor++;

        if (coluna == 2)
        {
            double media = soma / divisor;
            Console.WriteLine($"O aluno {nome[linha]} tem média de {media}");
        }
    }
}*/