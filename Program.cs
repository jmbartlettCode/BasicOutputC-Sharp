/* 
Josh Bartlett
23June2019
Assignment 1.2
Display a statement that defines program comments
*/

using System;

namespace Assignment_1._2___Josh_Bartlett
{
    class Program
    {
        static void Main(string[] args)
        {
            // Outputs contents to console
            Console.WriteLine("Program Comments are " +
                "nonexecuting statements that document " +
                "a program and programmers use these to " +
                "leave notes for themselves and for others " +
                "who might read their programs.");

            Console.Write("Press any key to continue...");

            // Keeps console open until a key is pressed
            Console.ReadKey(true);
        }
    }
}
