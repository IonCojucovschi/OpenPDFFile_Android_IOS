// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ReaderXamarin
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton openBtn { get; set; }

        [Action ("OpenBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OpenBtn_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (openBtn != null) {
                openBtn.Dispose ();
                openBtn = null;
            }
        }
    }
}