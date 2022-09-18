//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

List <int> numbers = new List<int>();
int GenerationUniqueNumbers()
{
    while (true)
    {
        var k = new Random().Next(10,99);
        if (!numbers.Contains(k))
        {
            numbers.Add(k);
            return k;
        }
    }
}

int [,,] FillMatrix3D(int x, int y, int z)
{
    int [,,] matrix = new int [x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int l = 0; l < z; l++)
            {
                matrix [i,j,l] = GenerationUniqueNumbers();
            }    
        }    
    }
    return matrix;
}

void PrintMatrix3D(int [,,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            for (int l = 0; l < table.GetLength(2); l++)
            {
            Console.Write($"{table[i,j,l]}({i},{j},{l})\t");
            }
        }
        Console.WriteLine();
    }
}
int [,,] mas = FillMatrix3D(3,3,3);
PrintMatrix3D(mas);