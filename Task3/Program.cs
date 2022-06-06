//3. Написать программу, которая в двумерном массиве заменяет строки на столбцы 
// или сообщить, что это невозможно (в случае, если матрица не квадратная).

Console.WriteLine("Введите количество строк в массиве: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в массиве: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("------------------");


if (a != b) Console.Write("Матрица не квадратная! Поменять строки и столбцы невозможно!");
else
{
    
int[,] Mass = new int[a, b];

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray_Change(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write($"{array[j, i]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

    FillArray(Mass);
    PrintArray(Mass);
    PrintArray_Change(Mass);

}