using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimondStarprintpractics
{
     class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, l;
            Console.WriteLine("Enter the number of rows:");
            n = Convert.ToInt32(Console.ReadLine());
            //for left side triangle
            /*
             for (i = 1; i <=n; i++)
            {
                
                for (j = 1; j <=i; j++)
                    
                {
                    Console.Write("*.");
                }
                Console.WriteLine();
               

            }
            Console.ReadLine();
            */
            //for right side triangle
            /*
             for(i=1;i<=n; i++)
             {
                 for (l = 1; l <=n-i; l++)
                 {
                     Console.Write("  ");
                 }
                 for (j = 1; j <= i; j++)
                 {
                     Console.Write("* ");
                 }
                 Console.WriteLine();
             }
             Console.ReadLine();
             */
            // reverse left side triangle
            /* for (i = n; i >= 1; i--)
             {
                 for (j = 1; j <= i; j++)
                 {
                     Console.Write("* ");
                 }
                 Console.WriteLine();
             }
             Console.ReadLine();
            */
            // reverse right side triangle
            /* for (i=n;i>=1;i--)
             {
                 for (l=1;l<=n-i;l++)
                 {
                     Console.Write("  ");
                 }
                 for (j=1;j<=i;j++)
                 {
                     Console.Write("* ");
                 }
                 Console.WriteLine();
             }
             Console.ReadLine();
            */

            //central triangle pattern
            /*
             for(i=1;i<=n;i++)
             {
                 for (l = 1; l <= n - i; l++)
                 {
                     Console.Write("  ");
                 }
                 for (j = 1; j <=(2*i-1); j++)
                 {
                     Console.Write("* ");
                 }
                 Console.WriteLine();
             }
             Console.ReadLine();
            */
            //reverse central triangle pattern
            for (i = n; i >= 1; i--)
            {
                for (l = 1; l <= n - i; l++)
                {
                    Console.Write("  ");
                }
                for (j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
