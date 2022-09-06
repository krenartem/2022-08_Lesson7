// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateArray(int x, int y)
{
    int number = new Random().Next(1, 6);
    int[,] Array = new int[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Array[i, j] = number + number * new Random().Next(1, 4) * i + number * new Random().Next(1, 4) * j;
        }
    }
    return Array;
}

void PrintArray(int[,] inArray)
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

double[] CalculateAverages(int[,] InputArray)
{
    double sum = 0;
    double[] Averages = new double[InputArray.GetLength(1)];
    for (int j = 0; j < InputArray.GetLength(1); j++)
    {
        for (int i = 0; i < InputArray.GetLength(0); i++)
        {
            sum = sum + InputArray[i, j];
        }
        Averages[j] = Math.Round((sum / InputArray.GetLength(0)), 2);
        sum = 0;
    }
    return Averages;
}

Console.Clear();
Console.Write("Задайте размер двумерного массива через пробел:");
string size = Console.ReadLine();
string[] numbers = size.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int x = Convert.ToInt32(numbers[0]);
int y = Convert.ToInt32(numbers[1]);
int[,] ArrayForCalculates = CreateArray(x, y);
Console.WriteLine("Есть массив:");
PrintArray(ArrayForCalculates);
double[] ArrayOfAverages = CalculateAverages(ArrayForCalculates);
Console.WriteLine("Средние арифметические по столбцам:");
Console.WriteLine(String.Join(" ", ArrayOfAverages));