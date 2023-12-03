Console.WriteLine("Введите строку на русском языке:");
string inputString = Console.ReadLine();

string modifiedString = inputString.Replace('а', 'о');

string filePath = "output.txt";

// Запись в файл
using (StreamWriter writer = new StreamWriter(filePath, true))
{
    writer.WriteLine($"Исходная строка: {inputString}");
    writer.WriteLine($"Изменённая строка: {modifiedString}");
}

// Чтение из файла
Console.WriteLine("\nПрошлые результаты:");
using (StreamReader reader = new StreamReader(filePath))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}