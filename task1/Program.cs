// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


int m = Readnum("Введите количество строк массива => ");
int n = Readnum("Введите количество столбцов массива => ");
double[,] massive = FillArray(m, n);
Print(massive);

int Readnum(string massage)
{
    System.Console.Write(massage);
    return Convert.ToInt32(System.Console.ReadLine());
}

double[,] FillArray(int m, int n)
{
    Random rand = new Random();
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.NextDouble() * rand.Next(-10, 10), 3);
        }
    }
    return array;

}

void Print(double[,] FillArray)
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
