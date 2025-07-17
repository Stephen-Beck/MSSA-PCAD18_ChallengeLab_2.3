/*
Write a C# Sharp program that takes a choice of character and a width as an integer. 
Then display a triangle of that width, using that character.

Test Data
    Enter a character: e
    Enter the desired width: 6

Expected Output:
eeeeee
eeeee
eeee
eee
ee
e
 */

namespace ChallengeLab_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a single character for the triangle to be made up of: ");
            char triangleChar = GetUserInputChar();
            Console.Write("Please enter an integer number for the triangle width: ");
            int triangleWidth = GetUserInputWidth();

            DisplayTriangle(triangleChar, triangleWidth);
        }

        static int GetUserInputWidth()
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

        static char GetUserInputChar()
        {
            char validInput = ' ';

            while (true)
            {
                if (char.TryParse(Console.ReadLine().Trim(), out validInput))
                    return validInput;
                else
                    Console.Write("Invalid entry. Please enter a single character: ");
            }
        }

        static void DisplayTriangle(char character, int width)
        {
            int height = 0;
            Console.WriteLine();

            while (height < width)
            {
                for (int i = 0; i < width - height; i++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
                height++;
            }
        }
    }
}
