using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] array = new int[9]; 
        int Count = 0, oddCount = 0; 
        Console.WriteLine("Сгенерированный массив:");
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-50, 50); 
            Console.Write(array[i] + " ");

            if (array[i] % 2 == 0)
                Count++;
            else
                oddCount++;
        }
        Console.WriteLine($"\nЧетных элементов: {Count}, Нечетных элементов: {oddCount}");

        if (Count > oddCount)
            Console.WriteLine("Четных чисел больше.");
        else if (oddCount > Count)
            Console.WriteLine("Нечетных чисел больше.");
        else
            Console.WriteLine("Четных и нечетных чисел поровну.");
        Console.ReadKey();
    }
}
