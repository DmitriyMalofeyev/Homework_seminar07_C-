// Task 47
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите число строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

Random rnd = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rnd.NextDouble();
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

