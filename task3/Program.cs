// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int m = Readnum("Введите количество строк массива => ");
int n = Readnum("Введите количество столбцов массива => ");
int[,] massive = FillArray(m, n);
Print(massive);

midArifm(massive, m, n);
void midArifm(int[,] massive, int m, int n)
{
    for (int i = 0; i < n; i++)
    {
        float mid = 0;
        float summ = 0;
        for (int j = 0; j < m; j++)
        {
            int num = massive[j, i];

            summ += num;
        }
        mid = summ / m;
        System.Console.WriteLine($"Cреднее арифметическое элементов в {i + 1} столбце => {Math.Round(mid, 2)} ");
    }
}

int Readnum(string massage)
{
    System.Console.Write(massage);
    return Convert.ToInt32(System.Console.ReadLine());
}

int[,] FillArray(int m, int n)
{
    Random rand = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
    return array;

}

void Print(int[,] FillArray)
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



