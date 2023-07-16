// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return tempMatrix;
}


void PrintMatrix(int[,] matrixToPrint)
{
    for (int i = 0; i < matrixToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixToPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int[] Sum(int[,] matrix)
{
    int[] number = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            number[i] += matrix[i, j];
        }
    }
    return number;
}

int Min(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 1; i <array.Length; i++)
    {
        if (min> array[i])
        {
            min = array[i];
            index = i;
        }
    }
    return index;
}


void PrintArray(int[] array)
{
    System.Console.WriteLine($"Сумма элементов каждой строки матрицы: [ {string.Join(", ", array)} ]");
}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

int row = ReadInt("Введите количество строк: ");
int col = ReadInt("Введите количество столбцов: ");
int[,] matrix = FillMatrix(row, col, 0, 10);
PrintMatrix(matrix);
System.Console.WriteLine();
int[] array = Sum(matrix);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Минимальная сумма элементов  {Min(array) + 1} строке");