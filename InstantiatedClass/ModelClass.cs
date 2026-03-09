using System;
using System.Collections.Generic;
using System.Text;

namespace InstantiatedClass
{
    public class ModelClass
    {
        //public string companyName;
        //public string modelName;
        //public string releseYear;

        public string companyName { get; set; } // This is more like the properties in C#,
                                                // which allows us to encapsulate the fields and provide getter and setter methods for them.
        public string modelName { get; set; }   // we can control what to get and what to set for the properties,
                                                // unlike simple fields where we can directly access and modify the values without any control.
        public string releseYear { get; set; }

    }
}
