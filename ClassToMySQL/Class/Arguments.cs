using System;
using System.Collections.Generic;
using System.Text;

namespace ClassToMySQL.Class
{
    public class Arguments
    {

        public Arguments(string[] args)
        {

           for (var i = 0; i < args.Length;  i++)
           {
                switch (args[i])
                {
                    case "-f":
                        Source = args[i + 1];
                        break;

                    case "-F":
                        FromFolder = true;
                        Source = args[i + 1];
                        break;

                   case "-s":
                        SubFolders = true;
                        break;

                    case "-S":
                        ToServer = true;
                        Server  = args[i + 1];
                        break;

                    case "-u":
                        User = args[i + 1];
                        break;

                    case "-p":
                        Password  = args[i + 1];
                        break;

                    case "-P":
                        Port = args[i + 1];
                        break;

                    case "-o":
                        Target = args[i + 1];
                        break;

                    default:
                        break;
                }


            }

        }

        //Source
        public bool FromFolder { get; set; }
        public string Source { get; set; }
        public bool SubFolders { get; set; }

        //Target
        public bool ToServer { get; set; }
        public string Server { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Port { get; set; }
        public string Target { get; set; }
    }
}
