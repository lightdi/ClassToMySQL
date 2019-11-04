using System;
using System.IO;
using System.Text.RegularExpressions;
using System.CodeDom.Compiler;
using System.Reflection;
using Microsoft.CSharp;

namespace ClassToMySQL.Class
{
    public class ReadClass
    {
        public bool IsOpen { get; set; }
        public string ClassName { get; set; }
        public ReadClass(string path)
        {
            OpenClass(path);
        }

        public void OpenClass(string path)
        {

        
            using (StreamReader file = new StreamReader(path))
            {

                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    // Find class name
                    if  (ln.Contains("Class"))
                    {
                        ClassName = "";
                    }

                }
                file.Close();
                
            }

        }

    }
}
