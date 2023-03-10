            // Программа принимает 2мерный массив и выводит частотный словарь элементов массива

int[,] CreateArray(int rows, int columns, int minValue = 0, int maxValue = 9)
{
    int[,] array = new int[rows, columns];

    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue +1);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 3} ");
        }
        Console.WriteLine();
    }
}

void FrequencyDictionary(int[,] array)
{
    int[] dictionary = new int[10];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            dictionary[array[i, j]] = dictionary[array[i, j]] + 1;
        }
    }

    for (int i = 0; i < dictionary.Length; i++)
    {
    if (dictionary[i] !=0)
        {
            Console.WriteLine($"Цифра {i} встречается {dictionary[i]} раз");
        }
    }
}

int[,] massive = CreateArray(3, 3);


PrintArray(massive);
Console.WriteLine();

FrequencyDictionary(massive);