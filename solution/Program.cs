Console.Clear();
Console.Write("Введите строки ТОЛЬКО через пробел/пробелы: ");
int max = 3;
string[] symbols = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < symbols.Length; i++)
{
    if (max < symbols[i].Length)
    {
        symbols[i] = String.Empty;
    }
}
Console.WriteLine($"[{String.Join(",", symbols)}]");

// ТАКЖЕ ЕСТЬ ВАРИАНТ С ПОМОЩЬЮ МЕТОДА



// Console.Clear();
// Console.Write("Введите строки ТОЛЬКО через пробел/пробелы: ");
// string[] words = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
// Method2 (words);


// void Method2(string[] symbols)
// {
//     int max = 3;
//     for (int i = 0; i < symbols.Length; i++)
//     {
//         if (max < symbols[i].Length)
//         {
//             symbols[i] = String.Empty;
//         }
//     }
//     Console.WriteLine($"[{String.Join(", ", symbols)}]");
// }
