using System;

public class Program
{
     
    public static void Main(string[] args)
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Before shuffle: " + string.Join(", ", numbers));

        Shuffle(numbers);

        Console.WriteLine("After shuffle: " + string.Join(", ", numbers));

        Console.ReadKey();
    }

    public static void Shuffle(int[] numbers)
    {
        Random random = new Random();

        int i = numbers.Length;

        while (i > 1)
        {
            i--;
            int valueRandom = random.Next(i + 1);
            int temp = numbers[valueRandom];
            numbers[valueRandom] = numbers[i];
            numbers[i] = temp;
        }
    }
}