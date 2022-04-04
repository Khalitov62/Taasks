using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1, 5.3, 10, 99.99 };


            Action<double[]> action = TotalPrice;
            
            

            Action<double[]> action1 = Total;
            action += action1;
            action(array);
            

        }

        public static void TotalPrice(double[] array)
        {
            
            double total = default(double);

            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];

                
            }
            Console.WriteLine(total);
        }
        
        public static void Total(double[] array)
        {
            
            int count = default(int);

            for (int i = 0; i < array.Length; i++)
            {
                count++;
               
            }
            Console.WriteLine(count);
        }
    }
}
