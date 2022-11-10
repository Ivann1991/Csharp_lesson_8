// Составить частотный словарь элементов массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Console.Clear();
int[,] getArray(int m, int n)        //////////заполнение двухмерного массива случайными числами.
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 9);
        }
    }
    return array;
}
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void PrintArray(int[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"{array[array.Length - 1]}] ");
}
int[] arrayToarray(int[,] array)
{
    int n = array.GetLength(0) * array.GetLength(1);
    int[] newArray = new int[n];
    int z = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[z] = array[i, j];
            z++;
        }
    }
    return newArray;
}

//////////////////////////
int rows = new Random().Next(1, 6);
int columns = new Random().Next(1, 6);
int[,] array = getArray(rows, columns);
Console.WriteLine();
printArray(array);
int[] oneArray = arrayToarray(array);
PrintArray(oneArray);
for (int i = 0; i < oneArray.Length; i++)
{
    int count = 0;
    if (oneArray[0] == oneArray[i])
        count = count + 1;
Console.Write($"{oneArray[0]} встречается {count} раз ");
}


