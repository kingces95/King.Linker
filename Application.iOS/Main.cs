using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Application.iOS {
    public class Application {
        // This is the main entry point of the application.
        static void Main(string[] args) {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            
            //var fooAqn = typeof(Foo).AssemblyQualifiedName;
            var fooAqn = "Application.iOS.Foo, ApplicationiOS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";
            var fooType = Type.GetType(fooAqn); // ok. Expected fooType is null. Actual fooType is null.

            //var viewAqn = typeof(UIViewSubclass).AssemblyQualifiedName;
            var viewAqn = "Application.iOS.UIViewSubclass, ApplicationiOS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";
            var viewType = Type.GetType(viewAqn); // bug. Expected viewType is null. Actual is viewType is not null.

            UIApplication.Main(args, null, "AppDelegate");
        }
    }

    public class Foo { }
    public class UIViewSubclass : UIView { }
}
