// Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.

int[,] GetInt2dArray(int rows, int columns, int maxValue, int minValue)
{
    int[,] Random2dArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Random2dArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return Random2dArray;
}

void Print2dArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] Sort2DArrayRowsFromMaxtoMin(int[,] inArray)
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
        {
            for (int nextColumn = column + 1; nextColumn < inArray.GetLength(1); nextColumn++)
            {
                if (inArray[row, column] < inArray[row, nextColumn])
                {
                    int temp = inArray[row, column];
                    inArray[row, column] = inArray[row, nextColumn];
                    inArray[row, nextColumn] = temp;
                }
            }
        }
    }
    return inArray;
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное случайное число: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное случайное число: ");
int maxValue = int.Parse(Console.ReadLine()!);

int[,] array = GetInt2dArray(rows, columns, maxValue, minValue);
Print2dArray(array);
Console.WriteLine();
int[,] result = Sort2DArrayRowsFromMaxtoMin(array);
Print2dArray(result);