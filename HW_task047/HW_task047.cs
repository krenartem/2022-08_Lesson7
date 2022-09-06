//  Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
double[,] CreateNewRandomArray(int x, int y)
{
    double[,] RandomArray = new double[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            RandomArray[i, j] = Math.Round((new Random().NextDouble() * new Random().Next(-10, 11)), 2);
        }
    }
    return RandomArray;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Задайте размер массива m*n.");
Console.Write("Введите количество строк m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = int.Parse(Console.ReadLine());
double[,] ArrayMxN = CreateNewRandomArray(m, n);
PrintArray(ArrayMxN);