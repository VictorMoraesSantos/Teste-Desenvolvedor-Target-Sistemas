while (true)
{
    Console.WriteLine("Informe uma palavra para inverter (ou digite 'sair' para encerrar):");
    string input = Console.ReadLine();

    if (input?.ToLower() == "sair")
    {
        Console.WriteLine("Encerrando o programa. Até mais!");
        break;
    }

    string invertedString = InverterString(input);
    Console.WriteLine($"Palavra invertida: {invertedString}");
}

static string InverterString(string input)
{
    char[] caracteres = input.ToCharArray();
    for (int i = 0, j = caracteres.Length - 1; i < j; i++, j--)
    {
        char temp = caracteres[i];
        caracteres[i] = caracteres[j];
        caracteres[j] = temp;
    }

    return new string(caracteres);
}