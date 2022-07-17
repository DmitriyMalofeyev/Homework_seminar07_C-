// Task 50
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите число строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int numberB = Convert.ToInt32(Console.ReadLine());
numberA--;
numberB--;

int[,] array = new int[m, n];

Random rnd = new Random();
Console.WriteLine("Определен массив: ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rnd.Next(-100, 100);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

if ( numberA >= m || numberB >= n || numberA < 0 || numberB < 0)
{
    Console.WriteLine("Введеная позиция за пределами массива");
}
else
Console.WriteLine("Элемент в заданных строке и столбце: " + array[numberA, numberB]);
