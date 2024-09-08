using System;

public class Program
{
    public static int CountEvenPositive(double[] arr)
    {
        int count = 0;
        foreach (double num in arr)
        {
            if (num > 0 && Math.Abs(num) % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    public static double SumInRange(double[] arr, double b, double d)
    {
        double sum = 0;
        foreach (double num in arr)
        {
            if (b <= num && num <= d)
            {
                sum += num;
            }
        }
        return sum;
    }

    public static void Main(string[] args)
    {
        double[] arr = { 1.2, 4.0, -3.5, 6.8, 2.0, 0.0, -1.0 };
        double b = 2.0;
        double d = 6.0;

        int evenPositiveCount = CountEvenPositive(arr);
        double sumInRangeResult = SumInRange(arr, b, d);

        Console.WriteLine($"Количество четных положительных элементов: {evenPositiveCount}");
        Console.WriteLine($"Сумма элементов в диапазоне [{b}, {d}]: {sumInRangeResult}");
    }
}