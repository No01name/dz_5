using System;

class Program
{
    static void Main()
    {
        // Указываем размеры массива
        int rows = 5; // количество строк
        int cols = 3; // количество столбцов

        // Создаем двумерный массив случайных чисел
        int[,] array = GenerateRandomArray(rows, cols);

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Меняем местами первую и последнюю строки
        SwapRows(array, 0, rows - 1);

        // Выводим массив после замены строк
        Console.WriteLine("\nМассив после замены строк:");
        PrintArray(array);
    }

    // Метод для создания двумерного массива случайных чисел
    static int[,] GenerateRandomArray(int rows, int cols)
    {
        Random random = new Random();
        int[,] array = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(1, 100); // случайное число от 1 до 99
            }
        }

        return array;
    }

    // Метод для вывода двумерного массива
    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Метод для обмена местами двух строк в массиве
    static void SwapRows(int[,] array, int row1, int row2)
    {
        int cols = array.GetLength(1);
        for (int j = 0; j < cols; j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
}

