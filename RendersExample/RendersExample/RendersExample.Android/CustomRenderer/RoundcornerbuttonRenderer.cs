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
using RendersExample.Droid;
using RendersExample;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;


[assembly: ExportRenderer(typeof(RoundcornerButton), typeof(RoundcornerbuttonRenderer))]
namespace RendersExample.Droid
{
    using Xamarin.Forms.Platform.Android;
    using Button = Xamarin.Forms.Button;
    public  class RoundcornerbuttonRenderer: ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
         
            if (e.NewElement != null)
            {

            }
            else if(e.NewElement !=null)
            {

            }
            if(Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetShape(ShapeType.Rectangle);
                gd.SetColor(Element.BackgroundColor.ToAndroid());
                gd.SetStroke(3, Element.BorderColor.ToAndroid());
                gd.SetCornerRadius(38.0f);
                Control.SetBackground(gd);
               
            }
        }

     
    }
}