using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("How many numbers do you want to enter:");
            int numbers = int.Parse(Console.ReadLine());

            int j;
            bool current = false;


            for (int i = 2; i <= numbers; i++)
            {

                for (j = 2; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        current = true;

                    }

                }

                if (current == false)
                {

                    Console.WriteLine("Enter Number: {0} ", j);

                }
                else current = false;

            }

        }
    }
}
