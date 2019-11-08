using System;
using System.Collections.Generic;
using System.Text;

namespace ClassToMySQL.Class
{
    public class ConvertToMYSQL
    {
        private ReadClass readClass;
        private string sSQL;
        
        public bool LowCase { get; set; }
        public string  Engine { get; set; }
        public string Collate { get; set; }

        public ConvertToMYSQL(string classPath)
        {
            this.readClass = new ReadClass(classPath);
            this.LowCase = true;
            this.Engine = "InnoDB";
            this.Collate = "utf8_general_ci";

        }

        public ConvertToMYSQL( ReadClass readClass)
        {
            this.readClass = readClass;
            this.LowCase = true;
            this.Engine = "InnoDB";
            this.Collate = "utf8_general_ci";

        }

        public override string ToString()
        {
            GenerateScript();
            return sSQL ;
        }

        private void GenerateScript()
        {
            sSQL = "CREATE TABLE `" + (LowCase ? readClass.ClassName.ToLower() : readClass.ClassName) + "` (";

            //Create each fild
            readClass.Fields.ForEach(item =>
            {

                sSQL += " `" + item.Name + "` " + item.Type +
                    (item.NotNull ? " NOT NULL" : "") +
                    (item.HasDefault ? " DEFAULT '" + item.Default + "'" : "") +
                    (item.Name.ToLower() == "id" ? " AUTO_INCREMENT" : "") + ",";

            });

            sSQL += " PRIMARY KEY (`Id`),";
            //Create each index
            readClass.Fields.ForEach(item =>
            {
                if(item.Name.Contains("Id") && item.Name != "Id")
                {
                    sSQL += " INDEX `" + item.Name  + "` (`" + item.Name + "`),";
                }
            });
            sSQL = sSQL.Substring(0, sSQL.Length - 1);
            sSQL += ") COLLATE='" + Collate + "' ENGINE=" + Engine + ";";
        }

    }
}
