/*
 * ITSE 1430
 * 
 * Section 1
 */
using System;

namespace Nile.Host
{
    class Program
    {
        static void Main( string[] args )
        {
            bool quit = false;
            while (!quit)
            {
                //equality
                bool isEqual = quit.Equals(10);

                //diplay menu
                char choice = DisplayMenu();

                //process menu selection
                switch (Char.ToUpper(choice))
                {
                   // case 'l':
                    case 'L': ListProducts(); break;

                    //case 'a':
                    case 'A': AddProduct(); break;

                    //case 'q':
                    case 'Q': quit = true; break;
                };
            };
        }

        static void AddProduct ()
        {
            //get name
            _name = ReadString("Enter name: ", true);

            //get price
            _price = ReadDecimal("Enter price: ", 0);

            //get description
            _description = ReadString("Enter optional description: ", false);
        }

        private static decimal ReadDecimal( string message, decimal minValue )
        {
            do
            {
                Console.Write(message);

                string value = Console.ReadLine();

                if (Decimal.TryParse(value, out decimal result));
                {
                    //if not required or not empty
                    if (result >= minValue)
                        return result;
                };

                //formatting strings
                string msg = String.Format("Value must be >= {0}", minValue);
                Console.WriteLine(msg);
                //Console.WriteLine("Value must be >= {0}", minValue);
            } while (true);
        }

        private static string ReadString(string message, bool isRequired )
        {
            do
            {
                Console.Write(message);

                string value = Console.ReadLine();

                //if not required or not empty
                if (!isRequired || value != "")
                    return value;

                Console.WriteLine("Value is required");
            } while (true);
        }

        private static char DisplayMenu()
        {
            do
            {
                Console.WriteLine("L)ist Products");
                Console.WriteLine("A)dd Product");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();

                //remove whitespace
                input = input.Trim();

                //input.ToLower();
                input = input.ToUpper();

                //padding (similar to setw in c++)
                //input = input.PadLeft(10);

                //starts with
                //input.StartsWith(@"\");
                //ends with
                //input.EndsWith(@"\");

                //substring
                //string newValue = input.Substring(0, 10);

                //if (input == "L")
                if (String.Compare(input, "L", true) == 0)
                    return input[0];
                else if (input == "A")
                    return input[0];
                else if (input == "Q")
                    return input[0];
                
                Console.WriteLine("Please choose a valid option");
            } while (true);
         }

        static void ListProducts()
        {
            //are there any products
            //if (_name != null && _name != "")
            if (!String.IsNullOrEmpty(_name))
            {
                //display a product - name [$price]
                //                    <description>

                //string formatting
                //var msg = String.Format("{0} [${1}]", _name, _price);

                //string concatenation
                //var msg = _name + " [$" + _price + "]";

                //string concat pt2
                //var msg = String.Concat(_name, " [$", _price, "]");

                //string interpolation
                string msg = $"{_name} [${_price}]";

                Console.WriteLine(msg);
                //Console.WriteLine(_name);
                //Console.WriteLine("${0}", _price);

                if (!String.IsNullOrEmpty(_description))
                Console.WriteLine(_description);

            } else
                Console.WriteLine("No Products");
        
        }

        //data for a product
        static string _name;
        static decimal _price;
        static string _description;

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

        static void PlayingWithReferences ()
        {
            string message = "Hello";
            string name = null;

            name = new string('*', 10);

            object instance = name;

            //casting
            //is
            if (instance is string)
            {
                string str2 = (string)instance;
                Console.WriteLine(str2);
            } else
                Console.WriteLine("Not a string");

            //as operator
            string str = instance as string;
            if (str != null)
            {
                Console.WriteLine(str);
            } else
                Console.WriteLine("Not a string");

            //pattern matching
            if (instance is string str3)
            {
                Console.WriteLine(str3);
            } else
                Console.WriteLine("Not a string");

        }
    }

}
