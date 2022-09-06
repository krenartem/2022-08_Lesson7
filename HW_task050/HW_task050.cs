//  Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
Console.Clear();
int[,] Array = new int[10, 10];
int number = 3;
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Array[i, j] = number + number * i + number * j;
    }
}
Console.WriteLine("Есть массив:");
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Console.Write(Array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите позиции элемента в массиве через пробел, чтобы узнать его значение");
string coordinates = Console.ReadLine();
string[] numbers = coordinates.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int x = Convert.ToInt32(numbers[0]);
int y = Convert.ToInt32(numbers[1]);
if (x < 0 || x > 9)
{
    Console.WriteLine("Элемент лежит за пределами массива");
}
else
{
    if (y < 0 || y > 9)
    {
        Console.WriteLine("Элемент лежит за пределами массива");
    }
    else
    {
        Console.WriteLine($"Значение элемента массива с позицией {x}:{y} = {Array[x, y]}");
    }
}
