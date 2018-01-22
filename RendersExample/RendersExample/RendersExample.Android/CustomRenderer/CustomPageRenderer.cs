using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using RendersExample;
using RendersExample.Droid;

using static Java.Util.ResourceBundle;

[assembly:ExportRenderer(typeof(CustomPage),typeof(PageRenderer))]
namespace RendersExample.Droid.CustomRenderer
{
  public   class CustomPageRenderer: PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || Element == null)
            {
                return;
            }
            else if (e.NewElement != null)
            {

            }

          
        }
    }
}