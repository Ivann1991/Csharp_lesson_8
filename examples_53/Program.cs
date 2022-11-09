// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
int [,] changeRows(int [,] array)
{
    int i = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int nummember = array [i, j];
        array [i, j] = array [array.GetLength(0)-1, j];
        array [array.GetLength(0)-1, j] = nummember;
    }
    return array;
}
/////////////////
Console.Clear();
int rows = new Random().Next(5, 5);
int columns = new Random().Next(5, 5);
int [,] array = getArray(rows, columns);
Console.WriteLine();
printArray(array);
int [,] arrayNew = changeRows(array);
Console.WriteLine();
printArray(arrayNew);
