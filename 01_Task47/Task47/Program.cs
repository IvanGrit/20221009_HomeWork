//Задача 47.Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.

using static System.Console;
Clear();
WriteLine("Введите размеры (кол-во строк и столбцов) двумерного массива через пробел: ");
string[] parameters = ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int[] paramet = ReadString(parameters);
double[,] array = GetRandomArray(paramet[0], paramet[1]);
PrintMatrix(array);










int[] ReadString(string[] input)
{
    int[] result = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = Convert.ToInt32(input[i]);
    }
    return result;
}



double[,] GetRandomArray(int lines, int columns)
{
    double[,] result = new double[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
            //result[i,j] = Math.Round(new Random().NextDouble() + new Random().Next(-50, 51), 2);
        }
    }
    return result;
}


void PrintMatrix(double[,] inMatrix)
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
