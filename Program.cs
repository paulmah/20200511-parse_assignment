using System;
using System.Linq; //To use Linq methods on our arrays
using System.IO; //To read from files

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
                        /*While/Do While Loop*/

            int endProg = 0; 

            while (endProg != 3){ //A while loop will check the condition before executing the code
                Console.WriteLine("Option 1: Enter the file you want to parse"); //Option  not necessary, but helps with user understanding
                Console.WriteLine("Option 2: Enter a string you would like to replace with a blank space "); //Option  not necessary, but helps with user understanding
                Console.WriteLine("Option 3: End Program"); //Option  not necessary, but helps with user understanding
                string option = Console.ReadLine();
                Console.WriteLine("selected: " + option); // traceon
                switch(option){
                    case "1": 
                        Console.WriteLine("Please enter the filename of the file you would like to parse");
                        string filename = Console.ReadLine();
                        if ( File.Exists( filename ) ) { // does filename exist 
                            Console.WriteLine("You selected file: " + filename );
                        } else {
                            Console.WriteLine("Please enter a valid filename" );
                            filename = "";
                        }
                        break;
                    case "2":
                        Console.WriteLine("string you want to replace is ...");
                        break;
                    case "3":
                        endProg = 3;    // arbitrarily choose 3 to match the option to end program
                        break;
                    default:
                        Console.WriteLine("Error: Invalid selection"); //default is reserved for error checking/handling
                        break;
                }



            }

            Console.WriteLine("Thank you for using the parser program");
        }
    }
}
