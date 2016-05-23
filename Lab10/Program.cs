using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Lab 10
// Date: 02/08/2015 12:30:27 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to enter the length of one side of a right triangle.
            Console.WriteLine("What is the length of the first side in inches?");

            //Get the user's input and saves it in an appropriate variable.
            double side1 = double.Parse(Console.ReadLine());

            //Ask the user to enter the length of the other side of the triangle.
            Console.WriteLine("What is the length of the second side in inches?");

            //Get the user's input and saves it in an appropriate variable.
            double side2 = double.Parse(Console.ReadLine());

            //Call your CalcHypotenuse method and pass in the lengths of the two sides of the triangle as parameters.
            //Save the value returned by the method in an appropriate variable.
            double answer = CalcHypotenuse(side1, side2);

            //Properly label and display the value returned by the method.
            Console.WriteLine($"The length of the hypotenuse is {answer:N}");
            Console.ReadLine();
        }

        /// <summary>
        /// Hypotenuse Calculator
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <returns>newHyp</returns>
        static double CalcHypotenuse(double side1, double side2)
        {
            //Take the input side1 and square it
            double newSide1 = side1 * side1;

            //Take the input side2 and sqaure it
            double newSide2 = side2 * side2;

            //Take the new side1 & side2 and add them together
            double hyp = newSide1 + newSide2;

            //Take the square root of the sum
            double newHyp = Math.Sqrt(hyp);

            //Return the value
            return newHyp;
        }
    }
}
