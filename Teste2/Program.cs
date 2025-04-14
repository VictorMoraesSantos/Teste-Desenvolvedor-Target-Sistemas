while (true)
{
    Console.WriteLine("Informe um número para verificar se pertence à sequência de Fibonacci (ou digite 'sair' para encerrar):");
    string input = Console.ReadLine();

    if (input?.ToLower() == "sair")
    {
        Console.WriteLine("Encerrando o programa. Até mais!");
        break;
    }

    if (int.TryParse(input, out int num))
    {
        if (IsFibonacci(num))
        {
            Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {num} não pertence à sequência de Fibonacci.");
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro ou 'sair' para encerrar.");
    }
}

static bool IsFibonacci(int num)
{
    int a = 0;
    int b = 1;
    int temp;

    while (b < num)
    {
        temp = a;
        a = b;
        b = temp + b;
    }

    return b == num || num == 0;
}