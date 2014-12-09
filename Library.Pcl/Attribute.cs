using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Pcl
{
    public class MyAttribute : Attribute {
        public MyAttribute(object arguments) { } 
        public MyAttribute(MyEnum arguments) { } 
    }

    public enum MyEnum {
        MyEnumValue
    }
}
