using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicholasUramkin.MovieLib.Host
{
    class Program
    {
        static void Main( string[] args )
        {
            bool quit = false;
            while(!quit)//while quit is false
            {
                //display menu
                char choice = DisplayMenu();

                //process user's menu choice
                switch (Char.ToUpper(choice))
                {
                    case 'L': ListMovies(); break;
                    case 'A': AddMovie(); break;
                    case 'R': RemoveMovie(); break;
                    case 'Q': quit = true; break;//change quit to true to end the loop
                }
            };
        }

        private static void RemoveMovie()
        {
            if (String.IsNullOrEmpty(_title))
            {
                Console.WriteLine("There is no movie to delete");

                Console.WriteLine("\nPress ENTER to continue");
                Console.ReadLine();
                Console.Clear();

                return;
            }

            Console.Write("Are you sure you want to delete the movie(Y/N)?: ");

            string input = Console.ReadLine();

            input = input.ToUpper();

            if (input == "Y")
            {
                _title = "";

                _description = "";

                _length = 0;

                _owned = false;

                Console.WriteLine("\nMovie removed");
                Console.WriteLine("\nPress ENTER to continue");
                Console.ReadLine();
            }

            Console.Clear();
        }

        static void AddMovie()
        {
            if (!String.IsNullOrEmpty(_title))
            {
                Console.WriteLine("Movie already exists.  Do you want to overwrite it(Y/N)?");

                string input = Console.ReadLine();

                input = input.ToUpper();

                Console.Clear();

                if (input == "N")
                    return;

            }
            
            //get title
            _title = ReadString("Enter title: ", true);

            //get description
            _description = ReadString("Enter description(optional): ", false);

            //get runtime (length)
            _length = ReadInt("How long is the movie in minutes?(optional, enter 0 to skip): ", 0);

            //get owned status
            _owned = ReadBool("Do you own this movie(Y/N)?: ", true);

            Console.Clear();
        }

        private static bool ReadBool( string message, bool isRequired )//can only be used for yes or no input
        {
            do
            {
                Console.Write(message);

                string value = Console.ReadLine();

                value = value.ToUpper();

                if (!isRequired)//default for non required values will be false
                {
                    return false;
                };

                if (value == "Y")
                    return true;
                else if (value == "N")
                    return false;

                //error message
                Console.WriteLine("Please Enter Y for Yes or N for No");
            } while (true);
        }

        private static int ReadInt( string message, int minValue )
        {
            do
            {
                Console.Write(message);

                string value = Console.ReadLine();

                if (Int32.TryParse(value, out int result))
                {
                    //if not required
                    if (result >= minValue)
                        return result;
                }

                //output error message
                string msg = String.Format("Value must be {0} or higher", minValue);
                Console.WriteLine(msg);

            } while (true);
        }

        private static string ReadString(string message, bool isRequired )
        {
            do
            {
                Console.Write(message);

                string value = Console.ReadLine();

                //if not required or string is empty
                if (!isRequired || value != "")
                    return value;

                Console.WriteLine("Value is required.");

            } while (true);
        }

        private static void ListMovies()
        {
            if (!String.IsNullOrEmpty(_title))
            {
                Console.WriteLine(_title);

                //if null or empty ommit description
                if (!String.IsNullOrEmpty(_description))
                    Console.WriteLine(_description);

                //if 0 ommit length
                if(_length != 0)
                    Console.WriteLine("Run time = {0} mins", _length);

                string owned = "";

                if (_owned == true)
                    owned = "Owned";
                else if (_owned == false)
                    owned = "Not Owned";

                Console.WriteLine("Status = {0}", owned);
            } else
                Console.WriteLine("No Movie");

            Console.WriteLine("\nPress ENTER to continue");
            Console.ReadLine();
            Console.Clear();
        }

        private static char DisplayMenu()
        {
            do
            {
                //output menu
                Console.WriteLine("L)ist Movie");//made movies singular until we update program to hold multiple movies
                Console.WriteLine("A)dd Movie");
                Console.WriteLine("R)emove Movie");
                Console.WriteLine("Q)uit");

                //input choice
                string input = Console.ReadLine();

                Console.Clear();

                input = input.ToUpper();

                //return user choice if valid
                if (input == "L")
                    return input[0];
                else if (input == "A")
                    return input[0];
                else if (input == "R")
                    return input[0];
                else if (input == "Q")
                    return input[0];

                //let user know they picked an invalid option
                Console.WriteLine("Invavlid choice.  Please choose a valid choice.");

            } while(true);       
        }

        //data for a movie
        static string _title;
        static string _description;
        static int _length;
        static bool _owned;
    }
}
