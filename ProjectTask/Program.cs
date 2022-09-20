string[] InputStringArray(int size)
{
    string[] input = new string[size];
    Console.WriteLine("Заполните строки для создания массива:");

    for (int i = 0; i < input.Length; i++)
    {
        Console.Write($"строка {i + 1}: ");
        input[i] = Console.ReadLine();
        while (input[i] == "")
        {
            Console.WriteLine("Ошибка! Строка не должна быть пустой. Повторите ввод: ");
            input[i] = Console.ReadLine();
        }
    }
    return input;
}

int InputNumber()
{
    string input = Console.ReadLine();
    if (!int.TryParse(input, out int number) || number < 0)
    {
        Console.WriteLine("Ошибка! Введите корректное число ");
        return InputNumber();
    }
    return number;
}

void Print(string[] input)
{
    Console.WriteLine($"[{string.Join(", ", input)}]");
}

string[] GetElementsLowerThen(string[] input, int maxchar)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= maxchar)
        {
            count++;
        }
    }

    string[] result = new string[count];
    int index = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= maxchar)
        {
            result[index] = input[i];
            index++;
        }
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите количество строк в массиве:");
string[] inputdata = InputStringArray(InputNumber());
Console.Clear();
Console.WriteLine("Создаем массив строк...");
Print(inputdata);
Console.WriteLine();
Console.WriteLine("Выбираем строки с 3 и менее символами...");
string[] output = GetElementsLowerThen(inputdata, 3);
Print(output);