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
                PrintMatrixInt(SqrtArray(arrayOne, arrayTwo));
                break;


            case 60:
                Console.Clear();
                int[,,] matrix3d = new int[2, 2, 2];
                GetRandomMatrix3D(matrix3d);
                PrintMatrix3D(matrix3d);

                break;


            case 62:
                Console.Clear();

                break;
            default: System.Console.WriteLine("error"); break;
        }
    }
}


int SetNumber(string numberName = "")
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
    var array = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)]; ;
    if (arrayOne.GetLength(1) == arrayTwo.GetLength(0))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = 0;
                for (int k = 0; k < arrayOne.GetLength(1); k++)
                {
                    array[i, j] += arrayOne[i, k] * arrayTwo[k, j];
                }
            }
        }
    }
    return array;
}

void Fillarray(int[] array)
{
    var rand = new Random();
    int[] arrray = new int[8];
    for (int item = 0; item < arrray.Length; item++)
    {
        arrray[item] = rand.Next(10, 100);
    }
}

int[] SortMin(int[] matrix)
{
    for (int i = 0; i < matrix.Length - 1; i++)
    {
        for (int j = 0; j < matrix.Length - 1; j++)
        {
            if (matrix[j] > matrix[j + 1])
            {
                int tmp = matrix[j];
                matrix[j] = matrix[j + 1];
                matrix[j + 1] = tmp;
            }
        }
    }
    return matrix;
}

int[] SortDublicat(int[] array)
{
    int[] arrray = new int[8];
    Fillarray(arrray);
    SortMin(arrray);
    int count = 0;
    var rand = new Random();
    for (int i = 0; i < arrray.Length - 1; i++)
    {
        if (arrray[i] == arrray[i + 1])
        {
            arrray[i + 1] = rand.Next(10, 100);
            count += 1;
        }
    }

    count != 0 ?  SortDublicat(arrray) : return arrray;
   
}

int[,,] GetRandomMatrix3D(int[,,] array)
{
    System.Console.WriteLine();
    int[] arr = new int[8];
    SortDublicat(arr);
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = arr[count];
                count += 1;
            }
        }
    }
    return array;
}

void PrintMatrix3D(int[,,] array)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                System.Console.Write($"{array[i, j, k]} ( {i}, {j}, {k} )");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }

}
