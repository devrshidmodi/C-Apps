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
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    prime = false;
            }
            return prime; //Keep in mind that the best practice is to have one 'return' at the end.
        }

        // Question 2: 'Discriminant' returns b^2-4ac unless something goes wrong, in which case it returns NaN.
        public static double Discriminant(double a, double b, double c)
        {
            
            return ((Math.Pow(b,2)- (4*a*c))); //Keep in mind that the best practice is to have one 'return' at the end.
        }

        // Question 3: 'LinearEquationSolution' returns the solution to ax+b=0 unless something goes wrong,
        // in which case it returns NaN.
        public static double LinearEquationSolution(double a, double b, double c)
        {
      
            return ((c-b)/(a)); //Keep in mind that the best practice is to have one 'return' at the end.
        }

        // Question 4: 'Distance' returns the distance between (x1, y1) and (x2, y2) unless something goes wrong,
        // in which case it returns NaN.
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            
            return (Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)))); 
        }

        // Question 5: 'IsLeapYear' returns 'true' if 'year' is a leap year and 'false' otherwise.
        // Please keep in mind that the Gregorian calendar was not first adopted until 1582. Rules for
        // leap years were different under the Julian calendar.
        public static bool IsLeapYear(int year)
        {
            bool leapYear = true;
            if (year % 4 != 0 || (year % 100 == 0 && year % 400 != 0))
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

            //Doomsday for years 1700,2100,2500,2900,etc

            int k = 0;

            //Finding Doomsday for years 1500,1900,2300,2700,etc

            if ((year % 400 >= 300))
            {
                k = 3;
            }

            //Finding Doomsday for years 1600,2000,2400,2800,etc

            else if ((year % 400 < 100))
            {
                k = 2;
            }

            //Finding Doomsday for years 1800,2200,2600,3000,etc

            else if ((year % 400 >= 200) && (year % 400 < 300))
            {
                k = 5;
            }


            //Finding Doomsday For a specific year

            int a = (year % 100) / 12;
            int b = (year % 100) % 12;
            int c = b / 4;
            int d = (a + b + c) % 7;
            int dooms = (d + k) % 7;

            int basedate = 0;

            //Leap Year Exception for month of February
            if (month == "February" && (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)))
            {
                basedate = 1;
            }
            //Leap Year Exception for month of January
            else if (month == "January" && (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)))
            {
                basedate = 4;
            }
            //Non Leap Year for month of January
            else if (month == "January" && (year % 4 != 0 || (year % 100 == 0 && year % 400 != 0)))
                basedate = 3;
                   
            if (month == "September" || month == "December")
            {
                basedate = 5;
            }
            //Using Basedates for other Months which do not depend on whether or not year is prime
            else if (month == "June")
            {
                basedate = 6;
            }

            else if (month == "April" || month == "July")
            {
                basedate = 4;
            }

            else if (month == "October")
            {
               basedate = 3;
            }

            else if (month == "May")
            {
                basedate = 2;
            }

            else if (month == "August")
            {
                basedate = 1;
            }

            //Computing Day of Week
            int finalans = ((day - basedate) % 7 + dooms) % 7;

            dayOfWeek = "Sunday";
            
            if (finalans == 1)
                dayOfWeek = "Monday";
            else if (finalans == 2)
                dayOfWeek = "Tuesday";
            else if (finalans == 3)
                dayOfWeek = "Wednesday";
            else if (finalans == 4)
                dayOfWeek = "Thursday";
            else if (finalans == 5)
                dayOfWeek = "Friday";
            else if (finalans == 6)
                dayOfWeek = "Saturday";

            return dayOfWeek; //Keep in mind that the best practice is to have one 'return' at the end.
        }

        // Question 7: 'Gcd' returns the greatest common divisor of 'm' and 'n'.
        // If 'm' and 'n' are both zero, -1 is returned since gcd(0, 0) is undefined.

        public static int Gcd(int m, int n)
        {
            // gcd(0, 0) is undefined -> indicated by returning -1 since gcd(m, n) >= 0

            int gcd = -1;
            
            // Both integers are positive, therefore, the lowest gcd they can have is 1
            if (m >0 && n>0)
            
            gcd = 1;

            
            int smaller = Math.Min(m, n);
            
            // Working backwards to find GCD from the smaller number
            for (int i = smaller; i >= 2; i--)
            {
                if (m % i == 0 && n % i == 0)
                {
                    gcd = i;
                    break; 
                }
            }


            return gcd; //Keep in mind that the best practice is to have one 'return' at the end.
        }


    }






}
