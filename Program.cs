using System;

namespace Solution9
{
    public class solution9
    {
        static int Addition()
        {
            Console.WriteLine("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int sum = x + y;
            Console.WriteLine($"The addition: {sum}");
            return sum;
        }
        static int Subtraction()
        {
            Console.WriteLine("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int subtraction = x - y;
            Console.WriteLine($"The subtraction: {subtraction}");
            return subtraction;
        }
        static int multiplication()
        {
            Console.WriteLine("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int multiplication = x * y;
            Console.WriteLine($"The multiplication: {multiplication}");
            return multiplication;
        }
        static double division()
        {
            Console.WriteLine("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            double division = (double)x / y;
            Console.WriteLine($"The division: {division}");
            return division;
        }
        static int modulus()
        {
            Console.WriteLine("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int Modulus = x % y;
            Console.WriteLine($"The Modulus: {Modulus}");
            return Modulus;
        }
        static double Combination()
        {
            Console.WriteLine("Enter n: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter r: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int nf = 1, rf = 1, nrf = 1;
            double result;

            for (int i = x; i > 1; i--)
            {
                nf = nf * i;
            }
            for (int i = y; i > 0; i--)
            {
                rf = rf * i;
            }
            for (int i = x - y; i > 1; i--)
            {
                nrf = nrf * i;
            }
            result = (double)nf / (rf * nrf);
            Console.WriteLine($"Combination: {result}");
            return result;
        }
        static void Permutation()
        {
            Console.WriteLine("Enter n: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter r: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y && x>0 && y > 0)
            {
                int nf = 1, nrf = 1;
                double result;

                for (int i = x; i > 1; i--)
                {
                    nf = nf * i;
                }
                for (int i = x - y; i > 1; i--)
                {
                    nrf = nrf * i;
                }
                result = (double)nf / nrf;
                Console.WriteLine($"Permutation: {result}");
            }
            else
            {
                Console.WriteLine("please enter x ≥ y ≥ 0");
            }


        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, user! This is a calculator!");
            Console.WriteLine("Here are operations you can do: addition, subtraction, multiplication, division, modulus, combination and permutation.\n");
            Console.Write("Please enter an operation: ");
            string a = Console.ReadLine();
            if (a.ToLower() == "addition")
            {
                Addition();
            }
            else if (a.ToLower() == "subtraction")
            {
                Subtraction();
            }
            else if (a.ToLower() == "multiplication")
            {
                multiplication();
            }
            else if (a.ToLower() == "division")
            {
                division();
            }
            else if (a.ToLower() == "modulus")
            {
                modulus();
            }
            else if (a.ToLower() == "combination")
            {
                Combination();
            }
            else if (a.ToLower() == "permutation")
            {
                Permutation();
            }
            else
            {
                Console.WriteLine("Wrong name operation!");
            }

        }
    }
}



