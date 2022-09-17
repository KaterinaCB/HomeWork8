//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int [,] SortLines(int [,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1)-1; j++)
        {
            for (int l = 0; l < massiv.GetLength(1)-1; l++)
            {
                if (massiv[i,l] < massiv[i,l+1])
                {
                    int temp = 0;
                    temp = massiv[i,l];
                    massiv[i,l] = massiv[i,l+1];
                    massiv[i,l+1] = temp;
                }
            }
        }
    }
    return massiv;
}

int [,] mas = FillMatrix(3,3);
Console.WriteLine("Массив до сортировки: ");
PrintMatrix(mas);
int [,] mas2 = SortLines(mas);
Console.WriteLine("Массив после сортировки: ");
PrintMatrix(mas2);
