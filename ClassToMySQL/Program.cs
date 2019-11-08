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
             *  -u To specify the user of the server
             *  -p To specify the password to the server
             *  -P To specify the port of the server, the default is 3006
             *  -o To specify the output folder to Script files
             *  
             *  ex: 
             *      *From File to Folder
             *      ClassToMySQL -f product.cs -o c:\scripts
             *      
             *      *From Folder to Folder
             *      ClassToMySQL -F c:\product -o c:\scripts
             *      
             *      *From Folder and subfolders to Folder
             *      ClassToMySQL -F c:\product -s -o c:\scripts
             *      
             *      *From File to Server
             *      ClassToMySQL -f product.cs -S localhost -u root -p password -P 3306 
             *      
             *      *From Folder to Server
             *      ClassToMySQL -F c:\product -S localhost -u root -p password -P 3306 
             *      
             *      *From Folder and subfolders to Folder      
             *      ClassToMySQL -F c:\product -s -S localhost -u root -p password -P 3306 
             */

            if (args.Length ==0)
            {
                Console.WriteLine("*** No args passed ***");
                Console.WriteLine("This Software is made to read a file, folder with or without subfolders,");
                Console.WriteLine("and converts the result few MySQL Scripts or Direct Create tables on Server.");
                Console.WriteLine("The system required some arguments to configure the execution:");
                Console.WriteLine("> Args to specify the source:");
                Console.WriteLine("-f To specify the file to convert");
                Console.WriteLine("-F To specify the folder to convert");
                Console.WriteLine("-s Must be used with -F, and specify to search on subfolders");
                Console.WriteLine("> Args to specify the target");
                Console.WriteLine("-S To specify the server to create the table, ex. -S localhost");
                Console.WriteLine("-p To specify the password to the server");
                Console.WriteLine("-P To specify the port of the server, the default is 3006");
                Console.WriteLine("-u To specify the user of the server");
                Console.WriteLine("-O To specify the output folder to Script files");
                Console.WriteLine("ex: ");
                Console.WriteLine("*From File to Folder");
                Console.WriteLine(@"ClassToMySQL -f product.cs -o c:\scripts");
                Console.WriteLine("");
                Console.WriteLine("*From Folder to Folder");
                Console.WriteLine(@"ClassToMySQL -F c:\product -o c:\scripts");
                Console.WriteLine("");
                Console.WriteLine("*From Folder and subfolders to Folder");
                Console.WriteLine(@"ClassToMySQL -F c:\product -s -o c:\scripts");
                Console.WriteLine("");
                Console.WriteLine("*From File to Server");
                Console.WriteLine(@"ClassToMySQL -f product.cs -S localhost -u root -p password -P 3306 ");
                Console.WriteLine("");
                Console.WriteLine("*From Folder to Server");
                Console.WriteLine(@"ClassToMySQL -F c:\product -S localhost -u root -p password -P 3306 ");
                Console.WriteLine("");
                Console.WriteLine("*From Folder and subfolders to Folder");
                Console.WriteLine(@"ClassToMySQL -F c:\product -s -S localhost -u root -p password -P 3306 ");
            }

            






            
        }
    }
}
