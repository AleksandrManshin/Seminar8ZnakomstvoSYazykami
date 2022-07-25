//  Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

void Zadacha53()
{
    Random random = new Random();
    int rows = random.Next(4,8);
    int columns = random.Next(4,8);
    int [,] array = new int [rows, columns];

    FillArray(array);
    Console.WriteLine("Вывод массива: ");
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine("Обработанный массив: ");
    ChangeRows(array);
    PrintArray(array);
    
    // int i = array.GetLength(0)-1;
    // for(int j = 0; j < columns; j++)
    // {
    //     Console.Write(array[i,j] + "\t");
    // }
    // Console.WriteLine();

    // for(i = 1; i < array.GetLength(0)-1; i++)
    // {
    //     for(int j = 0; j < columns; j++)
    //     {
    //         Console.Write(array[i,j] + "\t");
    //     }
    //     Console.WriteLine();
    // }

    // i = 0;
    // for(int j = 0; j < columns; j++)
    // {
    //     Console.Write(array[i,j] + "\t");
    // }

}

void FillArray(int [,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array [i, j] = random.Next(1, 20);
        }
    }
}

void PrintArray(int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write(array [i, j] + "\t");
        }
        Console.WriteLine();
    }

}

void ChangeRows(int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for(int j = 0; j < columns; j++)
    {
        (array[0,j],array[rows-1,j])=(array[rows-1,j],array[0,j]);
    }
}

Zadacha53();
