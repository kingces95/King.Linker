using Library.Pcl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Thie attribute, when applied at the assembly level, does have an effect
//[assembly: Preserve]

namespace Library.Pcl
{
    [My(MyEnum.MyEnumValue)] // expected behavior: build succeeds becuase linker preserves MyEnum
    //[My((object)MyEnum.MyEnumValue)] // unexpected behavior: build fails because linker strips MyEnum
    public class MyClass {
    }

    [Preserve]
    public class PreserveThisType {
        public int DoNotPreserveThisProperty { get; set; }
    }

    [Preserve]
    public class PreserveThisTypeAndSomeMembers {

        [Preserve]
        public int PreserveThisProperty { get; set; }
        public int DoNotPreserveThisProperty { get; set; }
    }

    [Preserve(AllMembers = true)]
    public class PreserveThisTypeAndAllMembers {
        public int PreserveThisProperty { get; set; }
    }
}
