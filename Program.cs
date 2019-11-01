using System;

namespace ClassToMySQL
{
    class Program
    {
        static void Main(string[] args)
        {

            /* This Software is made to read a file, folder with or without subfolders,
             * and converts the result few MySQL Scripts or Direct Create tables on Server.
             * The system has some arguments to configure the execution:
             * >Args to specify the source:
             *  -f To specify the file to convert
             *  -F To specify the folder to convert
             *  -s Must be used with -F, and specify to search on subfolders
             * >Args to specify the target
             *  -S To specify the server to create the table, ex. -S localhost
             *  -p To specify the password to the server
             *  -P To specify the port of the server, the default is 3006
             *  -u To specify the user of the server
             *  -O To specify the output folder to Script files
             * 
             */


            Console.WriteLine("Hello World!");
        }
    }
}
