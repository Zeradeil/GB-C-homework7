// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


int m = Readnum("Введите количество строк массива => ");
int n = Readnum("Введите количество столбцов массива => ");
System.Console.WriteLine($"{m}, {n}");
float[,] massive = FillArray(m, n);
Print(massive);

int Readnum(string massage)
{
    System.Console.Write(massage);
    return Convert.ToInt32(System.Console.ReadLine());
}

float[,] FillArray(int m, int n)
{
    Random rand = new Random();
    float[,] array = new float[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.NextDouble();
        }
    }
    return array;

}

void Print(float[,] FillArray)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            System.Console.Write($"{massive[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}
