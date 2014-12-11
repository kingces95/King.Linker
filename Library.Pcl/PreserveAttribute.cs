using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Pcl {

    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Struct |
        AttributeTargets.Enum |
        AttributeTargets.Constructor |
        AttributeTargets.Method |
        AttributeTargets.Property |
        AttributeTargets.Field |
        AttributeTargets.Event |
        AttributeTargets.Interface |
        AttributeTargets.Delegate |
        AttributeTargets.All)]
    public class PreserveAttribute : Attribute {
        public bool AllMembers { get; set; }
    }
}
