using System;

class Program
{
    static void Main()
    {
        // Задаем размеры массива
        int rows = 3;
        int cols = 3;

        // Создаем рандомный массив
        int[,] array = GenerateRandomArray(rows, cols);

        // Выводим массив на экран
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Находим строку с наименьшей суммой элементов
        int minRowIndex = FindRowWithMinSum(array);

        // Выводим результат
        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minRowIndex}");
    }

    // Генерация рандомного массива
    static int[,] GenerateRandomArray(int rows, int cols)
    {
        Random random = new Random();
        int[,] array = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(1, 10); // Генерируем случайное число от 1 до 10
            }
        }

        return array;
    }

    // Вывод массива на экран
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

    // Поиск строки с наименьшей суммой элементов
    static int FindRowWithMinSum(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        int minSum = int.MaxValue;
        int minRowIndex = -1;

        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;

            for (int j = 0; j < cols; j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minRowIndex = i;
            }
        }

        return minRowIndex;
    }
}

