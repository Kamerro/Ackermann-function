using System;

public class Program
{
    //Ackermann  function
    public static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    public static void GenerateAndPrintAckermannValues(int maxM, int maxN)
    {
        for (int m = 0; m <= maxM; m++)
        {
            for (int n = 0; n <= maxN; n++)
            {
                int result = Ackermann(m, n);
                Console.WriteLine($"Ackermann({m}, {n}) = {result}");
            }
        }
    }

    public static void Main()
    {
        //There must be change highest level of stack deep for get higher m and n without overflow.
        GenerateAndPrintAckermannValues(3, 3);
        Console.ReadKey();
    }
}