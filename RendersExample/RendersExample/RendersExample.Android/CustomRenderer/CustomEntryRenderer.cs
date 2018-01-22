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
using Android.Graphics;

[assembly: ExportRenderer(typeof(CustomEntry),typeof(CustomEntryRenderer))]
namespace RendersExample.Droid
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control == null || Element == null || e.OldElement != null) return;

            var element = (CustomEntry)Element;
            var ourCustomColorHere = element.PlaceholderColor.ToAndroid();
            SetBackgroundColor(Android.Graphics.Color.MediumAquamarine);

        }
    }
}