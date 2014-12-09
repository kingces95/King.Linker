using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Library.Android;

namespace Application.Android {

    [Activity(Label = "Application.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity {
        int count = 1;

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            //var fooAqn = typeof(Foo).AssemblyQualifiedName;
            var fooAqn = "Application.Android.Foo, Application.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";
            var fooType = Type.GetType(fooAqn); // Bug. Expected fooType is null. Actual fooType not null

            //var viewAqn = typeof(ViewGroupSubclass).AssemblyQualifiedName;
            var viewAqn = "Application.Android.ViewGroupSubclass, Application.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";
            var viewType = Type.GetType(viewAqn); // Bug. Expected viewType is null. Actual viewType not null

            //var barAqn = typeof(Bar).AssemblyQualifiedName;
            var barAqn = "Library.Android.Bar, Library.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";
            var barType = Type.GetType(barAqn); // Ok. Expected barType is null. Actual barType is null

            var bazAqn = typeof(Baz).AssemblyQualifiedName;
            //var bazAqn = "Library.Android.Baz, Library.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";
            var bazType = Type.GetType(bazAqn); // Ok. Expected bazType is not null. Actual bazType is not null

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            var foo = typeof(Library.Pcl.MyClass);
        }
    }

    public class Foo { }
    public class ViewGroupSubclass : ViewGroup {
        public ViewGroupSubclass()
            : base(null) {
        }
        protected override void OnLayout(bool changed, int l, int t, int r, int b) {
            throw new NotImplementedException();
        }
    }
}

