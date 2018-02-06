/* Nicholas Uramkin
 * 02/05/2018
 * ITSE-1430
 * Lab 1
 * Program for adding, listing, and removing movies and their title, description, runtime, and ownership status to a library.  
 * In this first version the program will only store one movie at a time.
 * The program will call a function for displaying the menu, 
 *  then take the user choice to call one of three functions that either add, remove, or list a movie.
 * The adding function will call one of three reading functions corresponding to the data type being read, 
 *  passing in a message to the user and whether that data is optional or not.
 */
using System;

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
                switch (Char.ToUpper(choice))//make choice case insensitive
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
            //Test if there is movie to delete
            //if there is no movie stored, let user know and return to menu
            if (String.IsNullOrEmpty(_title))
            {
                Console.WriteLine("There is no movie to delete");

                Console.WriteLine("\nPress ENTER to continue");
                Console.ReadLine();//pause until user hits enter
                Console.Clear();//clear console screen

                return;//exit function
            }

            while (true)//loop in case user makes invalid input
            {
                Console.Write("Are you sure you want to delete the movie(Y/N)?: ");

                string input = Console.ReadLine();//user inputs Y or N

                input = input.ToUpper();//make input case insensitive

                Console.Clear();

                if (input == "Y")//if yes, delete movie and return to menu
                {
                    _title = "";
                    _description = "";
                    _length = 0;
                    _owned = false;

                    Console.WriteLine("Movie removed");
                    Console.WriteLine("\nPress ENTER to continue");
                    Console.ReadLine();
                    Console.Clear();
                    return;
                } 
                else if (input == "N")//else if no, return to menu
                    return;
                else//else give user error message and loop back
                    Console.WriteLine("Please enter Y for Yes or N for No");

            };

            
        }

        static void AddMovie()
        {
            //test if there is already a movie stored
            //if there is, warn user that entering new movie will overwrite the old one
            if (!String.IsNullOrEmpty(_title))
            {
                while (true)//loop in case invalid input
                {
                    Console.WriteLine("Movie already exists.  Do you want to overwrite it(Y/N)?");

                    string input = Console.ReadLine();//user inputs Y or N

                    input = input.ToUpper();

                    Console.Clear();

                    if (input == "Y")//if yes, break from loop and continue rest of function
                        break;
                    else if (input == "N")//if no, exit function
                        return;
                    else//give error message and loop back
                        Console.WriteLine("Please enter Y for Yes or N for No");
                };

            }
            
            //call value reading functions, pass message for user and required status/min value
            //get title
            _title = ReadString("Enter title: ", true);

            //get description
            _description = ReadString("Enter description(optional): ", false);

            //get runtime (length)
            _length = ReadInt("How long is the movie in minutes?(optional, enter 0 to skip): ", 0);// is min value

            //get owned status
            _owned = ReadBool("Do you own this movie(Y/N)?: ", true);

            Console.Clear();
        }

        private static bool ReadBool( string message, bool isRequired )//can only be used for yes or no input
        {
            do
            {
                Console.Write(message);//output passed in message

                string value = Console.ReadLine();//user enters y or n

                value = value.ToUpper();

                if (!isRequired)//default for non required values will be false
                {
                    return false;
                };

                if (value == "Y")//if yes return true
                    return true;
                else if (value == "N")//if no return false
                    return false;

                //error message before loop back
                Console.WriteLine("Please Enter Y for Yes or N for No");
            } while (true);
        }

        private static int ReadInt( string message, int minValue )
        {
            do
            {
                Console.Write(message);//output message for user

                string value = Console.ReadLine();//user inputs integer value as a string

                if (Int32.TryParse(value, out int result))//if string value entered is an integer, convert string to int
                {
                    //if greater or equal to minValue, return int result
                    if (result >= minValue)
                        return result;
                }

                //output error message before loopback
                string msg = String.Format("Value must be {0} or higher", minValue);
                Console.WriteLine(msg);

            } while (true);
        }

        private static string ReadString(string message, bool isRequired )
        {
            do
            {
                Console.Write(message);//output passed in message to user

                string value = Console.ReadLine();//user inputs

                //if not required or not empty string value
                if (!isRequired || value != "")
                    return value;

                Console.WriteLine("Value is required.");//output error before loopback

            } while (true);
        }

        private static void ListMovies()
        {
            if (!String.IsNullOrEmpty(_title))//if title is not null or empty, list movie
            {
                Console.WriteLine(_title);//output title of movie

                //if description is not null or empty, output description(omit if empty or null)
                if (!String.IsNullOrEmpty(_description))
                    Console.WriteLine(_description);

                //if not 0 output lenght(omit if 0)
                if(_length != 0)
                    Console.WriteLine("Run time = {0} mins", _length);

                string owned;//variable to convert _owned status to designated string value

                if (_owned == true)
                    owned = "Owned";
                else//only other option is false b/c _owned is bool
                    owned = "Not Owned";

                Console.WriteLine("Status = {0}", owned);//output string as owned or not owned
            } else
                Console.WriteLine("No Movie");//let user know there is no movie stored to display

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

        //variables to store data for a movie
        static string _title;
        static string _description;
        static int _length;
        static bool _owned;
    }
}
