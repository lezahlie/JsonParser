using System;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using AttributeProject;
using System.Collections.Generic;
public class MyJsonParser {

    public static string parse(Object obj) {

        /* Uses linq to find the property info in obj param
           where the property doesn't have the no JSON attrubute
           then adds each property [name,value] to dictionary as <string=Name,object=Value> */

        Dictionary<string,object> allowedProps = obj.GetType().GetProperties()
                    .Where(prop => !(prop.GetCustomAttributes<NoJsonAttribute>().Any()))
                    .ToDictionary(prop => prop.Name, prop => prop.GetValue(obj));
        string jsonObj = JsonSerializer.Serialize(allowedProps); // Serializes List with to Json using Text.Json library
        return jsonObj;
    }

}