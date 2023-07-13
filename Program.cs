using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter an integer number between 5 and 15: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input >= 5 && input <= 15)
            {
                int[] array = Method1(input);
                Console.WriteLine("Array elements:");
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();

                int sum = Method2(array);
                Console.WriteLine("Sum of array elements: " + sum);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 5 and 15.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    static int[] Method1(int length)
    {
        Random random = new Random();
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(10, 51);
        }
        return array;
    }

    static int Method2(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }
}
