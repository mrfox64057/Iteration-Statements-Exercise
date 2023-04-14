using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace IterationStatements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //OneToThosand();
            Twelve(5);

        }
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void OneToThosand()
        {
            for (int i = -1000; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool isEqual(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Write a method to check whether a given number is even or odd

        static void OddOrEven()
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
        //Write a method to check whether a given number is positive or negative
        bool isNegative(int n)
        {
            int i;
            for (i = 0; i <= int.MaxValue; i++)
            {
                if (n == i)
                    return false;
            }
            return true;
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanRegister()
        {
            for (int i = 0; i < 18; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        static void Range()
        {
            Console.Write("Input a first number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m >= -10 && m <= 10 || (n >= -10 && n <= 10));
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void Twelve(int a)
        {
            
            {

                for (int j = 1; j <= 12; j++) 
                {
                    Console.WriteLine(a * j);                    
                }

                ////Console.WriteLine("Multiplication table: " + table);
                //for (i = 1; i <= length; i++)
                //{

                //    Console.WriteLine("{0, 2} * {1, 2} = {2}", i, table, i * table);
                //}
            }
        }
    }
    //static void Main(string[] args)
    //{
    //    int a, b;
    //    for (a = 1; a <= 12; a++)
    //    {
    //        Console.Write("\n");
    //        for (b = 1; b <= 10; b++)
    //        {
    //            Console.Write("\n " + a * b);

    //        }
    //    }
        //Call the methods to test them in the Main method below
        //static void Main(string[] args)
        //{

        //}
    }

