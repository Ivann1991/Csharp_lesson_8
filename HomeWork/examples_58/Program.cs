//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int usernum(string Message, string errorMessage)
{
    while (true)
    {
        Console.Write(Message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int usernum);
        if (isCorrect)
            return usernum;
        Console.WriteLine(errorMessage);
    }
}
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
void resultArray(int[,] array, int[,] array2, int[,] array3)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array3[i, j] = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                array3[i, j] += array[i, k] * array2[k, j];
            }
        }
    }
    Console.WriteLine("\nрезультирующая матрица ");
    printArray(array3);
}
///////////////////////////////////
Console.Clear();
int rows = usernum("Введи количество строк: ", "Ошибка Ввода");
int columns = usernum("Введи количество строк: ", "Ошибка Ввода");
int[,] array = getArray(rows, columns);
Console.WriteLine("\nСгенерированный массив 1");
printArray(array);
int[,] array2 = getArray(rows, columns);
Console.WriteLine("\nСгенерированный массив 2");
printArray(array2);
int[,] array3 = new int[rows, columns];

if (array.GetLength(0) != array2.GetLength(1))
{
    Console.Write("\nМатрицы нельзя перемножить");
    return;
}
resultArray(array, array2, array3);



