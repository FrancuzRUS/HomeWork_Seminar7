//1. Написать программу, которая обменивает элементы первой строки и последней строки

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

Console.WriteLine("Введите количество строк в массиве: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в массиве: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("------------------");

int[,] MASS = new int[a, b];

// PrintArray(MASS);
FillArray(MASS);
PrintArray(MASS);


for (int j = 0; j < MASS.GetLength(1); j++)
{
    int temp = MASS[0, j];
    MASS[0, j] = MASS[MASS.GetLength(0) - 1, j];
    MASS[MASS.GetLength(0) - 1, j] = temp;
}

PrintArray(MASS);

