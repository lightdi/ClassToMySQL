using System;
using System.Collections.Generic;
using System.Text;

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

            }
            else
            {
            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(arguments.Target +
                        System.IO.Path.GetFileNameWithoutExtension(arguments.Source) 
                        + ".sql"))
                {
                   file.WriteLine(convert.ToString()); 
                }
            }
        }

        private void ConvertFromFolderTo()
        {

        }
    }
}
