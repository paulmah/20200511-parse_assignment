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
            string filename = "";
            while (endProg != 3){ //A while loop will check the condition before executing the code
                Console.WriteLine("     Option 1: Enter the file you want to parse"); //Option  not necessary, but helps with user understanding
                Console.WriteLine("     Option 2: Enter a string you would like to replace with a blank space "); //Option  not necessary, but helps with user understanding
                Console.WriteLine("     Option 3: End Program"); //Option  not necessary, but helps with user understanding
                Console.WriteLine("You selected file: " + filename ); // traceon
                string option = Console.ReadLine();
                Console.WriteLine("selected: " + option); // traceon
                switch(option){
                    case "1": 
                        Console.WriteLine("Please enter the filename of the file you would like to parse");
                        filename = Console.ReadLine();
                        if ( File.Exists( filename ) ) { // does filename exist 
                            Console.WriteLine("You selected file: " + filename );
                        } else {
                            Console.WriteLine("Please enter a valid filename" );
                            filename = "";
                        }
                        break;
                    case "2":
                        Console.WriteLine("You selected file: " + filename );
                        if ( File.Exists( filename ) ) { // does filename exist 
                            Console.WriteLine("Please enter the string you would like to replace with a space");
                            string replacement = Console.ReadLine();
                            Console.WriteLine("You replacement string is: " + replacement );
                            string file_text = File.ReadAllText( filename );
                            file_text = file_text.Replace( replacement, " " );
                            Console.WriteLine( file_text );
                            File.WriteAllText( "input_file1.txt", file_text );


                        } else {
                            Console.WriteLine("Please choose 1 first and enter a valid filename first" );
                        }
                        break;

//             File.WriteAllText("nextexample.txt", "Hello Again, World!"); //creates file if it exists and adds content to it, overwrites file content if file exists
//             readText = File.ReadAllText("nextexample.txt");
//             Console.WriteLine(readText);
//             File.Delete("nextexample.txt"); //Deletes a file






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
