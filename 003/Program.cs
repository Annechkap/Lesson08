// 3.  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateArray(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 50);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

bool Control(int[,] rows, int[,] columns)
{
    if (rows.GetLength(1) == columns.GetLength(0))
    {
        return true;
    }
    return false;
}


int[,] NewMatrix(int[,] rows, int[,] columns)
{
    int[,] arraynew = new int[rows.GetLength(0), columns.GetLength(1)];
    for (int i = 0; i < rows.GetLength(0); i++)
    {
        for (int k = 0; k < columns.GetLength(1); k++)
        {
            int sum = 0;
            for (int j = 0; j < rows.GetLength(0); j++)
            {
                sum = sum + rows[i, j] * columns[i, j];
                arraynew[i, j] = sum;
            }
        }
    }
    return arraynew;
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int array = Convert.ToInt32(Console.ReadLine());
    return array;
}

int row1 = Prompt("Введите количество строк для первой матрицы:  ");
int column1 = Prompt("Введите количество столбцов для первой матрицы:    ");
Console.WriteLine();
int[,] Matrix1 = CreateArray(row1, column1);
PrintArray(Matrix1);
Console.WriteLine();
int row2 = Prompt("Введите количество строк для второй матрицы:  ");
int column2 = Prompt("Введите количество столбцов для второй матрицы:    ");
Console.WriteLine();
int[,] Matrix2 = CreateArray(row2, column2);
PrintArray(Matrix2);
Console.WriteLine();
if (Control(Matrix1, Matrix2))
{
    Console.WriteLine("Произведение матриц:");
    PrintArray(NewMatrix(Matrix1, Matrix2));
}
else
{
    Console.WriteLine("Произведение не возможно:");
}