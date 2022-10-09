// Задача 52.Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.

using static System.Console;
Clear();

WriteLine("Введите размеры (кол-во строк и столбцов) двумерного массива через пробел: ");
string[] parameters = ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int[] paramet = ReadString(parameters);
int[,] array = GetRandomArray(paramet[0], paramet[1]);
PrintMatrix(array);
FindAverage(array);


int[] ReadString(string[] input)
{
    int[] result = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = Convert.ToInt32(input[i]);
    }
    return result;
}


int[,] GetRandomArray(int lines, int columns)
{
    int[,] result = new int[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
}


void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]}\t");
        }
        WriteLine();
    }
}

void FindAverage(int[,] data)
{

    for (int i = 0; i < data.GetLength(1); i++)
    {
        double average = 0;
        for (int j = 0; j < data.GetLength(0); j++)
        {
            average += data[j, i];
        }
        WriteLine($"Среднее арифметическое чисел столбца {i} равно {average / data.GetLength(0)};");
    }
}