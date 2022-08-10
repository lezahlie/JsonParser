using System;

namespace AttributeProject  {
    
    [AttributeUsage(AttributeTargets.Property, AllowMultiple =true)] // allows attribute to be used on propeties only
    public class NoJsonAttribute : Attribute  {
        
        public readonly string Usage = "This property should be excluded from json parsing"; // usage info for NoJson attribute
        public bool ExcludeProperty() {

            return true; // returns true if ExcludeProprty method is called on
        }
    }

}

