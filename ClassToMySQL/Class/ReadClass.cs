using System;
using System.IO;
using System.Text.RegularExpressions;
using System.CodeDom.Compiler;
using System.Reflection;
using Microsoft.CSharp;
using  System.Diagnostics;
using System.Collections.Generic;

namespace ClassToMySQL.Class
{
    public class ReadClass
    {
        //private
        private List<Field> fields;

        //public 
        public bool IsOpen { get; set; }
        public string ClassName { get; set; }
        public List<Field> Fields => fields;
        public ReadClass(string path)
        {
            OpenClass(path);
        }
        public void OpenClass(string path)
        {

        
            using (StreamReader file = new StreamReader(path))
            {
                fields = new List<Field>();
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    //Debug.WriteLine(ln);
                    
                    // Find class name
                    if  (ln.Contains("class"))
                    {
                       
                        // Here we call Regex.Match.
                        Match match = Regex.Match(ln, @"Class ([A-Za-z0-9\-]+)",
                            RegexOptions.IgnoreCase);

                        // Here we check the Match instance.
                        if (match.Success)
                        {
                            // Get the class name
                            ClassName = match.Groups[1].Value;
                            //Debug.WriteLine(ClassName);
                            
                        }

                    }

                    //Find property
                    if (ln.Contains("{ get; set; }"))
                    {
                        //Here we call Regex.Match.
                        Match match = Regex.Match(ln, @"public\s+([A-Za-z0-9\-]+\s+[A-Za-z0-9\-]+)\s+{",
                            RegexOptions.IgnoreCase);

                        // Here we check the Match instance.
                        if (match.Success)
                        {
                            // Add fild to list
                            string fieldString = match.Groups[1].Value.Trim();
                            Field field = new Field() { Name = Regex.Split(fieldString, @"\s+")[1].Trim(), Type = Regex.Split(fieldString, @"\s+")[0].Trim() };

                            field.NotNull = true;
                            field.HasDefault = !(field.Name == "Id");
                                                        
                            fields.Add(field);

                            //Debug.WriteLine(ClassName);
                        }
                    }

                }
                file.Close();
                
            }

        }
        public override string ToString()
        {
            String Json = "{";
            Json += "\"" + ClassName + "\":{";

            foreach (var item in fields)
            {
                Json += "\"" + item.Name + "\":{";
                Json += "\"Type\":\"" + item.Type + "\",";
                Json += "\"NotNull\":\"" + item.NotNull + "\",";
                Json += "\"Default\":\"" + item.Default  + "\"";
                Json += "},";
            }


            Json = Json.Substring(0, Json.Length - 1) + "}}";
            return Json;
        }

    }
}
