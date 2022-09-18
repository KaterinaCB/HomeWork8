//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int [,] CompositionMatrix(int [,] matrix1, int [,] matrix2)
{
    var matrix3 = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int l = 0; l < matrix1.GetLength(1); l++)
                {
                    matrix3[i,j] += matrix1[i,l] * matrix2[l,j];
                }
            }
        }
    }
    return matrix3;
}

int [,] mas = FillMatrix(3,3);
PrintMatrix(mas);
Console.WriteLine();
int [,] mas2 = FillMatrix(3,3);
PrintMatrix(mas2);
Console.WriteLine();
PrintMatrix(CompositionMatrix(mas, mas2));


