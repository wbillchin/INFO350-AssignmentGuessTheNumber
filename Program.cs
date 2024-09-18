/*
 * INFO 350 - Assignment Guess the Number
 * 
 * <replace with your name>
 * 
 * Write a program in C# that asks the user to guess the number
 * that is set as correctNumber.
 * 
 *  - Keep looping until the user guesses the right number
 *  - Keep track of the number of attempts and display it when the
 *    user has guessed correctly
 *  - Use all the console messages below correctly
 *  - How to read input is given below, incorporate into your finished product
 * 
 * 
 * Modify this code to complete this assignment
 */

using System;
class GuessTheNumberGame
{
    static void Main(string[] args)
    {
        int correctNumber = 7;
        int guess = 0;
        int attempts = 0;

        Console.WriteLine("You are playing Guess the Number");
        Console.WriteLine("I'm thinking of a number between 1 and 10.");



        //Console.Write("Enter your guess: ");

        /*
         *  This is how to read in from the console
         *  string input = Console.ReadLine();
         */

        /*
         *  Convert from that input string to an int
         *   int.TryParse(input, out guess)
         *   
         *   if the above TryParse is not successful, you need to output:
         *   
         *      Console.WriteLine("Please enter a valid number.");
         */

        // if the guess is too high, output and ask for input again
        //Console.WriteLine("Too high! Try again.");

        // if the guess is too low, output the following and ask for input again
        //Console.WriteLine("Too low! Try again.");

        // 
        //Console.WriteLine($"Congratulations! You guessed the correct number in {attempts} attempts!");



    }
}