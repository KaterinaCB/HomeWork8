//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void PrintMatrix(int [,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int [,] FillMatrix(int line, int column)
{
    int [,] array = new int [line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array [i,j] = new Random().Next(1,10);
        }    
    }
    return array;
}

int [,] mas = FillMatrix(3,5);
PrintMatrix(mas);

void MinSumOfLine(int [,] matrix)
{
    int index = 0;
    int minsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов в строке № {index+1}.");
}
MinSumOfLine(mas);




