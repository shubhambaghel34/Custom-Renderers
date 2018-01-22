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
using Xamarin.Forms;
using RendersExample;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;

[assembly: ExportRenderer(typeof(CustomEntry2), typeof(RendersExample.Droid.CustomRenderer.CustomEntry2Renderer))]
namespace RendersExample.Droid.CustomRenderer
{
  public   class CustomEntry2Renderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control == null || Element == null || e.OldElement != null) return;
           
            var element = (CustomEntry2)Element;
            var ourCustomColorHere = element.PlaceholderColor.ToAndroid();
            SetBackgroundColor(Android.Graphics.Color.MediumAquamarine);
        }

    }
}