using System;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;

            Console.WriteLine("Learn your squares and cubes!\n");

            while (runProgram == true)
            {
                Console.WriteLine("Enter an integer: ");
                int numInput = int.Parse(Console.ReadLine());
                Console.WriteLine("");


                if (numInput <= 0 || numInput > 1290)
                {
                    Console.WriteLine($"{numInput} is not vaid input.");
                    continue;
                }
               
                chartTable(numInput);
                Console.WriteLine("");

                Console.WriteLine("Continue? (y/n)");
                string loopAnswer = Console.ReadLine();
                if (loopAnswer == "n")
                {
                    runProgram = false;
                }
                Console.WriteLine("");
            }
        }

        public static void chartTable(int numInput)
        {
            Console.WriteLine("Number\tSquared\tCubed");
            Console.WriteLine("=====\t=====\t=====");
            
            for (int i = 1; i <= numInput; i++)
            //Max Int is 1290
            {

                int square = i * i;
                int cube = square * i;
                Console.WriteLine($"{i} \t {square} \t {cube}");
            }
            
            
        }
    }
}
