// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using static System.Console;
Clear();

WriteLine("Введите размеры (кол-во строк и столбцов) двумерного массива через пробел: ");
string[] parameters = ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int[] paramet = ReadString(parameters);
int[,] array = GetRandomArray(paramet[0], paramet[1]);
WriteLine("Введите адрес ячейки массива (через пробел): ");
string[] adress = ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int[] coord = ReadString(adress);
PrintMatrix(array);
FindCell(array, coord[0], coord[1]);






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

void FindCell(int[,] matrix, int line, int column)
{
    int result = 0;
    if (line > matrix.GetLength(0) || column > matrix.GetLength(1)) WriteLine("Элемент с таким индексом отсутствует в массиве");
    else WriteLine(matrix[line - 1, column - 1]);
}




