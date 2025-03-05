using System;

class Program
{
    static void Main()
    {
        int[] array = new int[14];
        int Count = 0; 
        Console.WriteLine("Введите 14 целых чисел:");

        for (int i = 0; i < 14; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());

            if (array[i] % 2 == 0) 
                Count++;
        }

        Console.WriteLine("\nВведённый массив:");
        Console.WriteLine(string.Join(" ", array));

        
        Console.WriteLine($"Количество чётных элементов: {Count}");
        Console.ReadLine();
    }
}

