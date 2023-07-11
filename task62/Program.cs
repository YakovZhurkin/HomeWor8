// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int Columns = 4;
int Rows = 4;

int[,] MyArray = new int[Columns, Rows];
SpiralFillArray(MyArray,Columns, Rows);
PrintArray(MyArray,Columns, Rows); 


void PrintArray(int[,] array,int COL, int ROWS)
{
    Console.WriteLine($"Массив, имеющий размер {COL} х {ROWS}, заполнен по спирали.");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + " ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SpiralFillArray(int[,] array, int Col,int Row)
{
    int valueElement = 1;
    int i = 0;
    int j = 0;
    while (valueElement <= Col * Row)
    {
        array[i, j] = valueElement;
        if (i <= j + 1 && i + j < Col - 1)
            j++;
        else if (i < j && i + j >= Row - 1)
            i++;
        else if (i >= j && i + j > Col - 1)
            j--;
        else                                 
            i--;
    }
}
