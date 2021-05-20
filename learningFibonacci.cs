using System;

/* Fibonacci Sequence
 * Built using instructor's example
 */

namespace learningFibonacci
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Calling the Fibonacci Sequence
            Sequence sqn = new Sequence();

            int[] x = sqn.get();
            foreach (int i in x)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class Sequence
    {

        // Creating an Array of integers to store the Fibonacci values
        int[] a = new int[102];

        // Generating the Fibonacci values
        public int[] get()
        {
            a[0] = 1;
            a[1] = 1;
            for (int i = 0; i < 100; i++)
            {
                a[i + 2] = a[i] + a[i + 1];
            }
            return a;
        }
    }

}
