// Task 52
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите число строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[m, n];
Random rnd = new Random();

for (int j = 0; j < n; j++)
{   
    double sum = 0;
    Console.WriteLine((j + 1) + " столбец: ");
    for (int i = 0; i < m; i++)
    {   
        array[i, j] = rnd.Next(0,100);
        Console.WriteLine(array[i, j] + " ");
        sum += array[i, j];
    } 
    Console.WriteLine("Среднее арифметическое элементов столбца: {0}", sum / m);
    Console.WriteLine();
}

