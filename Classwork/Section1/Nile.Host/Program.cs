using System;

namespace Nile.Host
{
    class Program
    {
        static void Main( string[] args )
        {
        }

        static void PlayingWithPrimitives ()
        {
            //primitive
            decimal unitPrice = 10.5M;

            //real declaration
            //System.Decimal unitPrice2 = 10.5M
            Decimal unitPrice2 = 10.5M;

            //current time
            DateTime now = DateTime.Now;

            System.Collections.ArrayList items;
        }

        static void PlayingWithVariables ()
        {
            //single decls
            int hours = 0;
            //dont do this
            //int hours;
            //hours = 0;

            double rate = 10.25;

            //still not assigned
            //if (false)
            //    hours = 0;

            int hours2 = hours;

            //multiple decls
            string firstName, lastName;

            //string @class; (don't do this)

            //Single assignment
            firstName = "Bob";
            lastName = "Miller";

            //Multiple assignment
            firstName = lastName = "Sue";

            //math ops
            int x = 0, y = 10;
            int add = x + y;
            int subtract = x - y;
            int multiply = x * y;
            int divide = x / y;
            int modulos = x % y;


            //x = x + 10;
            x += 10;
            double ceiling = Math.Ceiling(rate);
            double floor = ceiling;
        }
    }
}
