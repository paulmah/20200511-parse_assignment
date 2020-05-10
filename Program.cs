using System;
using System.Linq; //To use Linq methods on our arrays
using System.IO; //To read from files

/**
Parser C# Weekend Assignment

C# Assignment

You are to write a C#  parser program which will have numbered options and a recurring menu (this means the menu will continuously run until we give the command, it saves us time from having to relaunch the program every time a task is done). Option 1 will allow the user to enter a filename, this will indicate which file we wish to parse. Option 2 will parse the data in the file specified by option 1, if no valid file is indicated, then the program should return an error message and then return the user to the menu. Option 3 will end the program.

Due Date: Monday May 11, 2020 9:00 AM on eclass under Graded Activities & Assignments > Individual Work > C# Assessments > Parser C# Weekend Assignment
Option 1 will prompt the user to enter a filename. The filename will be stored in a local variable.
Option 2 will prompt the user to enter a string. It will then go through the file specified by option 1 and replace any sequences of the user entered string with a blank space.
A while-loop menu: the menu will continue to display until option 3 is entered as input, at that point the program will terminate.
*/

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int endProg = 0; 
            string filename = "";
            while (endProg != 3){ //A while loop will check the condition before executing the code
                Console.WriteLine("     Option 1: Enter the file you want to parse"); //Option  not necessary, but helps with user understanding
                Console.WriteLine("     Option 2: Enter a string you would like to replace with a blank space "); //Option  not necessary, but helps with user understanding
                Console.WriteLine("     Option 3: End Program"); //Option  not necessary, but helps with user understanding
                // Console.WriteLine("Your selected file: " + filename ); // traceon
                string option = Console.ReadLine();
                // Console.WriteLine("selected: " + option); // traceon
                switch(option){
                    case "1":  // take filename input and verify file exists
                        Console.WriteLine("Please enter the filename of the file you would like to parse");
                        filename = Console.ReadLine();
                        if ( File.Exists( filename ) ) { // does filename exist 
                            // Console.WriteLine("Your selected file: " + filename ); // traceon
                        } else {
                            Console.WriteLine("Please enter a valid filename" );
                            filename = "";
                        }
                        break;
                    case "2":   // verify file exists and replace every instance of the string with " "
                        Console.WriteLine("You selected file: " + filename );
                        if ( File.Exists( filename ) ) { // does filename exist 
                            Console.WriteLine("Please enter the string you would like to replace with a space");
                            string replacement = Console.ReadLine();
                            // Console.WriteLine("You replacement string is: " + replacement );
                            string file_text = File.ReadAllText( filename );
                            file_text = file_text.Replace( replacement, " " );
                            // Console.WriteLine( file_text ); // traceon
                            File.WriteAllText( filename, file_text );
                        } else {
                            Console.WriteLine("Error: Please choose 1 first and enter a valid filename first" );
                        }
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
