using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            SubMain();

            Console.ReadLine();
        }

        public static void SubMain()
        {
            start:
            Console.WriteLine("This is a calculator basically for Permutaion" +
                " and Combination");
            Console.WriteLine("------------------------------------------" +
                "-----------------------------------------------------------");
            Console.WriteLine("What problem do you want to solve? \n a. Permutation " +
                "b. Combination");
            string problem = Console.ReadLine().ToLower();
            if (problem == "permutation" || problem == "a")
            {
                Console.WriteLine("Input the value of n");
                double n = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("--------------------------------------------" +
                    "------------------------------------------");
                
                double factorial = 1;
                for (double i = n; i >= 1; i--)
                {
                    //Console.Write(i + " ");
                    if (true)
                    {
                        factorial = factorial * i;
                    }

                }
                Console.WriteLine(n +"! is " + factorial);

                Console.WriteLine("Input the value of r");
                double r = Convert.ToDouble(Console.ReadLine());
                double sum = n - r;
                Console.WriteLine("--------------------------------------------" +
                    "------------------------------------------");
                double fact = 1;
                for (double i = sum ; i >= 1; i--)
                {
                    //Console.Write(i + " ");
                    if (true)
                    {
                        fact = fact * i;
                    }
                }
                Console.Write("("+n+"-"+r+")" + "! is " + fact);
                double result = factorial/fact;
                Console.WriteLine("\n The result is therefore " + result);
                Console.WriteLine("-----------------------------------------------------" +
                    "----------------------------------------------");
                Console.WriteLine("-----------------------------------------------------" +
                    "----------------------------------------------");
                Console.WriteLine("-----------------------------------------------------" +
                    "----------------------------------------------");
                Console.WriteLine("-----------------------------------------------------" +
                    "----------------------------------------------");

            }
            else if (problem == "combination" || problem == "b")
            {
                Console.WriteLine("Input the value of n");
                double n = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("--------------------------------------------" +
                    "------------------------------------------");
                double factorial = 1;
                for (double i = n; i >= 1; i--)
                {
                    //Console.Write(i + " ");
                    if (true)
                    {
                        factorial = factorial * i;
                    }

                }
                Console.WriteLine("n! is "+n + "! = " + factorial);

                Console.WriteLine("Input the value of r");
                double r = Convert.ToDouble(Console.ReadLine());
                double sum = n - r;
                Console.WriteLine("--------------------------------------------" +
                    "------------------------------------------");
                double fact = 1;
                for (double i = sum; i >= 1; i--)
                {
                    //Console.Write(i + " ");
                    if (true)
                    {
                        fact = fact * i;
                    }
                }
                Console.WriteLine("(n-r)! is "+"(" + n + "-" + r + ")" + "! = " + fact);

                double factor = 1;
                for (double i = r; i >= 1; i--)
                {
                    if (true)
                    {
                        factor = factor * i;
                    }
                    
                }
                Console.WriteLine("r! is " + r+"! = "+ factor);
                Console.WriteLine("-----------------------------------" +
                    "--------------------------------------------------------");

                double product = fact * factor;
                
                double result1 = factorial / product;

                Console.WriteLine("The result is therefore " + result1);
                Console.WriteLine("-----------------------------------------------------" +
                    "------------------------------");
                Console.WriteLine("-----------------------------------------------------" +
                    "----------------------------------------------");
                Console.WriteLine("-----------------------------------------------------" +
                    "----------------------------------------------");
            }
            else
            {
                Console.WriteLine("Please input a valid problem");
            }
            goto start;
           
        }
    }
}
