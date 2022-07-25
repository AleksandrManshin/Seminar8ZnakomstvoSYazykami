void Zadacha57()
{
    Random random = new Random();
    int rows = random.Next(4,8);
    int columns = random.Next(4,8);
    int [,] array = new int [rows, columns];
    int [] dictionary = new int [10];

    FillArray(array);
    Console.WriteLine("Вывод массива: ");
    PrintArray(array);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            dictionary[array [i, j]] ++;
        }
    }

    Console.WriteLine();
    for(int i = 0; i < dictionary.Length; i++)
    {
        if(dictionary [i] != 0) Console.WriteLine($"Элемент {i} встречается {dictionary[i]} раз");
    }
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
            array [i, j] = random.Next(0, 9);
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

Zadacha57();