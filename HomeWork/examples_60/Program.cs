// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] getArray(int m, int n, int d)        //////////заполнение трехмерного массива случайными числами.
{
    int[,,] array = new int[m, n, d];
    int count = 10;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int z = 0; z < d; z++)
            {
                array[i, j, z] +=count;
                count +=1;
            }
        }
    }
    return array;
}
void printArray(int[,,] array)                                    ///////////вывод двухмерного массива

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[i, j, z]} ({i}, {j}, {z}) ");
            }
            Console.WriteLine();
        }
    }
}
///////////////////////////////////
Console.Clear();
int rows = new Random().Next(1, 4);
int columns = new Random().Next(1, 4);
int z = new Random().Next(1, 4);
int[,,] array = getArray(rows, columns, z);
Console.WriteLine("Сгенерированный массив");
printArray(array);