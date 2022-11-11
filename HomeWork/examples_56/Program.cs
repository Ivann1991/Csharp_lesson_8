//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
void strokaMinSumElement(int[,] array)
{
    int sumMinStroki = 0;
    int sumStroki = 0;
    int StrokaMinSumEl = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumMinStroki += array[0, j];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumStroki += array [i, j];
            if (sumMinStroki > sumStroki)
            {
                sumMinStroki = sumStroki;
                StrokaMinSumEl = i;
            }
            sumStroki = 0;
        }
    }
    Console.Write ($"у {StrokaMinSumEl + 1} cтроки наименьшая сумма элементов ");
}
///////////////////////////////////
Console.Clear();
int rows = new Random().Next(3, 6);
int columns = new Random().Next(3, 6);
int[,] array = getArray(rows, columns);
Console.WriteLine("Сгенерированный массив");
printArray(array);
strokaMinSumElement(array);