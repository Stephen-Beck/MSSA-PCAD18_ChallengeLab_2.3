/*
Write a C# Sharp program that takes a number and a width also a number, as input. 
Display a triangle of that width, using that number.

Test Data
    Enter a number: 6
    Enter the desired width: 6

Expected Output:
666666
66666
6666
666
66
6
 */

namespace ChallengeLab_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triangleNumber = 0;
            int triangleWidth = 0;

            Console.Write("Please enter an integer number for the triangle to be made up of: ");
            triangleNumber = GetUserInput();
            Console.Write("Please enter an integer number for the triangle width: ");
            triangleWidth = GetUserInput();

            DisplayTriangle(triangleNumber, triangleWidth);
        }

        static int GetUserInput()
        {
            int validInput = 0;

            while (true)
            {
                if (int.TryParse(Console.ReadLine().Trim(), out validInput))
                    return validInput;
                else
                    Console.Write("Please enter a valid integer value: ");               
            }
        }

        static void DisplayTriangle(int number, int width)
        {
            int height = 0;
            Console.WriteLine();

            while (height < width)
            {
                for (int i = 0; i < width - height; i++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
                height++;
            }
        }
    }
}
