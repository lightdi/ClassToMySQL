using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MySql.Data.MySqlClient;

namespace ClassToMySQL.Class
{
    public class ConvertTo
    {
        private Arguments arguments;
        public ConvertTo(Arguments arguments)
        {
            this.arguments = arguments;
        }

        public ConvertTo(string[] args)
        {
            this.arguments = new Arguments(args);
        }
        public void Convert()
        {

            if (arguments.FromFolder )
            {
                
                ConvertFromFolderTo();
                
            }
            else
            {
                ConvertFromFileTo();
            }

        }
        private void ConvertFromFileTo()
        {
            ConvertToMYSQL convert = new ConvertToMYSQL(arguments.Source);
            if (arguments.ToServer)
            {
                ExecuteMySQLInstruction(convert.ToString());

            }
            else
            {
                SaveSQLFile(arguments.Target +
                       System.IO.Path.GetFileNameWithoutExtension(arguments.Source)
                       + ".sql", convert.ToString());
            }
        }

        private void ConvertFromFolderTo()
        {
            if(arguments.ToServer )
            {
                foreach (string classPath in Directory.EnumerateFiles(arguments.Source, "*.cs", 
                    arguments.SubFolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly ))
                {
                    ConvertToMYSQL convert = new ConvertToMYSQL(classPath);
                    SaveSQLFile(arguments.Target +
                       System.IO.Path.GetFileNameWithoutExtension(classPath)
                       + ".sql", convert.ToString());
                }
            }
            else
            {
                foreach (string classPath in Directory.EnumerateFiles(arguments.Source, "*.cs",
                    arguments.SubFolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly))
                {
                    ConvertToMYSQL convert = new ConvertToMYSQL(classPath);
                    ExecuteMySQLInstruction ( convert.ToString());
                }
            }

        }

        private void SaveSQLFile(string path, string sSQL)
        {
            using (System.IO.StreamWriter file =
                            new System.IO.StreamWriter(path))
            {
                file.WriteLine(sSQL);
            }
        }
        private void ExecuteMySQLInstruction(string sSQL)
        {
            //Open the connection with MySQL server
            MySqlConnection myConnection;
            string connectionString = "server={0};user id={1};password={2};Port={3};Database={4};Pooling=True;Allow Zero Datetime=True;SslMode=none;connection timeout=30;";

            connectionString = String.Format(connectionString, arguments.Server, arguments.User, arguments.Password, arguments.Port, arguments.Database);

            myConnection = new MySqlConnection(connectionString);

            myConnection.Open();

            MySqlCommand myCommand;

            //Execute MySQL instruction
            try
            {
                myCommand = new MySqlCommand(sSQL, myConnection);
                myCommand.CommandTimeout = 2000;

                long iRetorno = myCommand.ExecuteNonQuery();

                myConnection.Close();
            }
            catch (Exception e)
            {

                myCommand = null;
                throw e;
            }
        }
    }
}
