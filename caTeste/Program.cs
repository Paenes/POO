Console.WriteLine("Linha 1: Teste");
Console.WriteLine("Linha 2: Teste");
Console.WriteLine("Linha 3: Teste");
Console.ReadLine();
// Especifica a linha que deseja limpar (por exemplo, a linha 2)
int linhaParaLimpar = 1; // Índice base zero

// Move o cursor para a linha especificada
Console.SetCursorPosition(0, linhaParaLimpar);

// Limpa a linha
Console.Write(new string(' ', Console.WindowWidth));

// Move o cursor de volta ao início da linha limpa
//Console.SetCursorPosition(0, linhaParaLimpar);
//Console.WriteLine();


// Se desejar, pode escrever algo novo na linha
//Console.WriteLine();
//Console.Write("Linha 2 foi limpa!");
Console.ReadLine();
    