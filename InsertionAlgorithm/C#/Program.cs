// Сортировка методом вставки

/// <summary>
/// Функция вывода массива в консоль
/// </summary>
/// <param name="array">печатаемый массив</param>
void PrintArray(int[] array)
{
    Console.Write($"[{String.Join(", ", array)}]");
    Console.WriteLine();
}

// функция создания массива по заданной длине и интервале
int[] CreateArray(int len, int min, int max)
{
    int[] array = new int[len];

    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }

    return array;
}

/// <summary>
/// Функция сортировки методом вставки
/// </summary>
/// <param name="array">первоначальный массив</param>
/// <returns>отсортированный массив</returns>
int[] InsertionSortingAlgorithm(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        int current = array[i];
        int j = i - 1;
        while (j >= 0 && array[j] > current)
        {
            array[j + 1] = array[j];
            j--;
        }
        array[j + 1] = current;
    }
    return array;
}

int[] Array = CreateArray(5, 0, 100);
PrintArray(Array);
Console.WriteLine();
PrintArray(InsertionSortingAlgorithm(Array));
Console.WriteLine();
PrintArray(new int[] { 31, 41, 59, 26, 41, 58 });
Console.WriteLine();
PrintArray(InsertionSortingAlgorithm(new int[] { 31, 41, 59, 26, 41, 58 }));
