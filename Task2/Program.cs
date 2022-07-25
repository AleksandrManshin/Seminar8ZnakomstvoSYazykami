// Задача 55: Задайте двумерный массив. Напишите программу, которая
// заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

void Zadacha55()
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
    if (rows == columns)
    {
    ChangeArray(array);
    PrintArray(array);
    }
    else Console.WriteLine("Изменить массив невозможно, так как кол-во строчек и столбцов не совпадает");
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

void ChangeArray(int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    for(int i = 0; i < columns; i++)
    {
        for(int j = i; j < rows; j++)
        {
            int temp = array [i,j];
            array[i,j] = array [j,i];
            array[j,i] = temp;
        }
    }
}

Zadacha55();