using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;


namespace ClassToMySQL.Class
{
    class Field
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public bool NotNull { get; set; }
        public string Default { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Field>(this);
        }

    }
}
