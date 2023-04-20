// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

int m = Readnum("Введите количество строк массива => ");
int n = Readnum("Введите количество столбцов массива => ");
int[,] massive = FillArray(m, n);
Print(massive);
int row = Readnum("Введите строку массива => ");
int colum = Readnum("Введите столбец массива => ");
test(massive, colum, row);

void test(int[,] massive, int row, int colum)
{
    if (row <= m && colum <= n)
    {
        System.Console.WriteLine($"{massive[row - 1, colum - 1]}");
    }
    else
    {
        System.Console.WriteLine("Этого элемента нет");
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
            array[i, j] = rand.Next(-10, 10);
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


