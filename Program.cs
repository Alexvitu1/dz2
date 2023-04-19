//HW
Start();

void Start()
{

    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        System.Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        System.Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
        System.Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
        System.Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив . Размер вводит юзер");
        System.Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return; break;

            case 54:
                Console.Clear();
                int rows = SetNumber("rows");
                int columns = SetNumber("columns");
                int min = SetNumber("min elements");
                int max = SetNumber("max elements");
                int[,] matrix = GetRandomIntMatrix(rows, columns, min, max);
                PrintMatrixInt(matrix);

                PrintMatrixInt(matrix);
                break;
            case 50:
                Console.Clear();
                rows = SetNumber("rows");
                columns = SetNumber("columns");
                min = SetNumber("min elements");
                max = SetNumber("max elements");
                int elements = SetNumber("elements");
                int[,] matr = GetRandomIntMatrix(rows, columns, min, max);
                System.Console.WriteLine(SearchElements(matr, elements));
                PrintMatrixInt(matr);
                break;


            case 52:
                Console.Clear();
                rows = SetNumber("rows");
                columns = SetNumber("columns");
                min = SetNumber("min elements");
                max = SetNumber("max elements");
                int[,] array = GetRandomIntMatrix(rows, columns, min, max);
                PrintMatrixInt(array);
                SqrtSumma(array, rows, columns);
                break;
            default: System.Console.WriteLine("error"); break;
        }
    }
}

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[,] GetRandomDoubleMatrix(int rows, int columns, int min, int max)
{
    System.Console.WriteLine();

    double[,] array = new double[rows, columns];

    var rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round((rand.Next(min, max + 1 ) + rand.NextDouble()),3);
        }
    }

    return array;
}

int[,] GetRandomIntMatrix(int rows, int columns, int min, int max)
{
    System.Console.WriteLine();

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }

    return array;
}

void SortArray(int[,] matrix)
{
    System.Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }

}

void PrintMatrixInt(int[,] matrix)
{
    System.Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

string SearchElements(int[,] matrix, int elements)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == elements)  return $"Index elements {elements} = ({i}, {j})"; 
        }
    }
    return "Elements not found in matrix" ;

}

void SqrtSumma(int[,] array, int rows, int columns)
{
    for (int i = 0; i < columns; i++)
    {

        double sum = 0;
        for (int j = 0; j < rows; j++)
        {
            sum += array[j,i];
        }
        System.Console.WriteLine($"Arithmetic mean {i} columns = {sum / rows}");
    }
}