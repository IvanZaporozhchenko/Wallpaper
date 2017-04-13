// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Wallpaper.iOS
{
    [Register ("MainView")]
    partial class MainView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImageView1 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageView1 != null) {
                ImageView1.Dispose ();
                ImageView1 = null;
            }
        }
    }
}