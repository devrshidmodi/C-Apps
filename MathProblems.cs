using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1_Homework_Assignment_3
{

    class MathProblems
    {
        // This class is used only for organizational purposes. No constructor is needed.

        /*
         * Below you have been given the signatures of all the methods needed to solve problems 1 to 7
         * on pages 23-24 of the Unit 1 notes, as well as a variable declaration and a 'return' statement.
         * 
         * public: Each method needs to be 'public' to allow it to be called from other classes.
         * static: Each method belongs to the class, not an object, and therefore should be 'static'.
         * 
         * Your job is to complete the methods. Please keep in mind that the best practice is to use ONLY ONE
         * 'return' statement at the end.
         */

        // Question 1: 'IsPrime' returns 'true' if 'n' is prime and 'false' otherwise
        public static bool IsPrime(int n)
        {
            bool prime = true;


            return prime; //Keep in mind that the best practice is to have one 'return' at the end.
        }

        // Question 2: 'Discriminant' returns b^2-4ac unless something goes wrong. 
        /*
         * The only thing that could go wrong in the computation of b^2-4ac is numeric overflow, that is, 
         * the result is either > the largest positive double value (1.79769313486232E308) or < the
         * "largest" negative value (−1.79769313486231570E308).
         * 
         * For example, a=-1E308, b=1E308, c=1E308 would result in b^2-4ac = (1E308)^2 - 4(-1E308)(1E308) = 5E616, 
         * which is hundreds of orders of magnitude greater than the largest double value. 
         * In this case, the value of the variable 'd' would be double.PositiveInfinity. If the result turned out
         * to be smaller than −1.79769313486231570E308, then the value of 'd' would be double.NegativeInfinity.
         * The returned value can never be double.NaN. NaN ("not a number") results from calculations involving
         * undefined operations such as dividing by zero or the square root of a negative number.
         */
        public static double Discriminant(double a, double b, double c)
        {
            // A local variable is not needed in this method. Simply return the result of computing
            // b^2-4ac, which can be a number, +infinity, or -infinity.

            return Math.Pow(b, 2) - 4 * a * c;
        }

        // Question 3: 'LinearEquationSolution' returns the solution to ax+b=c unless something goes wrong.
        // In this case, the result can be a number, +infinity, -infinity, or NaN. NaN will be the result
        // if division by zero occurs. Since the solution to this equation is x = (c-b)/a, NaN will be
        // the result if a=0.
        public static double LinearEquationSolution(double a, double b, double c)
        {
            // A local variable is not needed in this method. Simply return the result of computing
            // (c-b)/a, which can be a number, +infinity, -infinity, or NaN.

            // Temporary return statement to prevent "Not all code paths return a value" error
            return 0;
        }

        // Question 4: 'Distance' returns the distance between (x1, y1) and (x2, y2) unless something goes wrong.
        // As with the discriminant, the result can be a number, +infinity, or -infinity.
        // Although square root is involved in the calculation, NaN cannot be the result because the value of 
        // (x2 - x1)^2 + (y2 - y1)^2 is always zero or more.

        public static double Distance(double x1, double y1, double x2, double y2)
        {
            // A local variable is not needed in this method. Simply return the result of computing
            // sqrt((x2 - x1)^2 + (y2 - y1)^2), which can be a number, +infinity, or -infinity.

            // Temporary return statement to prevent "Not all code paths return a value" error
            return 0;

        }

        // Question 5: 'IsLeapYear' returns 'true' if 'year' is a leap year and 'false' otherwise.
        // Please keep in mind that the Gregorian calendar was not first adopted until 1582. Rules for
        // leap years were different under the Julian calendar.
        public static bool IsLeapYear(int year)
        {
            bool leapYear = true;

            // Multiplication has a higher precedence in arithmetic than addition; that is, x is 
            // performed before + in BEDMAS. Similarly, && has a higher precedence than || in Boolean logic. 
            // Therefore, the following condition is true only if 'year' is not divisible by 4 OR, 'year' 
            // is divisible by 100 but NOT by 400.
            if (year % 4 != 0 || year % 100 == 0 & year % 400 != 0)
            {
                leapYear = false;
            }

            return leapYear; //Keep in mind that the best practice is to have one 'return' at the end.
        }

        // Question 6: 'Doomsday' returns the day of the week given the month and year. The doomsday algorithm 
        // only works for dates after October 14, 1582. This is due to the fact that the Gregorian calendar was
        // first adopted on October 15, 1582 (October 4, 1582 Julian was followed by October 15, 1582 Gregorian).

        public static string Doomsday(string month, int day, int year)
        {
            string dayOfWeek = "";


            return dayOfWeek; //Keep in mind that the best practice is to have one 'return' at the end.
        }

        // Question 7: This method computes GCD(m, n) by brute force (exhaustive search).
        // 'Gcd' returns the greatest common divisor of 'm' and 'n'.
        // If 'm' and 'n' are both zero, -1 is returned since gcd(0, 0) is undefined.

        private static int Gcd(int m, int n)
        {
            // gcd(0, 0) is undefined -> indicated by returning -1 since gcd(m, n) >= 0
            int gcd = -1;


            return gcd; //Keep in mind that the best practice is to have one 'return' at the end.
        }


    }






}
