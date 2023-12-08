using System;

class Program
{
    static void Main()
    {
        // Генерация случайного двумерного массива (3x3 для примера)
        int[,] array = GenerateRandomArray(2, 3);

        Console.WriteLine("Случайный двумерный массив:");
        PrintArray(array);

        Console.WriteLine("Введите позиции элемента в массиве:");

        Console.Write("Введите индекс строки: ");
        int rowIndex = int.Parse(Console.ReadLine());

        Console.Write("Введите индекс столбца: ");
        int colIndex = int.Parse(Console.ReadLine());

        int result = GetArrayElement(array, rowIndex, colIndex);

        if (result != int.MinValue)
        {
            Console.WriteLine($"Значение элемента в позиции [{rowIndex}, {colIndex}]: {result}");
        }
        else
        {
            Console.WriteLine($"Элемента в позиции [{rowIndex}, {colIndex}] не существует.");
        }
    }

    static int[,] GenerateRandomArray(int numRows, int numCols)
    {
        Random random = new Random();
        int[,] array = new int[numRows, numCols];

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                array[i, j] = random.Next(1, 100); // Задайте нужный диапазон значений
            }
        }

        return array;
    }

    static void PrintArray(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static int GetArrayElement(int[,] array, int rowIndex, int colIndex)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        if (rowIndex >= 0 && rowIndex < numRows && colIndex >= 0 && colIndex < numCols)
        {
            return array[rowIndex, colIndex];
        }

        // Если позиция выходит за границы массива, возвращаем int.MinValue как признак отсутствия элемента
        return int.MinValue;
    }
}

