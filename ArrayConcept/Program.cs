using System;

namespace ArrayConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a=new int [6];
            int sum = 0;
            Console.WriteLine("Enter values for the array");
            
            for (int i = 0; i < 5; i++)
            {
               a[i]= Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < 5; j++)
            {
                
                sum = sum + a[j];
                
            }
            Console.WriteLine(sum);



        }
    }
}
