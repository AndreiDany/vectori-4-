using System;

namespace vectori_4_
{   static class number
    {
       public static int nr=1;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibo = Fibonacci(5);
          
            for (int i = 1; i <=number.nr; i++)
            {
                Console.WriteLine(fibo[i-1]);
            }
        }
        

        static int[] Fibonacci(int n)
        {
            int[] F = new int[100];
            F[0] = 0;
            if(n==0) return F;
            F[1] = 1;
            if (n == 1) return F;
            int i = 1;
            number.nr = 2;
            while (F[i] < n)
            {
                number.nr++;
                i++;
                F[i] = F[i - 1] + F[i - 2];

            }
            return F;
        }
    }
}
