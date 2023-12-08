using System;

class Program
{
    static void Main()
    {
        // Задаем размеры массива
        int rows = 3;
        int cols = 3;

        // Создаем рандомный двумерный массив
        int[,] array = GenerateRandomArray(rows, cols);

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Находим наименьший элемент и его индексы
        int minElement = array[0, 0];
        int minRow = 0;
        int minCol = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        // Удаляем строку и столбец с минимальным элементом
        int[,] newArray = RemoveRowAndColumn(array, minRow, minCol, rows, cols);

        // Выводим новый массив
        Console.WriteLine("\nНовый массив после удаления строки и столбца с минимальным элементом:");
        PrintArray(newArray);
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
                array[i, j] = random.Next(1, 10); // Диапазон случайных чисел от 1 до 100
            }
        }

        return array;
    }

    // Вывод массива в консоль
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

    // Удаление строки и столбца
    static int[,] RemoveRowAndColumn(int[,] array, int rowToRemove, int colToRemove, int rows, int cols)
    {
        int[,] newArray = new int[rows - 1, cols - 1];

        for (int i = 0, newRow = 0; i < rows; i++)
        {
            if (i == rowToRemove)
                continue;

            for (int j = 0, newCol = 0; j < cols; j++)
            {
                if (j == colToRemove)
                    continue;

                newArray[newRow, newCol] = array[i, j];
                newCol++;
            }

            newRow++;
        }

        return newArray;
    }
}

