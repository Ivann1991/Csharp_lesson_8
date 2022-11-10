// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае если это невозможно, программа должна вывести сообщение пользователю.
Console.Clear();
int[,] getArray(int m, int n)        //////////заполнение двухмерного массива случайными числами.
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
    return array;
}
void printArray(int[,] array)                                    ///////////вывод двухмерного массива
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
int[,] changeRowsColumns(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
    return array;
}
bool check(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
        return true;
    return false;
}

////////////////////////////////////
int rows = new Random().Next(1, 6);
int columns = new Random().Next(1, 6);
int[,] array = getArray(rows, columns);
Console.WriteLine();
printArray(array);
Console.WriteLine();
if (check(array))
{
    int[,] changeArray = changeRowsColumns(array);
    printArray(changeArray);
}
else Console.Write($"невозможно транспонировать массив"); 
    
