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
                SortArray(matrix);
                PrintMatrixInt(matrix);
                break;
            case 56:
                Console.Clear();
                rows = SetNumber("rows");
                columns = SetNumber("columns");
                min = SetNumber("min elements");
                max = SetNumber("max elements");
                int[,] matr = GetRandomIntMatrix(rows, columns, min, max);
                PrintMatrixInt(matr);
                System.Console.WriteLine($"Minimal summa {Summa(matr).Item1} rows = {Summa(matr).Item2}");
                break;


            case 58:
                Console.Clear();
                rows = SetNumber("rows");
                columns = SetNumber("columns");
                min = SetNumber("min elements");
                max = SetNumber("max elements");
                int[,] arrayOne = GetRandomIntMatrix(rows, columns, min, max);
                int[,] arrayTwo = GetRandomIntMatrix(rows, columns, min, max);


                break;


            case 60:
                Console.Clear();

                break;


            case 62:
                Console.Clear();

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

int[,] SortArray(int[,] matrix)
{
    System.Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = matrix.GetLength(1) - 1; j > 0; j--)
        {
            for (int k = 0; k < j; ++k)
            {
                if (matrix[i, k] <= matrix[i, k + 1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }

        System.Console.WriteLine();
    }
    return matrix;
}

(int rows, int min) Summa(int[,] matrix)
{
    int[] matr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        matr[i] = sum;
    }
    int min = matr[0];
    int rows = 0;
    for (int k = 0; k < matr.Length; k++)
    {
        if (matr[k] < min)
        {
            min = matr[k];
            rows = k;
        }
    }
    return (rows, min);
}

int[,] SqrtArray(int[,] arrayOne, int[,] arrayTwo)
{
    int[] array = arrayOne;
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOne.GetLength(1); j++)
        {
            array[i, j] = arrayOne[i, j] * arrayTwo[i, j];
        }
    }
    return array;
}




// void PrintMatrixInt(int[,] matrix)
// {
//     System.Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// string SearchElements(int[,] matrix, int elements)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] == elements)  return $"Index elements {elements} = ({i}, {j})"; 
//         }
//     }
//     return "Elements not found in matrix" ;

// }

// void SqrtSumma(int[,] array, int rows, int columns)
// {
//     for (int i = 0; i < columns; i++)
//     {

//         double sum = 0;
//         for (int j = 0; j < rows; j++)
//         {
//             sum += array[j,i];
//         }
//         System.Console.WriteLine($"Arithmetic mean {i} columns = {sum / rows}");
//     }
// }