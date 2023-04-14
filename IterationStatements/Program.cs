using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace IterationStatements
{
    public class Program
    {
        public static void Main()
        {
            OneToThosand();
            Twelve(5);
            OddOrEven();
            Range();
            IsNegative(6);
            CanRegister();


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
        public static bool IsEqual(int a, int b)
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

        public static void OddOrEven()
        {
            Console.Write("Enter a Number : ");
            int i = int.Parse(Console.ReadLine());
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
        public static bool IsNegative(int n)
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
            Console.WriteLine($"and how old might you be?");
            int i = int.Parse(Console.ReadLine());
            if (i <= 17) 
            {
                Console.WriteLine("I am sorry to inform you but you are not old nuff yet scrub");
            }
       
            else
            {
                Console.WriteLine("Why did you even ask boomer?");
            }  
           

        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void Range()
        {
            bool userResponse;
            int result;

            do
            {
                Console.WriteLine("Pick a number, pick a number");//why does this repeat twice?

                userResponse = int.TryParse(Console.ReadLine(),out result);

            }while (!userResponse);
            if (result >= -10 && result <= 10) 
            {
                Console.WriteLine($"{result} is between neagative 10 and 10");
            }
            else 
            {
                Console.WriteLine($"Sorry but {result} was not in between negative 10 and 10, try again");

            }
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

        //Call the methods to test them in the Main method below
        //static void Main(string[] args)
        //{

        //}
    }

