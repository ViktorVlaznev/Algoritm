// сортировка выбором

/// <summary>
/// Функция вывода массива в консоль
/// </summary>
/// <param name="array">печатаемый массив</param>
void PrintArray(int[] array)
{
    Console.Write($"[{String.Join(", ", array)}]");
    Console.WriteLine();
}

/// <summary>
/// функция создания массива со случайными элементами
/// </summary>
/// <param name="len">длина массива</param>
/// <param name="min">минимальное возможное число</param>
/// <param name="max">максимальное возможное число</param>
/// <returns>массив</returns>
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
/// функция определения минимального значения массива
/// </summary>
/// <param name="array">данный массив</param>
/// <returns>индекс минимального элемента массива</returns>
int GetIndexMinElemArray(int[] array)
{
    int min = array[0];
    int count = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            count = i;
        }
    }
    return count;
}

/// <summary>
/// функция удаление элемента из массива
/// </summary>
/// <param name="array">исходный массив</param>
/// <param name="index">индекс удаляемого элемента</param>
/// <returns>искомый массив</returns>
int[] DelElemArray(int[] array, int index)
{
    int[] result = new int[array.Length - 1];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i != index)
        {
            result[count++] = array[i];
        }
    }
    return result;
}

/// <summary>
/// функция сортировки массива выбором
/// </summary>
/// <param name="array">исходный массив</param>
/// <returns>отсортированный массив</returns>
int[] SortingByChoice(int[] array)
{
    int[] result = new int[array.Length];
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        result[i] = array[GetIndexMinElemArray(array)];
        array = DelElemArray(array, GetIndexMinElemArray(array));
    }
    return result;
}

int[] Array = CreateArray(5, 0, 100);
PrintArray(Array);
Console.WriteLine();
PrintArray(SortingByChoice(Array));
