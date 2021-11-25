using System;

namespace vectori_4_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] fibo = Fibonacci(5);
            Console.WriteLine(fibo[0]);
            for (int i = 0; i < fibo.Length; i++)
            {
                if (fibo[i] != 0)
                Console.WriteLine(fibo[i]);
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
           
            while (F[i] < n)
            {
                i++;
                F[i] = F[i - 1] + F[i - 2];

            }
            return F;
        }
    }
}
