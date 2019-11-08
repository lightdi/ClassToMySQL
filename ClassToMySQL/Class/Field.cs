using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;


namespace ClassToMySQL.Class
{
    public class Field
    {

        public string Name { get; set; }
        private string _type;
        public string Type { get => _type; 
            set {
                switch (value.ToLower())
                {
                    
                    case "int":
                        _type = "INT(11)";
                        Default = "0";
                        break;
                    
                    case "double":
                        _type = "DOUBLE(15,6)";
                        Default = "0.000000";
                        break;
                    
                    case "datetime":
                        _type = "TIMESTAMP";
                        Default = "2001-01-01 00:00:00";
                        break;
                        
                    case "long":
                        _type = "BIGINT(20)";
                        Default = "0";
                        break;

                    case "string":
                        _type = "VARCHAR(255)";
                        Default = "";
                        break;

                    default:
                        _type = "VARCHAR(255)";
                        Default = "";
                        break;
                }
            } 
        }
        public bool NotNull { get; set; }
        public bool HasDefault { get; set; }
        public string Default { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Field>(this);
        }

    }
}
