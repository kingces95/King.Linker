using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Pcl
{
    //[My(MyEnum.MyEnumValue)] // expected behavior: build succeeds becuase linker preserves MyEnum
    [My((object)MyEnum.MyEnumValue)] // unexpected behavior: build fails because linker strips MyEnum
    public class MyClass {
    }
}
