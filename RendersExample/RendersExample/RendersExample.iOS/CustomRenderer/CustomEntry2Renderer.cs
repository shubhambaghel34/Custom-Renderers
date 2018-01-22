using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using RendersExample;
using Xamarin.Forms;
using RendersExample.iOS;

[assembly:ExportRenderer(typeof(CustomEntry2),typeof(CustomEntry2Renderer))]
namespace RendersExample.iOS
{
  public   class CustomEntry2Renderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.Blue;
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}